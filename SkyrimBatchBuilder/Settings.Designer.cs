
namespace SkyrimBatchBuilder
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
            this.SSEEditPath = new System.Windows.Forms.TextBox();
            this.SSEEditFileExplororer = new System.Windows.Forms.Button();
            this.SSEEditTextBox = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SSEEditPath
            // 
            this.SSEEditPath.Location = new System.Drawing.Point(12, 27);
            this.SSEEditPath.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.SSEEditPath.Name = "SSEEditPath";
            this.SSEEditPath.Size = new System.Drawing.Size(192, 23);
            this.SSEEditPath.TabIndex = 0;
            this.SSEEditPath.Text = "Missing SSEEdit Path";
            // 
            // SSEEditFileExplororer
            // 
            this.SSEEditFileExplororer.Location = new System.Drawing.Point(204, 27);
            this.SSEEditFileExplororer.Margin = new System.Windows.Forms.Padding(0);
            this.SSEEditFileExplororer.Name = "SSEEditFileExplororer";
            this.SSEEditFileExplororer.Size = new System.Drawing.Size(25, 23);
            this.SSEEditFileExplororer.TabIndex = 1;
            this.SSEEditFileExplororer.Text = "...";
            this.SSEEditFileExplororer.UseVisualStyleBackColor = true;
            this.SSEEditFileExplororer.Click += new System.EventHandler(this.SSEEditFileExplororer_Click);
            // 
            // SSEEditTextBox
            // 
            this.SSEEditTextBox.AutoSize = true;
            this.SSEEditTextBox.Location = new System.Drawing.Point(12, 9);
            this.SSEEditTextBox.Name = "SSEEditTextBox";
            this.SSEEditTextBox.Size = new System.Drawing.Size(132, 15);
            this.SSEEditTextBox.TabIndex = 2;
            this.SSEEditTextBox.Text = "SSEEdit Executable Path";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(200, 73);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(119, 73);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 108);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.SSEEditTextBox);
            this.Controls.Add(this.SSEEditFileExplororer);
            this.Controls.Add(this.SSEEditPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(303, 147);
            this.MinimumSize = new System.Drawing.Size(303, 147);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SSEEditPath;
        private System.Windows.Forms.Button SSEEditFileExplororer;
        private System.Windows.Forms.Label SSEEditTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
    }
}