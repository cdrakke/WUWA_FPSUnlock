using WUWA_FPSUnlock.Modules;

namespace WUWA_FPSUnlock
{
    public partial class Main : Form
    {
        private string RootPath;
        private string ModifiedPath;
        private string DBPathAfterRoot = @"\Wuthering Waves Game\Client\Saved\LocalStorage";
        private string DBPathAfterRootGame = @"\Client\Saved\LocalStorage";
        private string DBPathFull;
        private string FileName = "LocalStorage.db";
        private int PreferredFPS;
        private bool isPersistentFPSUnlockOn = false;
        private bool ControlsEnabled = false;
        public Main()
        {
            InitializeComponent();

            AppSettings prePath = PathSaver.LoadData();

            if (prePath != null)
            {
                if (!string.IsNullOrEmpty(prePath.SavedPath))
                {
                    pathTB.Text = prePath.SavedPath;

                    if (prePath.PersistentFPSUnlock)
                    {
                        cb_persistentUnlock.Checked = true;
                    }

                    if (prePath.PreferredFPS == 120)
                    {
                        btn_radio120.Checked = true;
                    }
                    else if (prePath.PreferredFPS == 90)
                    {
                        btn_radio90.Checked = true;
                    }
                    else if (prePath.PreferredFPS == 75)
                    {
                        btn_radio75.Checked = true;
                    }

                    ControlsEnabled = true;
                    ToggleControls();
                }
                else
                {
                    ControlsEnabled = false;
                    ToggleControls();
                }
            }
            else
            {
                ControlsEnabled = false;
                ToggleControls();
            }
        }

        private void ToggleControls()
        {
            if (ControlsEnabled) {
                btn_Submit.Enabled = true;
                btn_radio120.Enabled = true;
                btn_radio90.Enabled = true;
                btn_radio75.Enabled = true;
                cb_persistentUnlock.Enabled = true;
            }
            else
            {
                btn_Submit.Enabled = false;
                btn_radio120.Enabled = false;
                btn_radio90.Enabled = false;
                btn_radio75.Enabled = false;
                cb_persistentUnlock.Enabled = false;
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            // Preliminary Check
            if (string.IsNullOrEmpty(pathTB.Text))
            {
                MessageBox.Show("Path can't be empty", "No Path Provided", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string path = @DBPathFull;
            string[] paths = path.Split('/');
            if (paths.Length == 1)
            {
                paths = path.Split('\\');
            }

            // Checks
            if (paths.Length == 1)
            {
                MessageBox.Show("Invalid file path? Please make sure you entered in the Wuthering Waves' Local Storage database file path.", "Malformed Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!paths[^1].Equals(FileName)) // Funky ass new C# 8.0 Index from end operator lol
            {
                MessageBox.Show("Unexpected file. Please make sure you entered in the Wuthering Waves' Local Storage database file path.", "File Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(path))
            {
                MessageBox.Show("Unrecognized path or file in path does not exist, please make sure to run the game at least once.", "File not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (btn_radio120.Checked)
            {
                PreferredFPS = 120;
                isPersistentFPSUnlockOn = cb_persistentUnlock.Checked;
                if (LocalStorageModifier.ApplyFPSCap(@path, 120, isPersistentFPSUnlockOn))
                {
                    PathSaver.SaveData(@RootPath, PreferredFPS, isPersistentFPSUnlockOn);
                }
            }
            else if (btn_radio90.Checked)
            {
                PreferredFPS = 90;
                isPersistentFPSUnlockOn = cb_persistentUnlock.Checked;
                if (LocalStorageModifier.ApplyFPSCap(@path, 90, isPersistentFPSUnlockOn))
                {
                    PathSaver.SaveData(@RootPath, PreferredFPS, isPersistentFPSUnlockOn);
                }
            }
            else if (btn_radio75.Checked)
            {
                PreferredFPS = 75;
                isPersistentFPSUnlockOn = cb_persistentUnlock.Checked;
                if (LocalStorageModifier.ApplyFPSCap(@path, 75, isPersistentFPSUnlockOn))
                {
                    PathSaver.SaveData(@RootPath, PreferredFPS, isPersistentFPSUnlockOn);
                }
            }

            this.Dispose();
            this.Close();
        }

        private void pathTB_TextChanged(object sender, EventArgs e)
        {
            ModifiedPath = pathTB.Text;

            string path = @pathTB.Text;
            string[] paths = path.Split('/');
            if (paths.Length == 1)
            {
                paths = path.Split('\\');
            }

            if (paths[^1].Equals("Wuthering Waves"))
            {
                RootPath = pathTB.Text;
                ModifiedPath = $@"{ModifiedPath}{DBPathAfterRoot}";
            }
            else if (paths[^1].Equals("Wuthering Waves Game"))
            {
                RootPath = pathTB.Text;
                ModifiedPath = $@"{ModifiedPath}{DBPathAfterRootGame}";
            }

            DBPathFull = $@"{ModifiedPath}\{FileName}";
            string[] full_paths = DBPathFull.Split("/");
            if (full_paths.Length == 1)
            {
                full_paths = DBPathFull.Split('\\');
            }

            // Checks
            if (full_paths.Length == 1)
            {
                MessageBox.Show("Invalid file path? Please make sure you entered in the Wuthering Waves' Local Storage database file path.", "Malformed Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!full_paths[^1].Equals(FileName)) // Funky ass new C# 8.0 Index from end operator lol
            {
                MessageBox.Show("Unexpected file. Please make sure you entered in the Wuthering Waves' Local Storage database file path.", "File Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(DBPathFull))
            {
                MessageBox.Show("File in path does not exist, please make sure to run the game at least once.", "File not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ControlsEnabled = true;
            ToggleControls();
        }

        private void btn_FolderSelect_Click(object sender, EventArgs e)
        {
            using (fbd_FolderSelect)
            {
                DialogResult result = fbd_FolderSelect.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrEmpty(fbd_FolderSelect.SelectedPath)) { 
                    pathTB.Text = fbd_FolderSelect.SelectedPath;
                }
            }
        }
    }
}
