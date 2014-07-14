using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace CrosshairWatcher
{
    public class CsgoConfigHelper
    {
        public string GetCrosshairVariableString(string crosshairVariable, List<string> crosshairCommands, string defaultValue)
        {
            foreach(var command in crosshairCommands)
            {
                if(!Regex.IsMatch(command, "^" + crosshairVariable + "\\s"))
                {
                    continue;
                }
                
                var variableValue = command.Substring(crosshairVariable.Length)
                    .Replace("\"", "").Replace("'", "").Trim();

                return crosshairVariable + " \"" + variableValue + "\"";
            }

            return crosshairVariable + " \"" + defaultValue + "\"";
        }

        public string GetFullCrosshairString(string csgoConfigFilePath)
        {
            if(!File.Exists(csgoConfigFilePath))
            {
                return null;
            }

            string[] configLines = File.ReadAllLines(csgoConfigFilePath);
            var crosshairCommands = new List<string>();

            foreach(var configLine in configLines)
            {
                string trimmedLine = configLine.Trim();
                
                if(trimmedLine.StartsWith("cl_crosshair") || trimmedLine.StartsWith("cl_fixedcrosshairgap"))
                {
                    crosshairCommands.Add(trimmedLine);
                }
            }

            string fullCrosshairString = "";

            fullCrosshairString += GetCrosshairVariableString("cl_crosshairstyle", crosshairCommands, "0") + ";";
            fullCrosshairString += GetCrosshairVariableString("cl_crosshairalpha", crosshairCommands, "200") + ";";
            fullCrosshairString += GetCrosshairVariableString("cl_crosshaircolor", crosshairCommands, "1") + ";";
            fullCrosshairString += GetCrosshairVariableString("cl_crosshaircolor_b", crosshairCommands, "50") + ";";
            fullCrosshairString += GetCrosshairVariableString("cl_crosshaircolor_r", crosshairCommands, "50") + ";";
            fullCrosshairString += GetCrosshairVariableString("cl_crosshaircolor_g", crosshairCommands, "250") + ";";
            fullCrosshairString += GetCrosshairVariableString("cl_crosshairdot", crosshairCommands, "1") + ";";
            fullCrosshairString += GetCrosshairVariableString("cl_crosshairgap", crosshairCommands, "1") + ";";
            fullCrosshairString += GetCrosshairVariableString("cl_crosshairsize", crosshairCommands, "5") + ";";
            fullCrosshairString += GetCrosshairVariableString("cl_crosshairusealpha", crosshairCommands, "1") + ";";
            fullCrosshairString += GetCrosshairVariableString("cl_crosshairthickness", crosshairCommands, "0.5") + ";";
            fullCrosshairString += GetCrosshairVariableString("cl_fixedcrosshairgap", crosshairCommands, "3") + ";";
            fullCrosshairString += GetCrosshairVariableString("cl_crosshair_drawoutline", crosshairCommands, "1") + ";";
            fullCrosshairString += GetCrosshairVariableString("cl_crosshair_outlinethickness", crosshairCommands, "1") + ";";
            fullCrosshairString += GetCrosshairVariableString("cl_crosshair_dynamic_maxdist_splitratio", crosshairCommands, "0.35") + ";";
            fullCrosshairString += GetCrosshairVariableString("cl_crosshair_dynamic_splitalpha_innermod", crosshairCommands, "1") + ";";
            fullCrosshairString += GetCrosshairVariableString("cl_crosshair_dynamic_splitalpha_outermod", crosshairCommands, "0.5") + ";";
            fullCrosshairString += GetCrosshairVariableString("cl_crosshair_dynamic_splitdist", crosshairCommands, "7") + ";";

            return fullCrosshairString;
        }
    }
}