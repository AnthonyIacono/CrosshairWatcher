using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CrosshairWatcher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Load our configuration
            string configDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\CrosshairWatcher\\";

            if(!Directory.Exists(configDirectory))
                Directory.CreateDirectory(configDirectory);

            string configFile = configDirectory + "config.json";

            AppConfig config;

            if (File.Exists(configFile))
            {
                config = AppConfig.Load(configFile);
            }
            else
            {
                var helper = new SteamHelper();
                string csgoConfigFilePath = "";
                var steamPath = helper.GetSteamDirectoryFromRegistry();

                if(steamPath != null)
                {
                    var csgoDirectory = helper.GetCsgoDirectoryFromConfigVdf(steamPath);

                    if (csgoDirectory != null)
                    {
                        csgoConfigFilePath = helper.GetConfigPathFromCsgoDirectory(csgoDirectory);
                    }
                }

                config = new AppConfig()
                             {
                                 CsgoConfigFilePath = csgoConfigFilePath,
                                 UpdateIntervalMinutes = 30,
                                 ChatCommandLevel = "everyone",
                                 ChatCommandTrigger = "!crosshair"
                             };
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(config));
        }
    }
}
