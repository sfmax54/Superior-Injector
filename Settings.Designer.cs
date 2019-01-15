namespace Superior_Injector
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.LogoLabel = new MetroFramework.Controls.MetroLabel();
            this.DelayBar = new MetroFramework.Controls.MetroTrackBar();
            this.DelayExLabel = new MetroFramework.Controls.MetroLabel();
            this.DelaySubLabel = new MetroFramework.Controls.MetroLabel();
            this.DelayLabel = new MetroFramework.Controls.MetroLabel();
            this.MethodBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.AsyncInjectionCheck = new MetroFramework.Controls.MetroCheckBox();
            this.SaveSettings = new MetroFramework.Controls.MetroButton();
            this.SecureModeCheck = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Location = new System.Drawing.Point(1, 6);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(54, 19);
            this.LogoLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.LogoLabel.TabIndex = 15;
            this.LogoLabel.Text = "Settings";
            this.LogoLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LogoLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LogoLabel_MouseDown);
            // 
            // DelayBar
            // 
            this.DelayBar.BackColor = System.Drawing.Color.Transparent;
            this.DelayBar.Location = new System.Drawing.Point(80, 33);
            this.DelayBar.Maximum = 30;
            this.DelayBar.Name = "DelayBar";
            this.DelayBar.Size = new System.Drawing.Size(174, 23);
            this.DelayBar.Style = MetroFramework.MetroColorStyle.Orange;
            this.DelayBar.TabIndex = 16;
            this.DelayBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DelayBar.Value = 0;
            this.DelayBar.ValueChanged += new System.EventHandler(this.DelayBar_ValueChanged);
            // 
            // DelayExLabel
            // 
            this.DelayExLabel.AutoSize = true;
            this.DelayExLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.DelayExLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.DelayExLabel.Location = new System.Drawing.Point(10, 36);
            this.DelayExLabel.Name = "DelayExLabel";
            this.DelayExLabel.Size = new System.Drawing.Size(67, 15);
            this.DelayExLabel.Style = MetroFramework.MetroColorStyle.Orange;
            this.DelayExLabel.TabIndex = 17;
            this.DelayExLabel.Text = "Задержка:";
            this.DelayExLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // DelaySubLabel
            // 
            this.DelaySubLabel.AutoSize = true;
            this.DelaySubLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.DelaySubLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.DelaySubLabel.Location = new System.Drawing.Point(271, 36);
            this.DelaySubLabel.Name = "DelaySubLabel";
            this.DelaySubLabel.Size = new System.Drawing.Size(30, 15);
            this.DelaySubLabel.Style = MetroFramework.MetroColorStyle.Orange;
            this.DelaySubLabel.TabIndex = 18;
            this.DelaySubLabel.Text = "сек.";
            this.DelaySubLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // DelayLabel
            // 
            this.DelayLabel.AutoSize = true;
            this.DelayLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.DelayLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.DelayLabel.ForeColor = System.Drawing.Color.Lime;
            this.DelayLabel.Location = new System.Drawing.Point(258, 36);
            this.DelayLabel.Name = "DelayLabel";
            this.DelayLabel.Size = new System.Drawing.Size(14, 15);
            this.DelayLabel.Style = MetroFramework.MetroColorStyle.Orange;
            this.DelayLabel.TabIndex = 19;
            this.DelayLabel.Text = "0";
            this.DelayLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DelayLabel.UseCustomForeColor = true;
            // 
            // MethodBox
            // 
            this.MethodBox.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.MethodBox.FormattingEnabled = true;
            this.MethodBox.ItemHeight = 19;
            this.MethodBox.Items.AddRange(new object[] {
            "LoadLibrary",
            "ManualMap"});
            this.MethodBox.Location = new System.Drawing.Point(113, 62);
            this.MethodBox.Name = "MethodBox";
            this.MethodBox.Size = new System.Drawing.Size(218, 25);
            this.MethodBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.MethodBox.TabIndex = 20;
            this.MethodBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MethodBox.UseSelectable = true;
            this.MethodBox.SelectedIndexChanged += new System.EventHandler(this.MethodBox_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(10, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 15);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel1.TabIndex = 21;
            this.metroLabel1.Text = "Метод инжекта:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // AsyncInjectionCheck
            // 
            this.AsyncInjectionCheck.AutoSize = true;
            this.AsyncInjectionCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AsyncInjectionCheck.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.AsyncInjectionCheck.Location = new System.Drawing.Point(10, 96);
            this.AsyncInjectionCheck.Name = "AsyncInjectionCheck";
            this.AsyncInjectionCheck.Size = new System.Drawing.Size(155, 15);
            this.AsyncInjectionCheck.Style = MetroFramework.MetroColorStyle.Orange;
            this.AsyncInjectionCheck.TabIndex = 22;
            this.AsyncInjectionCheck.Text = "Асинхронный инжект:";
            this.AsyncInjectionCheck.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AsyncInjectionCheck.UseSelectable = true;
            this.AsyncInjectionCheck.CheckedChanged += new System.EventHandler(this.AsyncInjectionCheck_CheckedChanged);
            // 
            // SaveSettings
            // 
            this.SaveSettings.Location = new System.Drawing.Point(70, 154);
            this.SaveSettings.Name = "SaveSettings";
            this.SaveSettings.Size = new System.Drawing.Size(205, 23);
            this.SaveSettings.Style = MetroFramework.MetroColorStyle.Orange;
            this.SaveSettings.TabIndex = 23;
            this.SaveSettings.Text = "Сохранить настройки и изменения";
            this.SaveSettings.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SaveSettings.UseSelectable = true;
            this.SaveSettings.Click += new System.EventHandler(this.SaveSettings_Click);
            // 
            // SecureModeCheck
            // 
            this.SecureModeCheck.AutoSize = true;
            this.SecureModeCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SecureModeCheck.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.SecureModeCheck.Location = new System.Drawing.Point(10, 125);
            this.SecureModeCheck.Name = "SecureModeCheck";
            this.SecureModeCheck.Size = new System.Drawing.Size(97, 15);
            this.SecureModeCheck.Style = MetroFramework.MetroColorStyle.Orange;
            this.SecureModeCheck.TabIndex = 24;
            this.SecureModeCheck.Text = "SecureMode:";
            this.SecureModeCheck.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SecureModeCheck.UseSelectable = true;
            this.SecureModeCheck.CheckedChanged += new System.EventHandler(this.SecureModeCheck_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 193);
            this.Controls.Add(this.SecureModeCheck);
            this.Controls.Add(this.SaveSettings);
            this.Controls.Add(this.AsyncInjectionCheck);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.MethodBox);
            this.Controls.Add(this.DelayLabel);
            this.Controls.Add(this.DelaySubLabel);
            this.Controls.Add(this.DelayExLabel);
            this.Controls.Add(this.DelayBar);
            this.Controls.Add(this.LogoLabel);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Settings";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel LogoLabel;
        private MetroFramework.Controls.MetroTrackBar DelayBar;
        private MetroFramework.Controls.MetroLabel DelayExLabel;
        private MetroFramework.Controls.MetroLabel DelaySubLabel;
        private MetroFramework.Controls.MetroLabel DelayLabel;
        private MetroFramework.Controls.MetroComboBox MethodBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroCheckBox AsyncInjectionCheck;
        private MetroFramework.Controls.MetroButton SaveSettings;
        private MetroFramework.Controls.MetroCheckBox SecureModeCheck;
    }
}