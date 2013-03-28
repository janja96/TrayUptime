namespace TrayUptime
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.NotifyUp = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsUp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.autorunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bwUp = new System.ComponentModel.BackgroundWorker();
            this.cmsUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotifyUp
            // 
            this.NotifyUp.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.NotifyUp.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyUp.Icon")));
            this.NotifyUp.Visible = true;
            this.NotifyUp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nofityUp_MouseClick);
            // 
            // cmsUp
            // 
            this.cmsUp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autorunToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.cmsUp.Name = "contextMenuStrip1";
            this.cmsUp.Size = new System.Drawing.Size(132, 52);
            // 
            // autorunToolStripMenuItem
            // 
            this.autorunToolStripMenuItem.Name = "autorunToolStripMenuItem";
            this.autorunToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.autorunToolStripMenuItem.Text = "Autorun";
            this.autorunToolStripMenuItem.Click += new System.EventHandler(this.autorunToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Image = global::TrayUptime.Properties.Resources.Windows_Close_Program_icon;
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(131, 24);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // bwUp
            // 
            this.bwUp.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwUp_DoWork);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(140, 0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.cmsUp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon NotifyUp;
        private System.Windows.Forms.ContextMenuStrip cmsUp;
        private System.ComponentModel.BackgroundWorker bwUp;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem autorunToolStripMenuItem;
    }
}

