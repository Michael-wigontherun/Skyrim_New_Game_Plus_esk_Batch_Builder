using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SkyrimBatchBuilder
{
    public partial class Settings : Form
    {
        public Configuration config;
        public Settings()
        {
            InitializeComponent();
            config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            if (!String.IsNullOrEmpty(ConfigurationManager.AppSettings["sseedit"]))
            {
                SSEEditPath.Text = ConfigurationManager.AppSettings["sseedit"];
            }
        }

        private void SSEEditFileExplororer_Click(object sender, EventArgs e)
        {
            

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = "SSE Edit executable (SSEEdit.exe)|SSEEdit.exe";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SSEEditPath.Text = openFileDialog.FileName.Replace("\\SSEEdit.exe", "");
                }
                
                
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            config.AppSettings.Settings.Remove("sseedit");
            config.AppSettings.Settings.Add("sseedit", SSEEditPath.Text.ToString());
            config.Save(ConfigurationSaveMode.Minimal);
            ConfigurationManager.RefreshSection("appSettings");
            this.DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
