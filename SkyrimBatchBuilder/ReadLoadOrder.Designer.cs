
using System;
using System.Configuration;
using System.IO;

namespace SkyrimBatchBuilder
{
    partial class ReadLoadOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadLoadOrder));
            this.console = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildAllListsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildJustLoadOrderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildPerksListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.SystemColors.Desktop;
            this.console.Dock = System.Windows.Forms.DockStyle.Fill;
            this.console.ForeColor = System.Drawing.SystemColors.Window;
            this.console.Location = new System.Drawing.Point(0, 24);
            this.console.MaxLength = 1000000000;
            this.console.Multiline = true;
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.console.Size = new System.Drawing.Size(800, 426);
            this.console.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.buildMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "File";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // buildMenuItem
            // 
            this.buildMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildAllListsMenuItem,
            this.buildJustLoadOrderMenuItem,
            this.buildPerksListMenuItem});
            this.buildMenuItem.Name = "buildMenuItem";
            this.buildMenuItem.Size = new System.Drawing.Size(46, 20);
            this.buildMenuItem.Text = "Build";
            // 
            // buildAllListsMenuItem
            // 
            this.buildAllListsMenuItem.Name = "buildAllListsMenuItem";
            this.buildAllListsMenuItem.Size = new System.Drawing.Size(160, 22);
            this.buildAllListsMenuItem.Text = "All Lists";
            this.buildAllListsMenuItem.Click += new System.EventHandler(this.buildAllListsMenuItem_Click);
            // 
            // buildJustLoadOrderMenuItem
            // 
            this.buildJustLoadOrderMenuItem.Name = "buildJustLoadOrderMenuItem";
            this.buildJustLoadOrderMenuItem.Size = new System.Drawing.Size(160, 22);
            this.buildJustLoadOrderMenuItem.Text = "New Load Order";
            this.buildJustLoadOrderMenuItem.Click += new System.EventHandler(this.justLoadOrderMenuItem_Click);
            // 
            // buildPerksListMenuItem
            // 
            this.buildPerksListMenuItem.Name = "buildPerksListMenuItem";
            this.buildPerksListMenuItem.Size = new System.Drawing.Size(160, 22);
            this.buildPerksListMenuItem.Text = "Perks List";
            this.buildPerksListMenuItem.Click += new System.EventHandler(this.buildPerksListMenuItem_Click);
            // 
            // ReadLoadOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.console);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "ReadLoadOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Skyrim Batch Builder: References Reader";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox console;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildAllListsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildJustLoadOrderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildPerksListMenuItem;
    }
}