using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SkyrimBatchBuilder
{
    public partial class PerksListNameForm : Form
    {
        public PerksListNameForm()
        {
            InitializeComponent();
        }

        public bool IsntPerkNameExecuded(string name)
        {
            string[] nameExcutions = new string[] { "Skyrim", "Ordinator", "OrdinatorMultEnch" };
            foreach (string nameExcution in nameExcutions)
            {
                if (name.Equals(nameExcution))
                {
                    return false;
                }
            }
            return true;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(perksListNameBox.Text))
            {
                if (IsntPerkNameExecuded(perksListNameBox.Text.ToString()))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    label2.Text = "Name used by author made list!";
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
