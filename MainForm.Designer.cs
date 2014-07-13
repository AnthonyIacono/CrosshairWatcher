namespace CrosshairWatcher
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.StatusLabel = new System.Windows.Forms.Label();
            this.CurrentCrosshairLabel = new System.Windows.Forms.Label();
            this.CurrentCrosshairTextbox = new System.Windows.Forms.TextBox();
            this.TwitchBotStatusLabel = new System.Windows.Forms.Label();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.RefreshManuallyButton = new System.Windows.Forms.Button();
            this.LastUpdatedLabel = new System.Windows.Forms.Label();
            this.UpdateIntervalLabel = new System.Windows.Forms.Label();
            this.NextUpdateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(12, 9);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(90, 13);
            this.StatusLabel.TabIndex = 0;
            this.StatusLabel.Text = "Status: Loading...";
            // 
            // CurrentCrosshairLabel
            // 
            this.CurrentCrosshairLabel.AutoSize = true;
            this.CurrentCrosshairLabel.Location = new System.Drawing.Point(12, 35);
            this.CurrentCrosshairLabel.Name = "CurrentCrosshairLabel";
            this.CurrentCrosshairLabel.Size = new System.Drawing.Size(90, 13);
            this.CurrentCrosshairLabel.TabIndex = 1;
            this.CurrentCrosshairLabel.Text = "Current Crosshair:";
            // 
            // CurrentCrosshairTextbox
            // 
            this.CurrentCrosshairTextbox.Location = new System.Drawing.Point(109, 35);
            this.CurrentCrosshairTextbox.Multiline = true;
            this.CurrentCrosshairTextbox.Name = "CurrentCrosshairTextbox";
            this.CurrentCrosshairTextbox.ReadOnly = true;
            this.CurrentCrosshairTextbox.Size = new System.Drawing.Size(347, 117);
            this.CurrentCrosshairTextbox.TabIndex = 2;
            this.CurrentCrosshairTextbox.TabStop = false;
            this.CurrentCrosshairTextbox.Text = "Not Available";
            // 
            // TwitchBotStatusLabel
            // 
            this.TwitchBotStatusLabel.AutoSize = true;
            this.TwitchBotStatusLabel.Location = new System.Drawing.Point(13, 167);
            this.TwitchBotStatusLabel.Name = "TwitchBotStatusLabel";
            this.TwitchBotStatusLabel.Size = new System.Drawing.Size(160, 13);
            this.TwitchBotStatusLabel.TabIndex = 3;
            this.TwitchBotStatusLabel.Text = "Twitch Bot Status: Not Available";
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(381, 252);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(75, 23);
            this.SettingsButton.TabIndex = 4;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // RefreshManuallyButton
            // 
            this.RefreshManuallyButton.Location = new System.Drawing.Point(210, 252);
            this.RefreshManuallyButton.Name = "RefreshManuallyButton";
            this.RefreshManuallyButton.Size = new System.Drawing.Size(165, 23);
            this.RefreshManuallyButton.TabIndex = 5;
            this.RefreshManuallyButton.Text = "Refresh Crosshair Manually";
            this.RefreshManuallyButton.UseVisualStyleBackColor = true;
            this.RefreshManuallyButton.Click += new System.EventHandler(this.RefreshManuallyButton_Click);
            // 
            // LastUpdatedLabel
            // 
            this.LastUpdatedLabel.AutoSize = true;
            this.LastUpdatedLabel.Location = new System.Drawing.Point(13, 189);
            this.LastUpdatedLabel.Name = "LastUpdatedLabel";
            this.LastUpdatedLabel.Size = new System.Drawing.Size(140, 13);
            this.LastUpdatedLabel.TabIndex = 6;
            this.LastUpdatedLabel.Text = "Last Updated: Not Available";
            // 
            // UpdateIntervalLabel
            // 
            this.UpdateIntervalLabel.AutoSize = true;
            this.UpdateIntervalLabel.Location = new System.Drawing.Point(13, 212);
            this.UpdateIntervalLabel.Name = "UpdateIntervalLabel";
            this.UpdateIntervalLabel.Size = new System.Drawing.Size(149, 13);
            this.UpdateIntervalLabel.TabIndex = 7;
            this.UpdateIntervalLabel.Text = "Update Interval: Not Available";
            // 
            // NextUpdateLabel
            // 
            this.NextUpdateLabel.AutoSize = true;
            this.NextUpdateLabel.Location = new System.Drawing.Point(13, 235);
            this.NextUpdateLabel.Name = "NextUpdateLabel";
            this.NextUpdateLabel.Size = new System.Drawing.Size(136, 13);
            this.NextUpdateLabel.TabIndex = 8;
            this.NextUpdateLabel.Text = "Next Update: Not Available";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 287);
            this.Controls.Add(this.NextUpdateLabel);
            this.Controls.Add(this.UpdateIntervalLabel);
            this.Controls.Add(this.LastUpdatedLabel);
            this.Controls.Add(this.RefreshManuallyButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.TwitchBotStatusLabel);
            this.Controls.Add(this.CurrentCrosshairTextbox);
            this.Controls.Add(this.CurrentCrosshairLabel);
            this.Controls.Add(this.StatusLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "CrosshairWatcher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label CurrentCrosshairLabel;
        private System.Windows.Forms.TextBox CurrentCrosshairTextbox;
        private System.Windows.Forms.Label TwitchBotStatusLabel;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button RefreshManuallyButton;
        private System.Windows.Forms.Label LastUpdatedLabel;
        private System.Windows.Forms.Label UpdateIntervalLabel;
        private System.Windows.Forms.Label NextUpdateLabel;
    }
}

