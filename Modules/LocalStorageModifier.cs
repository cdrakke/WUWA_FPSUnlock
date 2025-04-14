using Microsoft.Data.Sqlite;

namespace WUWA_FPSUnlock.Modules
{
    public class LocalStorageModifier
    {
        public static bool ApplyFPSCap(string @path, int fps, bool fps_persistent)
        {
            bool PersistentFPSApplied = false;
            bool NewFPSCapApplied = false;
            using (var connection = new SqliteConnection($"Data Source={@path}")) {
                connection.Open();

                if (fps_persistent)
                {
                    // Check if the trigger already exists
                    string triggerCheckQuery = "SELECT COUNT(*) FROM sqlite_master WHERE type = 'trigger' AND name = 'prevent_custom_frame_rate_update'";
                    var triggerCheckCmd = new SqliteCommand(triggerCheckQuery, connection);
                    long triggerExists = (long)triggerCheckCmd.ExecuteScalar();

                    if (triggerExists > 0)
                    {
                        // Drop the existing trigger
                        string dropTrigger = "DROP TRIGGER IF EXISTS prevent_custom_frame_rate_update";
                        var dropCmd = new SqliteCommand(dropTrigger, connection);
                        dropCmd.ExecuteNonQuery();
                    }

                    // Create the trigger with the new FPS value
                    string createTrigger = @$"
                        CREATE TRIGGER prevent_custom_frame_rate_update
                        AFTER UPDATE OF value ON LocalStorage
                        WHEN NEW.key = 'CustomFrameRate'
                        BEGIN
                            UPDATE LocalStorage
                            SET value = {fps}
                            WHERE key = 'CustomFrameRate';
                        END;";
                    var triggerCmd = new SqliteCommand(createTrigger, connection);
                    triggerCmd.ExecuteNonQuery();

                    PersistentFPSApplied = true;
                    //MessageBox.Show($"Persistent FPS trigger created (FPS = {fps}).", "Trigger Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // If the key "CustomFrameRate" exists, update it; otherwise insert it
                string selectQuery = "SELECT COUNT(*) FROM LocalStorage WHERE key = 'CustomFrameRate'";
                var checkCmd = new SqliteCommand(selectQuery, connection);
                long count = (long)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    string updateQuery = $"UPDATE LocalStorage SET value = '{fps}' WHERE key = 'CustomFrameRate'";
                    var updateCmd = new SqliteCommand(updateQuery, connection);
                    updateCmd.ExecuteNonQuery();

                    NewFPSCapApplied = true;
                    //MessageBox.Show($"Successfully set CustomFrameRate key to {fps}.", "Successful Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("CustomFrameRate key not found, please run the game at least once.", "Specific Key Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                    return false;
                }

                string message = "Modification Results:";
                if (NewFPSCapApplied)
                {
                    message += $"\nNew FPS cap applied: {fps}";
                }

                if (PersistentFPSApplied) {
                    message += $"\nAdded persistent FPS cap trigger for {fps} fps";
                }

                MessageBox.Show(message, "Modification Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                connection.Close();
                return true;
                
            }
        }
    }
}
