using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WUWA_FPSUnlock.Modules
{
    public class AppSettings
    {
        public string SavedPath { get; set; }
        public int PreferredFPS { get; set; }
        public bool PersistentFPSUnlock { get; set; }
    }

    public class PathSaver
    {
        private static readonly string settingsFile = "settings.json";

        public static void SaveData(string path, int preferredfps, bool persistentfpsunlock)
        {
            var settings = new AppSettings { SavedPath = path, PreferredFPS = preferredfps, PersistentFPSUnlock = persistentfpsunlock };
            string json = JsonSerializer.Serialize(settings, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(settingsFile, json);
        }

        public static AppSettings? LoadData()
        {
            if (!File.Exists(settingsFile))
                return null;

            try
            {
                string json = File.ReadAllText(settingsFile);
                var settings = JsonSerializer.Deserialize<AppSettings>(json);
                return settings;
            }
            catch
            {
                return null;
            }
        }
    }
}
