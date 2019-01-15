namespace Superior_Injector
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная кон"структора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// О"свободить в"се и"спользуемые ре"сур"сы.
        /// </summary>
        /// <param name="disposing">и"стинно, е"сли управляемый ре"сур"с должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматиче"ски "созданный кон"структором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки кон"структора — не изменяйте 
        /// "содержимое этого метода "с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.InjectButton = new MetroFramework.Controls.MetroButton();
            this.SettingsButton = new MetroFramework.Controls.MetroButton();
            this.ManagerBox = new System.Windows.Forms.GroupBox();
            this.DLL_ClearButton = new MetroFramework.Controls.MetroButton();
            this.DLL_List = new System.Windows.Forms.CheckedListBox();
            this.DLL_AddButton = new MetroFramework.Controls.MetroButton();
            this.DLL_RemoveButton = new MetroFramework.Controls.MetroButton();
            this.AboutButton = new MetroFramework.Controls.MetroButton();
            this.ExLogo = new System.Windows.Forms.Label();
            this.ProcessBox = new MetroFramework.Controls.MetroComboBox();
            this.LogoLabel = new MetroFramework.Controls.MetroLabel();
            this.ProcessIcon = new System.Windows.Forms.PictureBox();
            this.ManagerBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // InjectButton
            // 
            this.InjectButton.Location = new System.Drawing.Point(301, 221);
            this.InjectButton.Name = "InjectButton";
            this.InjectButton.Size = new System.Drawing.Size(107, 23);
            this.InjectButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.InjectButton.TabIndex = 20;
            this.InjectButton.Text = "Инжект";
            this.InjectButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.InjectButton.UseSelectable = true;
            this.InjectButton.Click += new System.EventHandler(this.InjectButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(157, 221);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(107, 23);
            this.SettingsButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.SettingsButton.TabIndex = 19;
            this.SettingsButton.Text = "Настройки";
            this.SettingsButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SettingsButton.UseSelectable = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ManagerBox
            // 
            this.ManagerBox.Controls.Add(this.DLL_ClearButton);
            this.ManagerBox.Controls.Add(this.DLL_List);
            this.ManagerBox.Controls.Add(this.DLL_AddButton);
            this.ManagerBox.Controls.Add(this.DLL_RemoveButton);
            this.ManagerBox.ForeColor = System.Drawing.Color.Lime;
            this.ManagerBox.Location = new System.Drawing.Point(13, 79);
            this.ManagerBox.Name = "ManagerBox";
            this.ManagerBox.Size = new System.Drawing.Size(395, 134);
            this.ManagerBox.TabIndex = 18;
            this.ManagerBox.TabStop = false;
            this.ManagerBox.Text = "DLL Manager";
            // 
            // DLL_ClearButton
            // 
            this.DLL_ClearButton.Location = new System.Drawing.Point(11, 97);
            this.DLL_ClearButton.Name = "DLL_ClearButton";
            this.DLL_ClearButton.Size = new System.Drawing.Size(96, 25);
            this.DLL_ClearButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.DLL_ClearButton.TabIndex = 14;
            this.DLL_ClearButton.Text = "Очистить";
            this.DLL_ClearButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DLL_ClearButton.UseSelectable = true;
            this.DLL_ClearButton.Click += new System.EventHandler(this.DLL_ClearButton_Click);
            // 
            // DLL_List
            // 
            this.DLL_List.AllowDrop = true;
            this.DLL_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.DLL_List.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DLL_List.CheckOnClick = true;
            this.DLL_List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DLL_List.FormattingEnabled = true;
            this.DLL_List.Location = new System.Drawing.Point(116, 16);
            this.DLL_List.Name = "DLL_List";
            this.DLL_List.Size = new System.Drawing.Size(269, 107);
            this.DLL_List.TabIndex = 5;
            this.DLL_List.DragDrop += new System.Windows.Forms.DragEventHandler(this.DLL_List_DragDrop);
            this.DLL_List.DragEnter += new System.Windows.Forms.DragEventHandler(this.DLL_List_DragEnter);
            // 
            // DLL_AddButton
            // 
            this.DLL_AddButton.Location = new System.Drawing.Point(10, 17);
            this.DLL_AddButton.Name = "DLL_AddButton";
            this.DLL_AddButton.Size = new System.Drawing.Size(97, 25);
            this.DLL_AddButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.DLL_AddButton.TabIndex = 13;
            this.DLL_AddButton.Text = "Добавить";
            this.DLL_AddButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DLL_AddButton.UseSelectable = true;
            this.DLL_AddButton.Click += new System.EventHandler(this.DLL_AddButton_Click);
            // 
            // DLL_RemoveButton
            // 
            this.DLL_RemoveButton.Location = new System.Drawing.Point(10, 57);
            this.DLL_RemoveButton.Name = "DLL_RemoveButton";
            this.DLL_RemoveButton.Size = new System.Drawing.Size(97, 25);
            this.DLL_RemoveButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.DLL_RemoveButton.TabIndex = 12;
            this.DLL_RemoveButton.Text = "Удалить";
            this.DLL_RemoveButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DLL_RemoveButton.UseSelectable = true;
            this.DLL_RemoveButton.Click += new System.EventHandler(this.DLL_RemoveButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(13, 221);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(107, 23);
            this.AboutButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.AboutButton.TabIndex = 17;
            this.AboutButton.Text = "Разработчик";
            this.AboutButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AboutButton.UseSelectable = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // ExLogo
            // 
            this.ExLogo.AutoSize = true;
            this.ExLogo.ForeColor = System.Drawing.Color.Lime;
            this.ExLogo.Location = new System.Drawing.Point(105, 10);
            this.ExLogo.Name = "ExLogo";
            this.ExLogo.Size = new System.Drawing.Size(95, 13);
            this.ExLogo.TabIndex = 16;
            this.ExLogo.Text = "[ Coded by Zidjey ]";
            this.ExLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExLogo_MouseDown);
            // 
            // ProcessBox
            // 
            this.ProcessBox.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.ProcessBox.FormattingEnabled = true;
            this.ProcessBox.ItemHeight = 19;
            this.ProcessBox.Location = new System.Drawing.Point(71, 40);
            this.ProcessBox.Name = "ProcessBox";
            this.ProcessBox.PromptText = "Выберите процесс";
            this.ProcessBox.Size = new System.Drawing.Size(337, 25);
            this.ProcessBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.ProcessBox.TabIndex = 15;
            this.ProcessBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ProcessBox.UseSelectable = true;
            this.ProcessBox.SelectedValueChanged += new System.EventHandler(this.ProcessBox_SelectedValueChanged);
            this.ProcessBox.Click += new System.EventHandler(this.ProcessBox_Click);
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Location = new System.Drawing.Point(1, 6);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(106, 19);
            this.LogoLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.LogoLabel.TabIndex = 14;
            this.LogoLabel.Text = "Superior Injector";
            this.LogoLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LogoLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LogoLabel_MouseDown);
            // 
            // ProcessIcon
            // 
            this.ProcessIcon.Location = new System.Drawing.Point(24, 36);
            this.ProcessIcon.Name = "ProcessIcon";
            this.ProcessIcon.Size = new System.Drawing.Size(32, 32);
            this.ProcessIcon.TabIndex = 21;
            this.ProcessIcon.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 252);
            this.Controls.Add(this.ProcessIcon);
            this.Controls.Add(this.InjectButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.ManagerBox);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.ExLogo);
            this.Controls.Add(this.ProcessBox);
            this.Controls.Add(this.LogoLabel);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Superior Injector";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ManagerBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProcessIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton InjectButton;
        private MetroFramework.Controls.MetroButton SettingsButton;
        private System.Windows.Forms.GroupBox ManagerBox;
        private MetroFramework.Controls.MetroButton DLL_ClearButton;
        private System.Windows.Forms.CheckedListBox DLL_List;
        private MetroFramework.Controls.MetroButton DLL_AddButton;
        private MetroFramework.Controls.MetroButton DLL_RemoveButton;
        private MetroFramework.Controls.MetroButton AboutButton;
        private System.Windows.Forms.Label ExLogo;
        private MetroFramework.Controls.MetroComboBox ProcessBox;
        private MetroFramework.Controls.MetroLabel LogoLabel;
        private System.Windows.Forms.PictureBox ProcessIcon;
    }
}

