using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using IrcDotNet;
using Timer = System.Windows.Forms.Timer;

namespace CrosshairWatcher
{
    public partial class MainForm : Form
    {
        public AppConfig AppConfig;
        private DateTime _lastUpdated;

        public enum ChatBotStatus
        {
            NotConnected = 0,
            Connecting = 1,
            Connected = 2,
        };

        private IrcClient _chatClient;
        private bool _chatClientFailedToConnect = false;
        private bool _chatClientFailedToLogin = false;
        private bool _isUpdatingChatCommand = false;
        private DateTime _updatingChatCommandStartTime;
        private bool _isWaitingForMod = false;
        public ChatBotStatus BotStatus;
        private DateTime _waitingForModStartTime;
        private string _currentCrosshair;

        public MainForm(AppConfig appConfig)
        {
            _lastUpdated = DateTime.MinValue;
            AppConfig = appConfig;
            BotStatus = ChatBotStatus.NotConnected;
            _chatClient = null;

            InitializeComponent();

            UpdateStatusAndRefreshCsgoConfig();
        }

        public void UpdateStatusAndRefreshCsgoConfig()
        {
            LastUpdatedLabel.Text = "Last Updated: " +
                                    (_lastUpdated == DateTime.MinValue
                                         ? "Never"
                                         : _lastUpdated.ToString());

            UpdateIntervalLabel.Text = "Update Interval: " + AppConfig.UpdateIntervalMinutes + "mins";

            if(string.IsNullOrWhiteSpace(AppConfig.CsgoConfigFilePath) ||
                !File.Exists(AppConfig.CsgoConfigFilePath) || string.IsNullOrWhiteSpace(AppConfig.TwitchStream) ||
                string.IsNullOrWhiteSpace(AppConfig.ChatBotUsername) || string.IsNullOrWhiteSpace(AppConfig.ChatBotOAuthToken) ||
                string.IsNullOrWhiteSpace(AppConfig.ChatCommandTrigger))
            {
                StatusLabel.Text = "Status: Please click settings to configure CrosshairWatcher.";
                CurrentCrosshairTextbox.Text = "Not Available";
                TwitchBotStatusLabel.Text = "Twitch Bot Status: Not Connected";
            }
            else
            {
                StatusLabel.Text = "Status: OK";
                TwitchBotStatusLabel.Text = "Twitch Bot Status: Not Connected";
                RefreshCsgoConfiguration();
            }
        }

        public void TriggerChatBot()
        {
            _chatClientFailedToConnect = false;
            _chatClientFailedToLogin = false;
            _isUpdatingChatCommand = false;
            _isWaitingForMod = false;

            _chatClient = new IrcClient();

            var userInfo = new IrcUserRegistrationInfo()
                               {
                                   NickName = AppConfig.ChatBotUsername,
                                   Password = AppConfig.ChatBotOAuthToken,
                                   UserName = AppConfig.ChatBotUsername,
                                   RealName = AppConfig.ChatBotUsername
                               };

            _chatClient.RawMessageReceived += (sender, args) =>
                                             {
                                                 if(args.RawContent.EndsWith("Login unsuccessful"))
                                                 {
                                                     _chatClientFailedToLogin = true;
                                                     _chatClient.Disconnect();
                                                     return;
                                                 }
                                             };

            _chatClient.Connected += (_, __) =>
                                         {
                                             BotStatus = ChatBotStatus.Connected;

                                             _chatClient.Channels.Join("#" + AppConfig.TwitchStream);

                                             // TODO: Locking code
                                             while (_chatClient.Channels.Count == 0)
                                             {
                                             }

                                             _isWaitingForMod = true;
                                             _waitingForModStartTime = DateTime.Now;

                                             _chatClient.SendRawMessage("PRIVMSG #" + AppConfig.TwitchStream + " :Hello chat, let me update the crosshair for you!");
                                         };

            _chatClient.ConnectFailed += (sender, args) =>
                                             {
                                                _chatClientFailedToConnect = true;
                                                BotStatus = ChatBotStatus.NotConnected;
                                             };

            _chatClient.Disconnected += (sender, args) =>
                                       {
                                           BotStatus = ChatBotStatus.NotConnected;
                                           _chatClient.Dispose();
                                       };

            BotStatus = ChatBotStatus.Connecting;
            _chatClient.Connect("irc.twitch.tv", 6667, false, userInfo);
        }

