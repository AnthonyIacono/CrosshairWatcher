using System.IO;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace CrosshairWatcher
{
    public class SteamHelper
    {
        public string GetSteamDirectoryFromRegistry()
        {
            var steamPath = (string) Registry.GetValue("HKEY_CURRENT_USER\\Software\\Valve\\Steam", "SteamPath", null);
            return steamPath;
        }

        public string GetCsgoDirectoryFromConfigVdf(string steamPath)
        {
            string vdfPath = steamPath + "\\config\\config.vdf";

            if(!File.Exists(vdfPath))
            {
                return null;
            }

            string vdfContents = File.ReadAllText(vdfPath);

            var match = Regex.Match(vdfContents, "\\\"730\\\"\\s+\\{([^\\}]+)\\}");

            if(!match.Success)
            {
                return null;
            }

            var sectionText = match.Groups[1].Value;

            match = Regex.Match(sectionText, "\\\"installdir\\\"\\s+\\\"([^\\\"]+)\\\"");

            if (!match.Success)
            {
                return null;
            }

            var directoryEncoded = match.Groups[1].Value;
            var rawDirectory = directoryEncoded.Replace("\\\\", "\\");

            return rawDirectory;
        }

        public string GetConfigPathFromCsgoDirectory(string csgoDirectory)
        {
            return csgoDirectory + "\\csgo\\cfg\\config.cfg";
        }
    }
}