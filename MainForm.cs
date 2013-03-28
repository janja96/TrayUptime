using System;
using System.ComponentModel;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace TrayUptime
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            NotifyUp.ShowBalloonTip(1000, "System Uptime", "Run", ToolTipIcon.Info);

            bwUp.RunWorkerAsync();

            if (Startup())
            {
                autorunToolStripMenuItem.Checked = true;
            }
            else
            {
                autorunToolStripMenuItem.Checked = false;
            }
        }

        private void nofityUp_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                NotifyUp.ContextMenuStrip = cmsUp;
                MethodInfo mi = typeof (NotifyIcon).GetMethod("ShowContextMenu",
                BindingFlags.Instance | BindingFlags.NonPublic);
                mi.Invoke(NotifyUp, null);
                NotifyUp.ContextMenuStrip = cmsUp;
            }
        }

        private void AddAutoRun(bool del)
        {
            RegistryKey App = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (!Startup())
                App.SetValue("Uptime", Application.ExecutablePath);
            if (del)
            {
                App.DeleteValue("Uptime", false);
            }
        }

        private static bool Startup()
        {
            RegistryKey App = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (App.GetValue("Uptime") == null)
            {
                return false;
            }
            return true;
        }

        private void bwUp_DoWork(object sender, DoWorkEventArgs e)
        {
            for (;;)
            {
                Thread.Sleep(1000);
                string uptime = "";
                uptime += "Uptime: " + (Environment.TickCount/86400000) + " days, ";
                uptime += (Environment.TickCount/3600000%24) + " hours, ";
                uptime += (Environment.TickCount/120000%60) + " minutes, ";
                uptime += (Environment.TickCount/1000%60) + " seconds.";
                NotifyUp.Text = uptime;
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void autorunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (autorunToolStripMenuItem.Checked)
            {
                autorunToolStripMenuItem.Checked = false;
                AddAutoRun(true);
            }
            else
            {
                autorunToolStripMenuItem.Checked = true;
                AddAutoRun(false);
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Hide();
        }
    }
}