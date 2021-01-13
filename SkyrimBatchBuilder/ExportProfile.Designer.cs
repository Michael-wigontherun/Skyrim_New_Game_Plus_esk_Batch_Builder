
using SkyrimBatchBuilder.SkyrimReferences;

namespace SkyrimBatchBuilder
{
    partial class ExportProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportProfile));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.weaponsTabPage = new System.Windows.Forms.TabPage();
            this.weaponsDataGrid = new System.Windows.Forms.DataGridView();
            this.armorTabPage = new System.Windows.Forms.TabPage();
            this.armorDataGridView = new System.Windows.Forms.DataGridView();
            this.ingredientsTabPage = new System.Windows.Forms.TabPage();
            this.ingredientsDataGridView = new System.Windows.Forms.DataGridView();
            this.foodAndPotionsTabPage = new System.Windows.Forms.TabPage();
            this.foodAndPotionsDataGridView = new System.Windows.Forms.DataGridView();
            this.booksTabPage = new System.Windows.Forms.TabPage();
            this.booksDataGridView = new System.Windows.Forms.DataGridView();
            this.miscTabPage = new System.Windows.Forms.TabPage();
            this.miscDataGridView = new System.Windows.Forms.DataGridView();
            this.console = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadOrderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existingStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildBatchStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildOnlyItemsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.weaponsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weaponsDataGrid)).BeginInit();
            this.armorTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.armorDataGridView)).BeginInit();
            this.ingredientsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsDataGridView)).BeginInit();
            this.foodAndPotionsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodAndPotionsDataGridView)).BeginInit();
            this.booksTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).BeginInit();
            this.miscTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.miscDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.weaponsTabPage);
            this.tabControl1.Controls.Add(this.armorTabPage);
            this.tabControl1.Controls.Add(this.ingredientsTabPage);
            this.tabControl1.Controls.Add(this.foodAndPotionsTabPage);
            this.tabControl1.Controls.Add(this.booksTabPage);
            this.tabControl1.Controls.Add(this.miscTabPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 297);
            this.tabControl1.TabIndex = 0;
            // 
            // weaponsTabPage
            // 
            this.weaponsTabPage.Controls.Add(this.weaponsDataGrid);
            this.weaponsTabPage.Location = new System.Drawing.Point(4, 24);
            this.weaponsTabPage.Name = "weaponsTabPage";
            this.weaponsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.weaponsTabPage.Size = new System.Drawing.Size(792, 269);
            this.weaponsTabPage.TabIndex = 0;
            this.weaponsTabPage.Text = "Weapons";
            this.weaponsTabPage.UseVisualStyleBackColor = true;
            // 
            // weaponsDataGrid
            // 
            this.weaponsDataGrid.AllowUserToAddRows = false;
            this.weaponsDataGrid.AllowUserToDeleteRows = false;
            this.weaponsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weaponsDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weaponsDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.weaponsDataGrid.Location = new System.Drawing.Point(3, 3);
            this.weaponsDataGrid.Name = "weaponsDataGrid";
            this.weaponsDataGrid.RowTemplate.Height = 25;
            this.weaponsDataGrid.Size = new System.Drawing.Size(786, 263);
            this.weaponsDataGrid.TabIndex = 0;
            // 
            // armorTabPage
            // 
            this.armorTabPage.Controls.Add(this.armorDataGridView);
            this.armorTabPage.Location = new System.Drawing.Point(4, 24);
            this.armorTabPage.Name = "armorTabPage";
            this.armorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.armorTabPage.Size = new System.Drawing.Size(792, 269);
            this.armorTabPage.TabIndex = 1;
            this.armorTabPage.Text = "Armor";
            this.armorTabPage.UseVisualStyleBackColor = true;
            // 
            // armorDataGridView
            // 
            this.armorDataGridView.AllowUserToAddRows = false;
            this.armorDataGridView.AllowUserToDeleteRows = false;
            this.armorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.armorDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.armorDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.armorDataGridView.Location = new System.Drawing.Point(3, 3);
            this.armorDataGridView.Name = "armorDataGridView";
            this.armorDataGridView.RowTemplate.Height = 25;
            this.armorDataGridView.Size = new System.Drawing.Size(786, 263);
            this.armorDataGridView.TabIndex = 1;
            // 
            // ingredientsTabPage
            // 
            this.ingredientsTabPage.Controls.Add(this.ingredientsDataGridView);
            this.ingredientsTabPage.Location = new System.Drawing.Point(4, 24);
            this.ingredientsTabPage.Name = "ingredientsTabPage";
            this.ingredientsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ingredientsTabPage.Size = new System.Drawing.Size(792, 269);
            this.ingredientsTabPage.TabIndex = 3;
            this.ingredientsTabPage.Text = "Ingredients";
            this.ingredientsTabPage.UseVisualStyleBackColor = true;
            // 
            // ingredientsDataGridView
            // 
            this.ingredientsDataGridView.AllowUserToAddRows = false;
            this.ingredientsDataGridView.AllowUserToDeleteRows = false;
            this.ingredientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ingredientsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ingredientsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.ingredientsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.ingredientsDataGridView.Name = "ingredientsDataGridView";
            this.ingredientsDataGridView.RowTemplate.Height = 25;
            this.ingredientsDataGridView.Size = new System.Drawing.Size(786, 263);
            this.ingredientsDataGridView.TabIndex = 1;
            // 
            // foodAndPotionsTabPage
            // 
            this.foodAndPotionsTabPage.Controls.Add(this.foodAndPotionsDataGridView);
            this.foodAndPotionsTabPage.Location = new System.Drawing.Point(4, 24);
            this.foodAndPotionsTabPage.Name = "foodAndPotionsTabPage";
            this.foodAndPotionsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.foodAndPotionsTabPage.Size = new System.Drawing.Size(792, 269);
            this.foodAndPotionsTabPage.TabIndex = 4;
            this.foodAndPotionsTabPage.Text = "Food and Potions";
            this.foodAndPotionsTabPage.UseVisualStyleBackColor = true;
            // 
            // foodAndPotionsDataGridView
            // 
            this.foodAndPotionsDataGridView.AllowUserToAddRows = false;
            this.foodAndPotionsDataGridView.AllowUserToDeleteRows = false;
            this.foodAndPotionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodAndPotionsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foodAndPotionsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.foodAndPotionsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.foodAndPotionsDataGridView.Name = "foodAndPotionsDataGridView";
            this.foodAndPotionsDataGridView.RowTemplate.Height = 25;
            this.foodAndPotionsDataGridView.Size = new System.Drawing.Size(786, 263);
            this.foodAndPotionsDataGridView.TabIndex = 1;
            // 
            // booksTabPage
            // 
            this.booksTabPage.Controls.Add(this.booksDataGridView);
            this.booksTabPage.Location = new System.Drawing.Point(4, 24);
            this.booksTabPage.Name = "booksTabPage";
            this.booksTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.booksTabPage.Size = new System.Drawing.Size(792, 269);
            this.booksTabPage.TabIndex = 5;
            this.booksTabPage.Text = "Books And Scrolls";
            this.booksTabPage.UseVisualStyleBackColor = true;
            // 
            // booksDataGridView
            // 
            this.booksDataGridView.AllowUserToAddRows = false;
            this.booksDataGridView.AllowUserToDeleteRows = false;
            this.booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.booksDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.booksDataGridView.Location = new System.Drawing.Point(3, 3);
            this.booksDataGridView.Name = "booksDataGridView";
            this.booksDataGridView.RowTemplate.Height = 25;
            this.booksDataGridView.Size = new System.Drawing.Size(786, 263);
            this.booksDataGridView.TabIndex = 2;
            // 
            // miscTabPage
            // 
            this.miscTabPage.Controls.Add(this.miscDataGridView);
            this.miscTabPage.Location = new System.Drawing.Point(4, 24);
            this.miscTabPage.Name = "miscTabPage";
            this.miscTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.miscTabPage.Size = new System.Drawing.Size(792, 269);
            this.miscTabPage.TabIndex = 2;
            this.miscTabPage.Text = "Misc Items";
            this.miscTabPage.UseVisualStyleBackColor = true;
            // 
            // miscDataGridView
            // 
            this.miscDataGridView.AllowUserToAddRows = false;
            this.miscDataGridView.AllowUserToDeleteRows = false;
            this.miscDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.miscDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.miscDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.miscDataGridView.Location = new System.Drawing.Point(3, 3);
            this.miscDataGridView.Name = "miscDataGridView";
            this.miscDataGridView.RowTemplate.Height = 25;
            this.miscDataGridView.Size = new System.Drawing.Size(786, 263);
            this.miscDataGridView.TabIndex = 1;
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.SystemColors.Desktop;
            this.console.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.console.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.console.ForeColor = System.Drawing.SystemColors.Window;
            this.console.Location = new System.Drawing.Point(0, 330);
            this.console.Multiline = true;
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(800, 120);
            this.console.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileStripMenuItem,
            this.loadOrderMenuItem,
            this.buildBatchStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileStripMenuItem
            // 
            this.fileStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitStripMenuItem});
            this.fileStripMenuItem.Name = "fileStripMenuItem";
            this.fileStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileStripMenuItem.Text = "File";
            // 
            // exitStripMenuItem
            // 
            this.exitStripMenuItem.Name = "exitStripMenuItem";
            this.exitStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitStripMenuItem.Text = "Exit";
            this.exitStripMenuItem.Click += new System.EventHandler(this.exitStripMenuItem_Click);
            // 
            // loadOrderMenuItem
            // 
            this.loadOrderMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.existingStripMenuItem,
            this.newStripMenuItem});
            this.loadOrderMenuItem.Name = "loadOrderMenuItem";
            this.loadOrderMenuItem.Size = new System.Drawing.Size(78, 20);
            this.loadOrderMenuItem.Text = "Load Order";
            // 
            // existingStripMenuItem
            // 
            this.existingStripMenuItem.Name = "existingStripMenuItem";
            this.existingStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.existingStripMenuItem.Text = "Current";
            this.existingStripMenuItem.Click += new System.EventHandler(this.existingStripMenuItem_Click);
            // 
            // newStripMenuItem
            // 
            this.newStripMenuItem.Name = "newStripMenuItem";
            this.newStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newStripMenuItem.Text = "Update";
            this.newStripMenuItem.Click += new System.EventHandler(this.newStripMenuItem_Click);
            // 
            // buildBatchStripMenuItem
            // 
            this.buildBatchStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildAllMenuItem,
            this.buildOnlyItemsMenuItem});
            this.buildBatchStripMenuItem.Name = "buildBatchStripMenuItem";
            this.buildBatchStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.buildBatchStripMenuItem.Text = "Build Batch";
            // 
            // buildAllMenuItem
            // 
            this.buildAllMenuItem.Name = "buildAllMenuItem";
            this.buildAllMenuItem.Size = new System.Drawing.Size(131, 22);
            this.buildAllMenuItem.Text = "All";
            this.buildAllMenuItem.Click += new System.EventHandler(this.buildAllMenuItem_Click);
            // 
            // buildOnlyItemsMenuItem
            // 
            this.buildOnlyItemsMenuItem.Name = "buildOnlyItemsMenuItem";
            this.buildOnlyItemsMenuItem.Size = new System.Drawing.Size(131, 22);
            this.buildOnlyItemsMenuItem.Text = "Only Items";
            this.buildOnlyItemsMenuItem.Click += new System.EventHandler(this.buildOnlyItemsMenuItem_Click);
            // 
            // ExportProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.console);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ExportProfile";
            this.Text = "Skyrim Batch Builder: Export Profile";
            this.tabControl1.ResumeLayout(false);
            this.weaponsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.weaponsDataGrid)).EndInit();
            this.armorTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.armorDataGridView)).EndInit();
            this.ingredientsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsDataGridView)).EndInit();
            this.foodAndPotionsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.foodAndPotionsDataGridView)).EndInit();
            this.booksTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).EndInit();
            this.miscTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.miscDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage weaponsTabPage;
        private System.Windows.Forms.TabPage armorTabPage;
        private System.Windows.Forms.DataGridView weaponsDataGrid;
        private System.Windows.Forms.TextBox console;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabPage miscTabPage;
        private System.Windows.Forms.TabPage ingredientsTabPage;
        private System.Windows.Forms.TabPage foodAndPotionsTabPage;
        private System.Windows.Forms.DataGridView armorDataGridView;
        private System.Windows.Forms.DataGridView miscDataGridView;
        private System.Windows.Forms.DataGridView ingredientsDataGridView;
        private System.Windows.Forms.DataGridView foodAndPotionsDataGridView;
        private System.Windows.Forms.ToolStripMenuItem fileStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildBatchStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadOrderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem existingStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newStripMenuItem;
        private System.Windows.Forms.TabPage booksTabPage;
        private System.Windows.Forms.DataGridView booksDataGridView;
        private System.Windows.Forms.ToolStripMenuItem buildAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildOnlyItemsMenuItem;
    }
}