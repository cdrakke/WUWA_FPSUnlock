using WUWA_FPSUnlock.Modules;

namespace WUWA_FPSUnlock
{
    public partial class Main : Form
    {
        private string FileName = "LocalStorage.db";
        public Main()
        {
            InitializeComponent();

            string prePath = PathSaver.LoadPath();
            if (!string.IsNullOrEmpty(prePath)) {
                pathTB.Text = prePath;
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            // Preliminary Check
            if (string.IsNullOrEmpty(pathTB.Text)) {
                MessageBox.Show("Path can't be empty", "No Path Provided", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string path = @pathTB.Text;
            string[] paths = path.Split('/');
            if (paths.Length == 1) { 
                paths = path.Split('\\');
            }

            // Checks
            if (paths.Length == 1) {
                MessageBox.Show("Invalid file path? Please make sure you entered in the Wuthering Waves' Local Storage database file path.", "Malformed Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!paths[^1].Equals(FileName)) // Funky ass new C# 8.0 Index from end operator lol
            {
                MessageBox.Show("Unexpected file. Please make sure you entered in the Wuthering Waves' Local Storage database file path.", "File Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!File.Exists(path)) {
                MessageBox.Show("File in path does not exist, please make sure to run the game at least once.", "File not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (LocalStorageModifier.Apply120FPSCap(@path))
            {
                PathSaver.SavePath(@path);
            }

            this.Dispose();
            this.Close();
        }
    }
}
