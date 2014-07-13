using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CrosshairWatcher
{
    public partial class SettingsForm : Form
    {
        private MainForm _mainForm;

        public SettingsForm(MainForm mainForm)
        {
            _mainForm = mainForm;

            InitializeComponent();

            PopulateSettingsFromAppConfig();
        }

        private void PopulateSettingsFromAppConfig()
        {
            CSGOConfigPathTextbox.Text = _mainForm.AppConfig.CsgoConfigFilePath;
            UpdateIntervalTextbox.Text = _mainForm.AppConfig.UpdateIntervalMinutes.ToString(CultureInfo.InvariantCulture);
            TwitchStreamTextbox.Text = _mainForm.AppConfig.TwitchStream;
            ChatBotUsernameTextbox.Text = _mainForm.AppConfig.ChatBotUsername;
            ChatBotOAuthTokenTextbox.Text = _mainForm.AppConfig.ChatBotOAuthToken;
            CrosshairCommandTextbox.Text = _mainForm.AppConfig.ChatCommandTrigger;
            
            foreach(var item in CrosshairCommandLevelCombobox.Items)
            {
                var itemAsString = (string) item;
                if(itemAsString != _mainForm.AppConfig.ChatCommandLevel)
                {
                    continue;
                }

                CrosshairCommandLevelCombobox.SelectedItem = item;
                break;
            }
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CloseForm())
                e.Cancel = true;
        }

        private bool CloseForm()
        {
            var result =
                MessageBox.Show("Would you like to save your changes?",
                                "Save Changes?", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Cancel)
            {
                return false;
            }
            else if (result == DialogResult.Yes)
            {
                if (UpdateIntervalTextbox.Text.Trim() == "")
                {
                    UpdateIntervalTextbox.Text = "5";
                }

                _mainForm.AppConfig.CsgoConfigFilePath = CSGOConfigPathTextbox.Text;
                _mainForm.AppConfig.UpdateIntervalMinutes = int.Parse(UpdateIntervalTextbox.Text);
                _mainForm.AppConfig.TwitchStream = TwitchStreamTextbox.Text;
                _mainForm.AppConfig.ChatBotUsername = ChatBotUsernameTextbox.Text;
                _mainForm.AppConfig.ChatBotOAuthToken = ChatBotOAuthTokenTextbox.Text;
                _mainForm.AppConfig.ChatCommandTrigger = CrosshairCommandTextbox.Text;
                _mainForm.AppConfig.ChatCommandLevel = (string)CrosshairCommandLevelCombobox.SelectedItem;

                string configDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\CrosshairWatcher\\";

                if (!Directory.Exists(configDirectory))
                    Directory.CreateDirectory(configDirectory);

                string configFile = configDirectory + "config.json";

                _mainForm.AppConfig.Save(configFile);
            }

            _mainForm.Show();
            _mainForm.UpdateStatusAndRefreshCsgoConfig();

            return true;
        }

        private void UpdateIntervalTextbox_TextChanged(object sender, EventArgs e)
        {
            if(UpdateIntervalTextbox.Text.Trim() == "")
            {
                return;
            }

            int n;
            bool isNumeric = Regex.IsMatch(UpdateIntervalTextbox.Text, @"^\d+$");

            if(!isNumeric)
            {
                UpdateIntervalTextbox.Text = "10";
            }
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "cfg files|*.cfg";
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                CSGOConfigPathTextbox.Text = dialog.FileName;
            }
        }

        private void GenerateOAuthTokenButton_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.twitchapps.com/tmi");
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