        public void SetCurrentCrosshair(string fullCrosshairString)
        {
            _currentCrosshair = fullCrosshairString;
            CurrentCrosshairTextbox.Text = fullCrosshairString;
        }

        public void RefreshCsgoConfiguration()
        {
            _lastUpdated = DateTime.Now;
            LastUpdatedLabel.Text = "Last Updated: " + _lastUpdated.ToString();

            var helper = new CsgoConfigHelper();
            var fullCrosshairString = helper.GetFullCrosshairString(AppConfig.CsgoConfigFilePath);

            SetCurrentCrosshair(fullCrosshairString);
            
            TriggerChatBot();
        }

        private void RefreshManuallyButton_Click(object sender, EventArgs e)
        {
            UpdateStatusAndRefreshCsgoConfig();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm(this);
            this.Hide();

            settingsForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Tick += new EventHandler(MainTimer_Callback);
            timer.Start();
        }

        private void MainTimer_Callback(object sender, EventArgs e)
        {
            NextUpdateLabel.Text = String.Format("Next Update: {0}",
                                                 _lastUpdated.AddMinutes(Math.Max(AppConfig.UpdateIntervalMinutes, 2)));

            if(BotStatus == ChatBotStatus.NotConnected)
            {
                if(_chatClientFailedToConnect || _chatClientFailedToLogin)
                {
                    TwitchBotStatusLabel.Text = "Twitch Bot Status: Failed to connect or login to bot, please fix your settings!";
                }
                else
                {
                    TwitchBotStatusLabel.Text = "Twitch Bot Status: Not Connected";
                }
            }
            else if(BotStatus == ChatBotStatus.Connecting)
            {
                TwitchBotStatusLabel.Text = "Twitch Bot Status: Connecting";
            }
            else if(BotStatus == ChatBotStatus.Connected)
            {
                if(_isWaitingForMod)
                {
                    if (DateTime.Now >= _waitingForModStartTime.AddSeconds(10))
                    {
                        _isWaitingForMod = false;
                        _isUpdatingChatCommand = true;
                        _updatingChatCommandStartTime = DateTime.Now;
                        TwitchBotStatusLabel.Text = "Twitch Bot Status: Updating crosshair chat command...";

                        var chatMessage = "!editcom ";
                        
                        if(AppConfig.ChatCommandLevel != "everyone")
                        {
                            chatMessage += "-ul=" + AppConfig.ChatCommandLevel + " ";
                        }

                        chatMessage += AppConfig.ChatCommandTrigger + " " + _currentCrosshair;

                        _chatClient.SendRawMessage("PRIVMSG #" + AppConfig.TwitchStream + " :" + chatMessage);
                    }
                    else
                    {
                        TwitchBotStatusLabel.Text =
                        String.Format("Twitch Bot Status: Waiting {0} seconds for moderator permissions...",
                                      Math.Round(
                                          _waitingForModStartTime.AddSeconds(10).Subtract(DateTime.Now).TotalSeconds));
                    }
                }
                else if(_isUpdatingChatCommand)
                {
                    if (DateTime.Now >= _updatingChatCommandStartTime.AddSeconds(10))
                    {
                        _isUpdatingChatCommand = false;
                        BotStatus = ChatBotStatus.NotConnected;
                        _chatClient.Disconnect();
                    }
                    else
                    {
                        TwitchBotStatusLabel.Text =
                        String.Format("Twitch Bot Status: Waiting {0} seconds then disconnecting...",
                                      Math.Round(
                                          _updatingChatCommandStartTime.AddSeconds(10).Subtract(DateTime.Now).TotalSeconds));
                    }
                }
            }

            if(DateTime.Now < _lastUpdated.AddMinutes(Math.Max(AppConfig.UpdateIntervalMinutes, 2)))
            {
                return;
            }

            UpdateStatusAndRefreshCsgoConfig();
        }
    }
}
