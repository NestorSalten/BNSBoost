﻿namespace BNSBoost
{
    partial class BNSBoostForm
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
            this.LaunchButton = new System.Windows.Forms.Button();
            this.GameTabPage = new System.Windows.Forms.TabPage();
            this.GameTabPanel = new System.Windows.Forms.Panel();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.LauncherPathLabel = new System.Windows.Forms.Label();
            this.DisableLoadingScreensCheckBox = new System.Windows.Forms.CheckBox();
            this.GameDirectoryPathLabel = new System.Windows.Forms.Label();
            this.GameDirectoryPathTextBox = new System.Windows.Forms.TextBox();
            this.LauncherPathTextBox = new System.Windows.Forms.TextBox();
            this.UseAllCoresCheckbox = new System.Windows.Forms.CheckBox();
            this.DisableTextureStreamingCheckbox = new System.Windows.Forms.CheckBox();
            this.GameTabPage.SuspendLayout();
            this.GameTabPanel.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // LaunchButton
            // 
            this.LaunchButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LaunchButton.Location = new System.Drawing.Point(10, 456);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(938, 70);
            this.LaunchButton.TabIndex = 0;
            this.LaunchButton.Text = "Launch!";
            this.LaunchButton.UseVisualStyleBackColor = true;
            this.LaunchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // GameTabPage
            // 
            this.GameTabPage.Controls.Add(this.GameTabPanel);
            this.GameTabPage.Location = new System.Drawing.Point(10, 48);
            this.GameTabPage.Name = "GameTabPage";
            this.GameTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.GameTabPage.Size = new System.Drawing.Size(918, 388);
            this.GameTabPage.TabIndex = 0;
            this.GameTabPage.Text = "Game";
            this.GameTabPage.UseVisualStyleBackColor = true;
            // 
            // GameTabPanel
            // 
            this.GameTabPanel.BackColor = System.Drawing.Color.Transparent;
            this.GameTabPanel.Controls.Add(this.GameDirectoryPathTextBox);
            this.GameTabPanel.Controls.Add(this.GameDirectoryPathLabel);
            this.GameTabPanel.Controls.Add(this.DisableLoadingScreensCheckBox);
            this.GameTabPanel.Controls.Add(this.LauncherPathTextBox);
            this.GameTabPanel.Controls.Add(this.UseAllCoresCheckbox);
            this.GameTabPanel.Controls.Add(this.LauncherPathLabel);
            this.GameTabPanel.Controls.Add(this.DisableTextureStreamingCheckbox);
            this.GameTabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameTabPanel.Location = new System.Drawing.Point(3, 3);
            this.GameTabPanel.Name = "GameTabPanel";
            this.GameTabPanel.Size = new System.Drawing.Size(912, 382);
            this.GameTabPanel.TabIndex = 7;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.GameTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(10, 10);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(938, 446);
            this.MainTabControl.TabIndex = 7;
            // 
            // LauncherPathLabel
            // 
            this.LauncherPathLabel.AutoSize = true;
            this.LauncherPathLabel.Location = new System.Drawing.Point(3, 145);
            this.LauncherPathLabel.Name = "LauncherPathLabel";
            this.LauncherPathLabel.Size = new System.Drawing.Size(205, 32);
            this.LauncherPathLabel.TabIndex = 18;
            this.LauncherPathLabel.Text = "Launcher path:";
            this.LauncherPathLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // DisableLoadingScreensCheckBox
            // 
            this.DisableLoadingScreensCheckBox.AutoSize = true;
            this.DisableLoadingScreensCheckBox.Checked = global::BNSBoost.Properties.Settings.Default.NoLoadingScreens;
            this.DisableLoadingScreensCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::BNSBoost.Properties.Settings.Default, "NoLoadingScreens", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DisableLoadingScreensCheckBox.Location = new System.Drawing.Point(9, 87);
            this.DisableLoadingScreensCheckBox.Name = "DisableLoadingScreensCheckBox";
            this.DisableLoadingScreensCheckBox.Size = new System.Drawing.Size(356, 36);
            this.DisableLoadingScreensCheckBox.TabIndex = 19;
            this.DisableLoadingScreensCheckBox.Text = "Disable loading screens";
            this.DisableLoadingScreensCheckBox.UseVisualStyleBackColor = true;
            // 
            // GameDirectoryPathLabel
            // 
            this.GameDirectoryPathLabel.AutoSize = true;
            this.GameDirectoryPathLabel.Location = new System.Drawing.Point(1, 243);
            this.GameDirectoryPathLabel.Name = "GameDirectoryPathLabel";
            this.GameDirectoryPathLabel.Size = new System.Drawing.Size(279, 32);
            this.GameDirectoryPathLabel.TabIndex = 20;
            this.GameDirectoryPathLabel.Text = "Game directory path:";
            // 
            // GameDirectoryPathTextBox
            // 
            this.GameDirectoryPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GameDirectoryPathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::BNSBoost.Properties.Settings.Default, "GameDirectoryPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.GameDirectoryPathTextBox.Location = new System.Drawing.Point(7, 278);
            this.GameDirectoryPathTextBox.Name = "GameDirectoryPathTextBox";
            this.GameDirectoryPathTextBox.Size = new System.Drawing.Size(883, 38);
            this.GameDirectoryPathTextBox.TabIndex = 21;
            this.GameDirectoryPathTextBox.Text = global::BNSBoost.Properties.Settings.Default.GameDirectoryPath;
            // 
            // LauncherPathTextBox
            // 
            this.LauncherPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LauncherPathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::BNSBoost.Properties.Settings.Default, "NCLauncherRPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LauncherPathTextBox.Location = new System.Drawing.Point(9, 180);
            this.LauncherPathTextBox.Name = "LauncherPathTextBox";
            this.LauncherPathTextBox.Size = new System.Drawing.Size(881, 38);
            this.LauncherPathTextBox.TabIndex = 15;
            this.LauncherPathTextBox.Text = global::BNSBoost.Properties.Settings.Default.NCLauncherRPath;
            // 
            // UseAllCoresCheckbox
            // 
            this.UseAllCoresCheckbox.AutoSize = true;
            this.UseAllCoresCheckbox.Checked = global::BNSBoost.Properties.Settings.Default.UseAllCores;
            this.UseAllCoresCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseAllCoresCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::BNSBoost.Properties.Settings.Default, "UseAllCores", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.UseAllCoresCheckbox.Location = new System.Drawing.Point(9, 3);
            this.UseAllCoresCheckbox.Name = "UseAllCoresCheckbox";
            this.UseAllCoresCheckbox.Size = new System.Drawing.Size(216, 36);
            this.UseAllCoresCheckbox.TabIndex = 2;
            this.UseAllCoresCheckbox.Text = "Use all cores";
            this.UseAllCoresCheckbox.UseVisualStyleBackColor = true;
            // 
            // DisableTextureStreamingCheckbox
            // 
            this.DisableTextureStreamingCheckbox.AutoSize = true;
            this.DisableTextureStreamingCheckbox.Checked = global::BNSBoost.Properties.Settings.Default.NoTextureStreaming;
            this.DisableTextureStreamingCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DisableTextureStreamingCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::BNSBoost.Properties.Settings.Default, "NoTextureStreaming", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DisableTextureStreamingCheckbox.Location = new System.Drawing.Point(9, 45);
            this.DisableTextureStreamingCheckbox.Name = "DisableTextureStreamingCheckbox";
            this.DisableTextureStreamingCheckbox.Size = new System.Drawing.Size(375, 36);
            this.DisableTextureStreamingCheckbox.TabIndex = 2;
            this.DisableTextureStreamingCheckbox.Text = "Disable texture streaming";
            this.DisableTextureStreamingCheckbox.UseVisualStyleBackColor = true;
            // 
            // BNSBoostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(958, 536);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.LaunchButton);
            this.Name = "BNSBoostForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "BNSBoost";
            this.Load += new System.EventHandler(this.Form_Load);
            this.GameTabPage.ResumeLayout(false);
            this.GameTabPanel.ResumeLayout(false);
            this.GameTabPanel.PerformLayout();
            this.MainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LaunchButton;
        private System.Windows.Forms.TabPage GameTabPage;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.Panel GameTabPanel;
        private System.Windows.Forms.CheckBox DisableTextureStreamingCheckbox;
        private System.Windows.Forms.CheckBox UseAllCoresCheckbox;
        private System.Windows.Forms.Label LauncherPathLabel;
        private System.Windows.Forms.TextBox LauncherPathTextBox;
        private System.Windows.Forms.TextBox GameDirectoryPathTextBox;
        private System.Windows.Forms.Label GameDirectoryPathLabel;
        private System.Windows.Forms.CheckBox DisableLoadingScreensCheckBox;
    }
}
