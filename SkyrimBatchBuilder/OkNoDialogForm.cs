using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SkyrimBatchBuilder
{
    public partial class OkNoDialogForm : Form
    {
        public OkNoDialogForm(string text)
        {
            InitializeComponent();
            textBox1.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
