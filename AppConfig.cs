using System;
using System.IO;
using Newtonsoft.Json;

namespace CrosshairWatcher
{
    public class AppConfig
    {
        public string CsgoConfigFilePath;
        public int UpdateIntervalMinutes;
        public string TwitchStream;
        public string ChatBotUsername;
        public string ChatBotOAuthToken;
        public string ChatCommandLevel;
        public string ChatCommandTrigger;

        public static AppConfig Load(string configFile)
        {
            var contents = File.ReadAllText(configFile);
            var config = JsonConvert.DeserializeObject<AppConfig>(contents);

            return config;
        }

        public void Save(string configFile)
        {
            File.WriteAllText(configFile, JsonConvert.SerializeObject(this));
        }
    }
}