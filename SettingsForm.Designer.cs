namespace CrosshairWatcher
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.CSGOConfigPathTextbox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.TwitchStreamLabel = new System.Windows.Forms.Label();
            this.TwitchStreamTextbox = new System.Windows.Forms.TextBox();
            this.BotUsernameLabel = new System.Windows.Forms.Label();
            this.ChatBotUsernameTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BotPasswordLabel = new System.Windows.Forms.Label();
            this.ChatBotOAuthTokenTextbox = new System.Windows.Forms.TextBox();
            this.UpdateIntervalLabel = new System.Windows.Forms.Label();
            this.UpdateIntervalTextbox = new System.Windows.Forms.TextBox();
            this.CrosshairCommandLabel = new System.Windows.Forms.Label();
            this.CrosshairCommandTextbox = new System.Windows.Forms.TextBox();
            this.CrosshairCommandLevelLabel = new System.Windows.Forms.Label();
            this.CrosshairCommandLevelCombobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GenerateOAuthTokenButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CSGO Config Path:";
            // 
            // CSGOConfigPathTextbox
            // 
            this.CSGOConfigPathTextbox.Location = new System.Drawing.Point(117, 12);
            this.CSGOConfigPathTextbox.Name = "CSGOConfigPathTextbox";
            this.CSGOConfigPathTextbox.Size = new System.Drawing.Size(291, 20);
            this.CSGOConfigPathTextbox.TabIndex = 12;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(415, 11);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(105, 23);
            this.BrowseButton.TabIndex = 2;
            this.BrowseButton.Text = "Browse...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // TwitchStreamLabel
            // 
            this.TwitchStreamLabel.AutoSize = true;
            this.TwitchStreamLabel.Location = new System.Drawing.Point(13, 46);
            this.TwitchStreamLabel.Name = "TwitchStreamLabel";
            this.TwitchStreamLabel.Size = new System.Drawing.Size(145, 13);
            this.TwitchStreamLabel.TabIndex = 3;
            this.TwitchStreamLabel.Text = "Twitch Stream (ie: summit1g):";
            // 
            // TwitchStreamTextbox
            // 
            this.TwitchStreamTextbox.Location = new System.Drawing.Point(164, 43);
            this.TwitchStreamTextbox.Name = "TwitchStreamTextbox";
            this.TwitchStreamTextbox.Size = new System.Drawing.Size(162, 20);
            this.TwitchStreamTextbox.TabIndex = 4;
            // 
            // BotUsernameLabel
            // 
            this.BotUsernameLabel.AutoSize = true;
            this.BotUsernameLabel.Location = new System.Drawing.Point(16, 101);
            this.BotUsernameLabel.Name = "BotUsernameLabel";
            this.BotUsernameLabel.Size = new System.Drawing.Size(228, 13);
            this.BotUsernameLabel.TabIndex = 5;
            this.BotUsernameLabel.Text = "Chat Bot Username (ie: summit1gCrosshairBot):";
            // 
            // ChatBotUsernameTextbox
            // 
            this.ChatBotUsernameTextbox.Location = new System.Drawing.Point(251, 99);
            this.ChatBotUsernameTextbox.Name = "ChatBotUsernameTextbox";
            this.ChatBotUsernameTextbox.Size = new System.Drawing.Size(157, 20);
            this.ChatBotUsernameTextbox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(494, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "In order to update your Nightbot command automatically, you must create a twitch " +
    "username for the bot.";
            // 
            // BotPasswordLabel
            // 
            this.BotPasswordLabel.AutoSize = true;
            this.BotPasswordLabel.Location = new System.Drawing.Point(16, 200);
            this.BotPasswordLabel.Name = "BotPasswordLabel";
            this.BotPasswordLabel.Size = new System.Drawing.Size(118, 13);
            this.BotPasswordLabel.TabIndex = 8;
            this.BotPasswordLabel.Text = "Chat Bot OAuth Token:";
            // 
            // ChatBotOAuthTokenTextbox
            // 
            this.ChatBotOAuthTokenTextbox.Location = new System.Drawing.Point(140, 197);
            this.ChatBotOAuthTokenTextbox.Name = "ChatBotOAuthTokenTextbox";
            this.ChatBotOAuthTokenTextbox.PasswordChar = '*';
            this.ChatBotOAuthTokenTextbox.Size = new System.Drawing.Size(175, 20);
            this.ChatBotOAuthTokenTextbox.TabIndex = 9;
            this.ChatBotOAuthTokenTextbox.UseSystemPasswordChar = true;
            // 
            // UpdateIntervalLabel
            // 
            this.UpdateIntervalLabel.AutoSize = true;
            this.UpdateIntervalLabel.Location = new System.Drawing.Point(13, 226);
            this.UpdateIntervalLabel.Name = "UpdateIntervalLabel";
            this.UpdateIntervalLabel.Size = new System.Drawing.Size(139, 13);
            this.UpdateIntervalLabel.TabIndex = 10;
            this.UpdateIntervalLabel.Text = "Update Interval (in minutes):";
            // 
            // UpdateIntervalTextbox
            // 
            this.UpdateIntervalTextbox.Location = new System.Drawing.Point(164, 223);
            this.UpdateIntervalTextbox.Name = "UpdateIntervalTextbox";
            this.UpdateIntervalTextbox.Size = new System.Drawing.Size(100, 20);
            this.UpdateIntervalTextbox.TabIndex = 11;
            this.UpdateIntervalTextbox.TextChanged += new System.EventHandler(this.UpdateIntervalTextbox_TextChanged);
            // 
            // CrosshairCommandLabel
            // 
            this.CrosshairCommandLabel.AutoSize = true;
            this.CrosshairCommandLabel.Location = new System.Drawing.Point(16, 254);
            this.CrosshairCommandLabel.Name = "CrosshairCommandLabel";
            this.CrosshairCommandLabel.Size = new System.Drawing.Size(199, 13);
            this.CrosshairCommandLabel.TabIndex = 13;
            this.CrosshairCommandLabel.Text = "Crosshair Chat Command (ex: !crosshair):";
            // 
            // CrosshairCommandTextbox
            // 
            this.CrosshairCommandTextbox.Location = new System.Drawing.Point(215, 249);
            this.CrosshairCommandTextbox.Name = "CrosshairCommandTextbox";
            this.CrosshairCommandTextbox.Size = new System.Drawing.Size(139, 20);
            this.CrosshairCommandTextbox.TabIndex = 14;
            // 
            // CrosshairCommandLevelLabel
            // 
            this.CrosshairCommandLevelLabel.AutoSize = true;
            this.CrosshairCommandLevelLabel.Location = new System.Drawing.Point(16, 280);
            this.CrosshairCommandLevelLabel.Name = "CrosshairCommandLevelLabel";
            this.CrosshairCommandLevelLabel.Size = new System.Drawing.Size(132, 13);
            this.CrosshairCommandLevelLabel.TabIndex = 15;
            this.CrosshairCommandLevelLabel.Text = "Crosshair Command Level:";
            // 
            // CrosshairCommandLevelCombobox
            // 
            this.CrosshairCommandLevelCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CrosshairCommandLevelCombobox.FormattingEnabled = true;
            this.CrosshairCommandLevelCombobox.Items.AddRange(new object[] {
            "everyone",
            "owner",
            "mod",
            "reg"});
            this.CrosshairCommandLevelCombobox.Location = new System.Drawing.Point(154, 276);
            this.CrosshairCommandLevelCombobox.Name = "CrosshairCommandLevelCombobox";
            this.CrosshairCommandLevelCombobox.Size = new System.Drawing.Size(121, 21);
            this.CrosshairCommandLevelCombobox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Generate an OAuth token for your Chat Bot:";
            // 
            // GenerateOAuthTokenButton
            // 
            this.GenerateOAuthTokenButton.Location = new System.Drawing.Point(239, 127);
            this.GenerateOAuthTokenButton.Name = "GenerateOAuthTokenButton";
            this.GenerateOAuthTokenButton.Size = new System.Drawing.Size(147, 23);
            this.GenerateOAuthTokenButton.TabIndex = 18;
            this.GenerateOAuthTokenButton.Text = "Generate OAuth Token";
            this.GenerateOAuthTokenButton.UseVisualStyleBackColor = true;
            this.GenerateOAuthTokenButton.Click += new System.EventHandler(this.GenerateOAuthTokenButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Once you have generated the OAuth token, paste it in the box below.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "ie: oauth:xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(16, 311);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 22;
            this.Close.Text = "Finish";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 346);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GenerateOAuthTokenButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CrosshairCommandLevelCombobox);
            this.Controls.Add(this.CrosshairCommandLevelLabel);
            this.Controls.Add(this.CrosshairCommandTextbox);
            this.Controls.Add(this.CrosshairCommandLabel);
            this.Controls.Add(this.UpdateIntervalTextbox);
            this.Controls.Add(this.UpdateIntervalLabel);
            this.Controls.Add(this.ChatBotOAuthTokenTextbox);
            this.Controls.Add(this.BotPasswordLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChatBotUsernameTextbox);
            this.Controls.Add(this.BotUsernameLabel);
            this.Controls.Add(this.TwitchStreamTextbox);
            this.Controls.Add(this.TwitchStreamLabel);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.CSGOConfigPathTextbox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "CrosshairWatcher Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CSGOConfigPathTextbox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Label TwitchStreamLabel;
        private System.Windows.Forms.TextBox TwitchStreamTextbox;
        private System.Windows.Forms.Label BotUsernameLabel;
        private System.Windows.Forms.TextBox ChatBotUsernameTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label BotPasswordLabel;
        private System.Windows.Forms.TextBox ChatBotOAuthTokenTextbox;
        private System.Windows.Forms.Label UpdateIntervalLabel;
        private System.Windows.Forms.TextBox UpdateIntervalTextbox;
        private System.Windows.Forms.Label CrosshairCommandLabel;
        private System.Windows.Forms.TextBox CrosshairCommandTextbox;
        private System.Windows.Forms.Label CrosshairCommandLevelLabel;
        private System.Windows.Forms.ComboBox CrosshairCommandLevelCombobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GenerateOAuthTokenButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Close;
    }
}