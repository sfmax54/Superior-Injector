using System;
using MetroFramework.Forms;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;

namespace Superior_Injector
{
    public partial class Settings : MetroForm
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            DelayBar.Value = Config.InjectionDelay;
            MethodBox.SelectedIndex = MethodBox.FindString(Config.InjectionMethod);
            AsyncInjectionCheck.Checked = Config.AsyncInjection;
            SecureModeCheck.Checked = Config.SecureMode;
        }

        private void LogoLabel_MouseDown(object sender, MouseEventArgs e)
        {
            Utils.ReleaseCapture();
            Utils.SendMessage(Handle, Utils.WM_NCLBUTTONDOWN, Utils.HT_CAPTION, 0);
        }

        private void DelayBar_ValueChanged(object sender, EventArgs e)
        {
            DelayLabel.Text = DelayBar.Value.ToString();
            Config.InjectionDelay = DelayBar.Value;
            DelaySubLabel.Text = DelayBar.Value >= 10 ? "  сек." : "сек.";
        }

        private void MethodBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Config.InjectionMethod = MethodBox.SelectedItem.ToString();
        }

        private void AsyncInjectionCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.AsyncInjection = AsyncInjectionCheck.Checked;
        }

        private void SaveSettings_Click(object sender, EventArgs e)
        {
            Config.SaveConfig();
            this.Close();
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Config.SaveConfig();
        }

        private void SecureModeCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.SecureMode = SecureModeCheck.Checked;
        }
    }
}
