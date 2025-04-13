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
    }

    public class PathSaver
    {
        private static readonly string settingsFile = "settings.json";

        public static void SavePath(string path)
        {
            var settings = new AppSettings { SavedPath = path };
            string json = JsonSerializer.Serialize(settings, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(settingsFile, json);
        }

        public static string LoadPath()
        {
            if (!File.Exists(settingsFile))
                return string.Empty;

            try
            {
                string json = File.ReadAllText(settingsFile);
                var settings = JsonSerializer.Deserialize<AppSettings>(json);
                return settings?.SavedPath ?? string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
