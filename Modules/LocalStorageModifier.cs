using Microsoft.Data.Sqlite;

namespace WUWA_FPSUnlock.Modules
{
    public class LocalStorageModifier
    {
        public static bool Apply120FPSCap(string @path)
        {
            MessageBox.Show(@path);
            using (var connection = new SqliteConnection($"Data Source={@path}")) {
                connection.Open();

                // If the key "CustomFrameRate" exists, update it; otherwise insert it
                string selectQuery = "SELECT COUNT(*) FROM LocalStorage WHERE key = 'CustomFrameRate'";
                var checkCmd = new SqliteCommand(selectQuery, connection);
                long count = (long)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    string updateQuery = "UPDATE LocalStorage SET value = '120' WHERE key = 'CustomFrameRate'";
                    var updateCmd = new SqliteCommand(updateQuery, connection);
                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("Successfully set CustomFrameRate key to 120.", "Successful Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("CustomFrameRate key not found, please run the game at least once.", "Specific Key Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                connection.Close();
                return true;
                
            }
        }
    }
}
