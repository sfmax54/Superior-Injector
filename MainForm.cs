using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.IO;
using ManualMapInjection.Injection;

namespace Superior_Injector
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Config.LoadConfig();
            ProcessIcon.Image = Utils.ProcessIcon;
            if(Process.GetProcessesByName(Config.Process).Length > 0)
            {
                foreach (var proc in Process.GetProcesses())
                {
                    if (!string.IsNullOrEmpty(proc.MainWindowTitle))
                    {
                        ProcessBox.Items.Add(proc.ProcessName + " | " + proc.MainWindowTitle);
                    }
                }
                ProcessBox.SelectedIndex = ProcessBox.FindString(Config.Process);
            }

            if(Config.DLLPathes.Count > 0)
            {
                foreach (var item in Config.DLLPathes)
                {
                    try
                    {
                        DLL_List.Items.Add(item.Split('\\').Last() + " | " + Math.Round(new FileInfo(item).Length / 1024.0 / 1024.0, 2) + " MB");
                    } catch { }
                }
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {

            if (Config.SecureMode == true)
            {
                Utils.SetWindowText(Process.GetProcesses().FirstOrDefault(x => x.MainWindowTitle.Contains("Superior")).MainWindowHandle, Utils.GetRandomName());
            }
        }

        private void LogoLabel_MouseDown(object sender, MouseEventArgs e)
        {
            Utils.ReleaseCapture();
            Utils.SendMessage(Handle, Utils.WM_NCLBUTTONDOWN, Utils.HT_CAPTION, 0);
        }

        private void ExLogo_MouseDown(object sender, MouseEventArgs e)
        {
            Utils.ReleaseCapture();
            Utils.SendMessage(Handle, Utils.WM_NCLBUTTONDOWN, Utils.HT_CAPTION, 0);
        }

        private void InjectButton_Click(object sender, EventArgs e)
        {
            if (ProcessBox.SelectedIndex > -1 && DLL_List.CheckedItems.Count > 0)
            {
                UInjector injector = new UInjector(Process.GetProcessesByName(ProcessBox.SelectedItem.ToString().Split(new string[] { " | " }, StringSplitOptions.None)[0]).FirstOrDefault()) { AsyncInjection = true };
                switch (Config.AsyncInjection)
                {
                    case true: Task.Factory.StartNew(() => Injection(injector, DLL_List.CheckedItems.Cast<string>().ToList())); break;
                    case false: Injection(injector, DLL_List.CheckedItems.Cast<string>().ToList()); break;
                }
            }
        }

        private void Injection(UInjector injector, List<string> DLLList)
        {
            foreach (var item in DLLList)
            {
                if (item.Equals(DLLList.Last()))
                {
                    switch (Config.InjectionMethod)
                    {
                        case "ManualMap": injector.ManualMapInject(Config.DLLPathes.Find(x => x.Contains(item.Split(new string[] { " | " }, StringSplitOptions.None)[0]))); Utils.PlaySound(); break;
                        case "LoadLibrary": injector.LoadLibraryInject(Config.DLLPathes.Find(x => x.Contains(item.Split(new string[] { " | " }, StringSplitOptions.None)[0]))); Utils.PlaySound(); break;
                    }
                }
                else
                {
                    switch (Config.InjectionMethod)
                    {
                        case "ManualMap": injector.ManualMapInject(Config.DLLPathes.Find(x => x.Contains(item.Split(new string[] { " | " }, StringSplitOptions.None)[0]))); Utils.PlaySound(); break;
                        case "LoadLibrary": injector.LoadLibraryInject(Config.DLLPathes.Find(x => x.Contains(item.Split(new string[] { " | " }, StringSplitOptions.None)[0]))); Utils.PlaySound(); break;
                    }

                    if (Config.InjectionDelay > 0)
                    {
                        Thread.Sleep(Config.InjectionDelay * 1000);
                    }
                }
            }
        }

        private void ProcessBox_Click(object sender, EventArgs e)
        {
            ProcessBox.Items.Clear();
            foreach (var proc in Process.GetProcesses())
            {
                if (!string.IsNullOrEmpty(proc.MainWindowTitle))
                {
                    ProcessBox.Items.Add(proc.ProcessName + " | " + proc.MainWindowTitle);
                }
            }
        }

        private void ProcessBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                ProcessIcon.Image = Icon.ExtractAssociatedIcon(Process.GetProcessesByName(ProcessBox.Text.Split(new string[] { " | " }, StringSplitOptions.None)[0]).FirstOrDefault().MainModule.FileName).ToBitmap();
            } catch
            {
                ProcessIcon.Image = Utils.ProcessIcon;
            }
            Config.Process = ProcessBox.Text.Split(new string[] { " | " }, StringSplitOptions.None)[0];
            Config.SaveConfig();
        }

        private void DLL_AddButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "DLL файлы |*.dll"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!Utils.IsManagedAssembly(openFileDialog.FileName) && !Config.DLLPathes.Contains(openFileDialog.FileName))
                {
                    DLL_List.Items.Add(openFileDialog.FileName.Split('\\').Last() + " | " + Math.Round(new FileInfo(openFileDialog.FileName).Length / 1024.0 / 1024.0, 2) + " MB");
                    Config.DLLPathes.Add(openFileDialog.FileName);
                }
            }
            Config.SaveConfig();
        }

        private void DLL_RemoveButton_Click(object sender, EventArgs e)
        {
            for (int i = DLL_List.CheckedItems.Count - 1; i >= 0; i--)
            {
                Config.DLLPathes.Remove(Config.DLLPathes.FirstOrDefault(x => x.Contains(DLL_List.CheckedItems[i].ToString().Split(new string[] { " | " }, StringSplitOptions.None)[0])));
                DLL_List.Items.Remove(DLL_List.CheckedItems[i]);
            }
            Config.SaveConfig();
        }

        private void DLL_ClearButton_Click(object sender, EventArgs e)
        {
            DLL_List.Items.Clear();
            Config.DLLPathes.Clear();
            Config.SaveConfig();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            new Settings().ShowDialog();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/hake1");
        }

        private void DLL_List_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void DLL_List_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if (!Utils.IsManagedAssembly(file) && !Config.DLLPathes.Contains(file) && file.Contains(".dll"))
                {
                    DLL_List.Items.Add(file.Split('\\').Last() + " | " + Math.Round(new FileInfo(file).Length / 1024.0 / 1024.0, 2) + " MB");
                    Config.DLLPathes.Add(file);
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Config.SaveConfig();
        }
    }
}
