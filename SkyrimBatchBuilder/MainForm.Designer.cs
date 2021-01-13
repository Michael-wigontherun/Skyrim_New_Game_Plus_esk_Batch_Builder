
using System;
using System.Configuration;
using System.IO;

namespace SkyrimBatchBuilder
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settings = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.generateStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateItemListsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generatePerkListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildReferencesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buildProfileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildOverloadProfileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadReferencesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPerksListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.loadProfileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadOverloadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportProfileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportCurrentSessionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.playerAVTabPage = new System.Windows.Forms.TabPage();
            this.playerSpeechcraftNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label32 = new System.Windows.Forms.Label();
            this.playerSneakNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label33 = new System.Windows.Forms.Label();
            this.playerPickpocketNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label34 = new System.Windows.Forms.Label();
            this.playerLockpickingNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.playerAlchemyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.playerRestorationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.playerIllusionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.playerEnchantingNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.playerDestructionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label28 = new System.Windows.Forms.Label();
            this.playerConjurationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.playerAlterationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.playerMarksmanNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.playerLightArmorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.playerHeavyArmorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.playerSmithingNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.playerBlockNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.playerTwoHandedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.playerOneHandedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.playerMagickaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.playerStaminaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.playerHealthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.playerDragonSoulsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.playerCarryWeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.playerGoldNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.playerLevelNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.profileNameTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.perkTabPage = new System.Windows.Forms.TabPage();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.perkCheckBoxList = new System.Windows.Forms.CheckedListBox();
            this.label42 = new System.Windows.Forms.Label();
            this.shoutsTabPage = new System.Windows.Forms.TabPage();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.shoutsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.weaponsTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.weaponCheckBoxList = new System.Windows.Forms.CheckedListBox();
            this.armorTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.armorCheckBoxList = new System.Windows.Forms.CheckedListBox();
            this.spellsTab = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.spellsCheckBoxList = new System.Windows.Forms.CheckedListBox();
            this.ingredientsTabPage = new System.Windows.Forms.TabPage();
            this.label31 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.ingredientsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.foodAndPotionsTabPage = new System.Windows.Forms.TabPage();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.foodAndPotionsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.booksAndScrollsTabPage = new System.Windows.Forms.TabPage();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.booksAndScrollsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.miscTabPage = new System.Windows.Forms.TabPage();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.miscCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.console = new System.Windows.Forms.TextBox();
            this.loadOrderTextBox = new System.Windows.Forms.TextBox();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.label54 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.playerAVTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerSpeechcraftNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerSneakNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPickpocketNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerLockpickingNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerAlchemyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerRestorationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerIllusionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerEnchantingNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDestructionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerConjurationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerAlterationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerMarksmanNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerLightArmorNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerHeavyArmorNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerSmithingNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBlockNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerTwoHandedNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerOneHandedNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerMagickaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerStaminaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerHealthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDragonSoulsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCarryWeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerGoldNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerLevelNumericUpDown)).BeginInit();
            this.perkTabPage.SuspendLayout();
            this.shoutsTabPage.SuspendLayout();
            this.weaponsTab.SuspendLayout();
            this.armorTab.SuspendLayout();
            this.spellsTab.SuspendLayout();
            this.ingredientsTabPage.SuspendLayout();
            this.foodAndPotionsTabPage.SuspendLayout();
            this.booksAndScrollsTabPage.SuspendLayout();
            this.miscTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileStripMenuItem,
            this.generateStripMenuItem,
            this.buildStripMenuItem,
            this.loadStripMenuItem,
            this.exportMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1242, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileStripMenuItem
            // 
            this.fileStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settings,
            this.Exit});
            this.fileStripMenuItem.Name = "fileStripMenuItem";
            this.fileStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileStripMenuItem.Text = "File";
            // 
            // settings
            // 
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(116, 22);
            this.settings.Text = "Settings";
            this.settings.ToolTipText = "Opens settings menu";
            this.settings.Click += new System.EventHandler(this.settingsClick);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(116, 22);
            this.Exit.Text = "Exit";
            this.Exit.ToolTipText = "Exits the program";
            this.Exit.Click += new System.EventHandler(this.exit);
            // 
            // generateStripMenuItem
            // 
            this.generateStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateItemListsMenuItem,
            this.generatePerkListMenuItem});
            this.generateStripMenuItem.Name = "generateStripMenuItem";
            this.generateStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.generateStripMenuItem.Text = "Generate";
            // 
            // generateItemListsMenuItem
            // 
            this.generateItemListsMenuItem.Name = "generateItemListsMenuItem";
            this.generateItemListsMenuItem.Size = new System.Drawing.Size(124, 22);
            this.generateItemListsMenuItem.Text = "Item Lists";
            this.generateItemListsMenuItem.ToolTipText = "Opens SSEEdit and genorates all item lists";
            this.generateItemListsMenuItem.Click += new System.EventHandler(this.GenerateItemListsMenuItem_Click);
            // 
            // generatePerkListMenuItem
            // 
            this.generatePerkListMenuItem.Name = "generatePerkListMenuItem";
            this.generatePerkListMenuItem.Size = new System.Drawing.Size(124, 22);
            this.generatePerkListMenuItem.Text = "Perk List";
            this.generatePerkListMenuItem.ToolTipText = "Opens SSEEdit and genorates a list of all perks.\r\n   Note: You should still manua" +
    "lly edit this list.";
            this.generatePerkListMenuItem.Click += new System.EventHandler(this.GeneratePerkListMenuItem_Click);
            // 
            // buildStripMenuItem
            // 
            this.buildStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildReferencesMenuItem,
            this.toolStripSeparator2,
            this.buildProfileMenuItem,
            this.buildOverloadProfileMenuItem});
            this.buildStripMenuItem.Name = "buildStripMenuItem";
            this.buildStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.buildStripMenuItem.Text = "Build";
            // 
            // buildReferencesMenuItem
            // 
            this.buildReferencesMenuItem.Name = "buildReferencesMenuItem";
            this.buildReferencesMenuItem.Size = new System.Drawing.Size(159, 22);
            this.buildReferencesMenuItem.Text = "References";
            this.buildReferencesMenuItem.ToolTipText = "Opens the Reference builder";
            this.buildReferencesMenuItem.Click += new System.EventHandler(this.BuildReferencesMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(156, 6);
            // 
            // buildProfileMenuItem
            // 
            this.buildProfileMenuItem.Name = "buildProfileMenuItem";
            this.buildProfileMenuItem.Size = new System.Drawing.Size(159, 22);
            this.buildProfileMenuItem.Text = "Profile / Rebuild";
            this.buildProfileMenuItem.ToolTipText = "Builds a profile using all check lists and AV settings\r\n   Note: Profile Name mus" +
    "t be filled in the Profile tab";
            this.buildProfileMenuItem.Click += new System.EventHandler(this.buildProfileMenuItem_Click);
            // 
            // buildOverloadProfileMenuItem
            // 
            this.buildOverloadProfileMenuItem.Name = "buildOverloadProfileMenuItem";
            this.buildOverloadProfileMenuItem.Size = new System.Drawing.Size(159, 22);
            this.buildOverloadProfileMenuItem.Text = "Overload Profile";
            this.buildOverloadProfileMenuItem.ToolTipText = "Builds an overload profile using all check lists,  but not AVs\r\n   Note: Profile " +
    "Name must be filled in the Profile tab";
            this.buildOverloadProfileMenuItem.Click += new System.EventHandler(this.buildOverloadProfileMenuItem_Click);
            // 
            // loadStripMenuItem
            // 
            this.loadStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadReferencesMenuItem,
            this.loadPerksListMenuItem,
            this.toolStripSeparator1,
            this.loadProfileMenuItem,
            this.loadOverloadMenuItem});
            this.loadStripMenuItem.Name = "loadStripMenuItem";
            this.loadStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.loadStripMenuItem.Text = "Load";
            // 
            // loadReferencesMenuItem
            // 
            this.loadReferencesMenuItem.Name = "loadReferencesMenuItem";
            this.loadReferencesMenuItem.Size = new System.Drawing.Size(159, 22);
            this.loadReferencesMenuItem.Text = "References";
            this.loadReferencesMenuItem.ToolTipText = "Loads references built by the References builder except perks";
            this.loadReferencesMenuItem.Click += new System.EventHandler(this.loadReferencesMenuItem_Click);
            // 
            // loadPerksListMenuItem
            // 
            this.loadPerksListMenuItem.Name = "loadPerksListMenuItem";
            this.loadPerksListMenuItem.Size = new System.Drawing.Size(159, 22);
            this.loadPerksListMenuItem.Text = "Perks List";
            this.loadPerksListMenuItem.ToolTipText = "Loads only perks";
            this.loadPerksListMenuItem.Click += new System.EventHandler(this.loadPerksListMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // loadProfileMenuItem
            // 
            this.loadProfileMenuItem.Name = "loadProfileMenuItem";
            this.loadProfileMenuItem.Size = new System.Drawing.Size(159, 22);
            this.loadProfileMenuItem.Text = "Profile";
            this.loadProfileMenuItem.ToolTipText = "Loads a profile";
            this.loadProfileMenuItem.Click += new System.EventHandler(this.loadProfileMenuItem_Click);
            // 
            // loadOverloadMenuItem
            // 
            this.loadOverloadMenuItem.Name = "loadOverloadMenuItem";
            this.loadOverloadMenuItem.Size = new System.Drawing.Size(159, 22);
            this.loadOverloadMenuItem.Text = "Overload Profile";
            this.loadOverloadMenuItem.ToolTipText = "Loads a profile, overload or regular, without unchecking checklists and does not " +
    "load any AVs";
            this.loadOverloadMenuItem.Click += new System.EventHandler(this.loadOverloadMenuItem_Click);
            // 
            // exportMenuItem
            // 
            this.exportMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportProfileMenuItem,
            this.exportCurrentSessionMenuItem});
            this.exportMenuItem.Name = "exportMenuItem";
            this.exportMenuItem.Size = new System.Drawing.Size(53, 20);
            this.exportMenuItem.Text = "Export";
            // 
            // exportProfileMenuItem
            // 
            this.exportProfileMenuItem.Name = "exportProfileMenuItem";
            this.exportProfileMenuItem.Size = new System.Drawing.Size(156, 22);
            this.exportProfileMenuItem.Text = "Profile";
            this.exportProfileMenuItem.ToolTipText = "Exports a selected profile to the batch builder";
            this.exportProfileMenuItem.Click += new System.EventHandler(this.exportProfileMenuItem_Click);
            // 
            // exportCurrentSessionMenuItem
            // 
            this.exportCurrentSessionMenuItem.Name = "exportCurrentSessionMenuItem";
            this.exportCurrentSessionMenuItem.Size = new System.Drawing.Size(156, 22);
            this.exportCurrentSessionMenuItem.Text = "Current Session";
            this.exportCurrentSessionMenuItem.ToolTipText = "Exports a the current checkboxes and AVs to the batch builder";
            this.exportCurrentSessionMenuItem.Click += new System.EventHandler(this.exportCurrentSessionMenuItem_Click);
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.playerAVTabPage);
            this.TabControl.Controls.Add(this.perkTabPage);
            this.TabControl.Controls.Add(this.shoutsTabPage);
            this.TabControl.Controls.Add(this.weaponsTab);
            this.TabControl.Controls.Add(this.armorTab);
            this.TabControl.Controls.Add(this.spellsTab);
            this.TabControl.Controls.Add(this.ingredientsTabPage);
            this.TabControl.Controls.Add(this.foodAndPotionsTabPage);
            this.TabControl.Controls.Add(this.booksAndScrollsTabPage);
            this.TabControl.Controls.Add(this.miscTabPage);
            this.TabControl.Location = new System.Drawing.Point(334, 27);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(896, 401);
            this.TabControl.TabIndex = 2;
            // 
            // playerAVTabPage
            // 
            this.playerAVTabPage.Controls.Add(this.playerSpeechcraftNumericUpDown);
            this.playerAVTabPage.Controls.Add(this.label32);
            this.playerAVTabPage.Controls.Add(this.playerSneakNumericUpDown);
            this.playerAVTabPage.Controls.Add(this.label33);
            this.playerAVTabPage.Controls.Add(this.playerPickpocketNumericUpDown);
            this.playerAVTabPage.Controls.Add(this.label34);
            this.playerAVTabPage.Controls.Add(this.playerLockpickingNumericUpDown);
            this.playerAVTabPage.Controls.Add(this.playerAlchemyNumericUpDown);
            this.playerAVTabPage.Controls.Add(this.label35);
            this.playerAVTabPage.Controls.Add(this.label36);
            this.playerAVTabPage.Controls.Add(this.playerRestorationNumericUpDown);
            this.playerAVTabPage.Controls.Add(this.label25);
            this.playerAVTabPage.Controls.Add(this.playerIllusionNumericUpDown);
            this.playerAVTabPage.Controls.Add(this.label26);
            this.playerAVTabPage.Controls.Add(this.playerEnchantingNumericUpDown);
            this.playerAVTabPage.Controls.Add(this.label27);
            this.playerAVTabPage.Controls.Add(this.playerDestructionNumericUpDown);
            this.playerAVTabPage.Controls.Add(this.label28);
            this.playerAVTabPage.Controls.Add(this.playerConjurationNumericUpDown);
            this.playerAVTabPage.Controls.Add(this.playerAlterationNumericUpDown);
            this.playerAVTabPage.Controls.Add(this.label29);
            this.playerAVTabPage.Controls.Add(this.label30);
            this.playerAVTabPage.Controls.Add(this.playerMarksmanNumericUpDown);
            this.playerAVTabPage.Controls.Add(this.label24);
            this.playerAVTabPage.Controls.Add(this.playerLightArmorNumericUpDown);
            this.playerAVTabPage.Controls.Add(this.label23);
            this.playerAVTabPage.Controls.Add(this.playerHeavyArmorNumericUpDown);
            this.playerAVTabPage.Controls.Add(this.label22);
            this.playerAVTabPage.Controls.Add(this.playerSmithingNumericUpDown);
            this.playerAVTabPage.Controls.Add(this.label21);
            this.playerAVTabPage.Controls.Add(this.playerBlockNumericUpDown);
            this.playerAVTabPage.Controls.Add(this.label20);
            this.playerAVTabPage.Controls.Add(this.playerTwoHandedNumericUpDown);
            this.playerAVTabPage.Controls.Add(this.playerOneHandedNumericUpDown);
            this.playerAVTabPage.Controls.Add(this.playerMagickaNumericUpDown);
            this.playerAVTabPage.Controls.Add(this.playerStaminaNumericUpDown);
            this.playerAVTabPage.Controls.Add(this.playerHealthNumericUpDown);
            this.playerAVTabPage.Controls.Add(this.playerDragonSoulsNumericUpDown);
            this.playerAVTabPage.Controls.Add(this.playerCarryWeightNumericUpDown);
            this.playerAVTabPage.Controls.Add(this.playerGoldNumericUpDown);
            this.playerAVTabPage.Controls.Add(this.playerLevelNumericUpDown);
            this.playerAVTabPage.Controls.Add(this.label19);
            this.playerAVTabPage.Controls.Add(this.label18);
            this.playerAVTabPage.Controls.Add(this.label17);
            this.playerAVTabPage.Controls.Add(this.label16);
            this.playerAVTabPage.Controls.Add(this.label15);
            this.playerAVTabPage.Controls.Add(this.label14);
            this.playerAVTabPage.Controls.Add(this.label13);
            this.playerAVTabPage.Controls.Add(this.label12);
            this.playerAVTabPage.Controls.Add(this.label11);
            this.playerAVTabPage.Controls.Add(this.profileNameTextBox);
            this.playerAVTabPage.Controls.Add(this.label10);
            this.playerAVTabPage.Location = new System.Drawing.Point(4, 24);
            this.playerAVTabPage.Name = "playerAVTabPage";
            this.playerAVTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.playerAVTabPage.Size = new System.Drawing.Size(888, 373);
            this.playerAVTabPage.TabIndex = 3;
            this.playerAVTabPage.Text = "Profile";
            this.playerAVTabPage.UseVisualStyleBackColor = true;
            // 
            // playerSpeechcraftNumericUpDown
            // 
            this.playerSpeechcraftNumericUpDown.Location = new System.Drawing.Point(683, 209);
            this.playerSpeechcraftNumericUpDown.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.playerSpeechcraftNumericUpDown.Name = "playerSpeechcraftNumericUpDown";
            this.playerSpeechcraftNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.playerSpeechcraftNumericUpDown.TabIndex = 59;
            this.playerSpeechcraftNumericUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(683, 190);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(69, 15);
            this.label32.TabIndex = 58;
            this.label32.Text = "Speechcraft";
            // 
            // playerSneakNumericUpDown
            // 
            this.playerSneakNumericUpDown.Location = new System.Drawing.Point(683, 163);
            this.playerSneakNumericUpDown.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.playerSneakNumericUpDown.Name = "playerSneakNumericUpDown";
            this.playerSneakNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.playerSneakNumericUpDown.TabIndex = 57;
            this.playerSneakNumericUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(683, 145);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(38, 15);
            this.label33.TabIndex = 56;
            this.label33.Text = "Sneak";
            // 
            // playerPickpocketNumericUpDown
            // 
            this.playerPickpocketNumericUpDown.Location = new System.Drawing.Point(683, 118);
            this.playerPickpocketNumericUpDown.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.playerPickpocketNumericUpDown.Name = "playerPickpocketNumericUpDown";
            this.playerPickpocketNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.playerPickpocketNumericUpDown.TabIndex = 55;
            this.playerPickpocketNumericUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(683, 100);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(65, 15);
            this.label34.TabIndex = 54;
            this.label34.Text = "Pickpocket";
            // 
            // playerLockpickingNumericUpDown
            // 
            this.playerLockpickingNumericUpDown.Location = new System.Drawing.Point(683, 73);
            this.playerLockpickingNumericUpDown.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.playerLockpickingNumericUpDown.Name = "playerLockpickingNumericUpDown";
            this.playerLockpickingNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.playerLockpickingNumericUpDown.TabIndex = 53;
            this.playerLockpickingNumericUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // playerAlchemyNumericUpDown
            // 
            this.playerAlchemyNumericUpDown.Location = new System.Drawing.Point(683, 29);
            this.playerAlchemyNumericUpDown.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.playerAlchemyNumericUpDown.Name = "playerAlchemyNumericUpDown";
            this.playerAlchemyNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.playerAlchemyNumericUpDown.TabIndex = 52;
            this.playerAlchemyNumericUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(683, 55);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(71, 15);
            this.label35.TabIndex = 51;
            this.label35.Text = "Lockpicking";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(683, 10);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(54, 15);
            this.label36.TabIndex = 50;
            this.label36.Text = "Alchemy";
            // 
            // playerRestorationNumericUpDown
            // 
            this.playerRestorationNumericUpDown.Location = new System.Drawing.Point(457, 254);
            this.playerRestorationNumericUpDown.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.playerRestorationNumericUpDown.Name = "playerRestorationNumericUpDown";
            this.playerRestorationNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.playerRestorationNumericUpDown.TabIndex = 49;
            this.playerRestorationNumericUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(457, 235);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(67, 15);
            this.label25.TabIndex = 48;
            this.label25.Text = "Restoration";
            // 
            // playerIllusionNumericUpDown
            // 
            this.playerIllusionNumericUpDown.Location = new System.Drawing.Point(457, 209);
            this.playerIllusionNumericUpDown.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.playerIllusionNumericUpDown.Name = "playerIllusionNumericUpDown";
            this.playerIllusionNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.playerIllusionNumericUpDown.TabIndex = 47;
            this.playerIllusionNumericUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(457, 190);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(45, 15);
            this.label26.TabIndex = 46;
            this.label26.Text = "Illusion";
            // 
            // playerEnchantingNumericUpDown
            // 
            this.playerEnchantingNumericUpDown.Location = new System.Drawing.Point(457, 163);
            this.playerEnchantingNumericUpDown.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.playerEnchantingNumericUpDown.Name = "playerEnchantingNumericUpDown";
            this.playerEnchantingNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.playerEnchantingNumericUpDown.TabIndex = 45;
            this.playerEnchantingNumericUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(457, 145);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(67, 15);
            this.label27.TabIndex = 44;
            this.label27.Text = "Enchanting";
            // 
            // playerDestructionNumericUpDown
            // 
            this.playerDestructionNumericUpDown.Location = new System.Drawing.Point(457, 118);
            this.playerDestructionNumericUpDown.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.playerDestructionNumericUpDown.Name = "playerDestructionNumericUpDown";
            this.playerDestructionNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.playerDestructionNumericUpDown.TabIndex = 43;
            this.playerDestructionNumericUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(457, 100);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(68, 15);
            this.label28.TabIndex = 42;
            this.label28.Text = "Destruction";
            // 
            // playerConjurationNumericUpDown
            // 
            this.playerConjurationNumericUpDown.Location = new System.Drawing.Point(457, 73);
            this.playerConjurationNumericUpDown.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.playerConjurationNumericUpDown.Name = "playerConjurationNumericUpDown";
            this.playerConjurationNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.playerConjurationNumericUpDown.TabIndex = 41;
            this.playerConjurationNumericUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // playerAlterationNumericUpDown
            // 
            this.playerAlterationNumericUpDown.Location = new System.Drawing.Point(457, 29);
            this.playerAlterationNumericUpDown.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.playerAlterationNumericUpDown.Name = "playerAlterationNumericUpDown";
            this.playerAlterationNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.playerAlterationNumericUpDown.TabIndex = 40;
            this.playerAlterationNumericUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(457, 55);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(70, 15);
            this.label29.TabIndex = 39;
            this.label29.Text = "Conjuration";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(457, 10);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(59, 15);
            this.label30.TabIndex = 38;
            this.label30.Text = "Alteration";
            // 
            // playerMarksmanNumericUpDown
            // 
            this.playerMarksmanNumericUpDown.Location = new System.Drawing.Point(683, 253);
            this.playerMarksmanNumericUpDown.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.playerMarksmanNumericUpDown.Name = "playerMarksmanNumericUpDown";
            this.playerMarksmanNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.playerMarksmanNumericUpDown.TabIndex = 37;
            this.playerMarksmanNumericUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(683, 235);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(63, 15);
            this.label24.TabIndex = 36;
            this.label24.Text = "Marksman";
            // 
            // playerLightArmorNumericUpDown
            // 
            this.playerLightArmorNumericUpDown.Location = new System.Drawing.Point(223, 254);
            this.playerLightArmorNumericUpDown.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.playerLightArmorNumericUpDown.Name = "playerLightArmorNumericUpDown";
            this.playerLightArmorNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.playerLightArmorNumericUpDown.TabIndex = 35;
            this.playerLightArmorNumericUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(223, 235);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(68, 15);
            this.label23.TabIndex = 34;
            this.label23.Text = "LightArmor";
            // 
            // playerHeavyArmorNumericUpDown
            // 
            this.playerHeavyArmorNumericUpDown.Location = new System.Drawing.Point(223, 209);
            this.playerHeavyArmorNumericUpDown.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.playerHeavyArmorNumericUpDown.Name = "playerHeavyArmorNumericUpDown";
            this.playerHeavyArmorNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.playerHeavyArmorNumericUpDown.TabIndex = 33;
            this.playerHeavyArmorNumericUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(223, 190);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(74, 15);
            this.label22.TabIndex = 32;
            this.label22.Text = "HeavyArmor";
            // 
            // playerSmithingNumericUpDown
            // 
            this.playerSmithingNumericUpDown.Location = new System.Drawing.Point(223, 163);
            this.playerSmithingNumericUpDown.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.playerSmithingNumericUpDown.Name = "playerSmithingNumericUpDown";
            this.playerSmithingNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.playerSmithingNumericUpDown.TabIndex = 31;
            this.playerSmithingNumericUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(223, 145);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 15);
            this.label21.TabIndex = 30;
            this.label21.Text = "Smithing";
            // 
            // playerBlockNumericUpDown
            // 
            this.playerBlockNumericUpDown.Location = new System.Drawing.Point(223, 118);
            this.playerBlockNumericUpDown.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.playerBlockNumericUpDown.Name = "playerBlockNumericUpDown";
            this.playerBlockNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.playerBlockNumericUpDown.TabIndex = 29;
            this.playerBlockNumericUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(223, 100);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 15);
            this.label20.TabIndex = 28;
            this.label20.Text = "Block";
            // 
            // playerTwoHandedNumericUpDown
            // 
            this.playerTwoHandedNumericUpDown.Location = new System.Drawing.Point(223, 73);
            this.playerTwoHandedNumericUpDown.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.playerTwoHandedNumericUpDown.Name = "playerTwoHandedNumericUpDown";
            this.playerTwoHandedNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.playerTwoHandedNumericUpDown.TabIndex = 27;
            this.playerTwoHandedNumericUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // playerOneHandedNumericUpDown
            // 
            this.playerOneHandedNumericUpDown.Location = new System.Drawing.Point(223, 29);
            this.playerOneHandedNumericUpDown.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.playerOneHandedNumericUpDown.Name = "playerOneHandedNumericUpDown";
            this.playerOneHandedNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.playerOneHandedNumericUpDown.TabIndex = 26;
            this.playerOneHandedNumericUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // playerMagickaNumericUpDown
            // 
            this.playerMagickaNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.playerMagickaNumericUpDown.Location = new System.Drawing.Point(13, 343);
            this.playerMagickaNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.playerMagickaNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.playerMagickaNumericUpDown.Name = "playerMagickaNumericUpDown";
            this.playerMagickaNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.playerMagickaNumericUpDown.TabIndex = 25;
            this.playerMagickaNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // playerStaminaNumericUpDown
            // 
            this.playerStaminaNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.playerStaminaNumericUpDown.Location = new System.Drawing.Point(13, 299);
            this.playerStaminaNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.playerStaminaNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.playerStaminaNumericUpDown.Name = "playerStaminaNumericUpDown";
            this.playerStaminaNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.playerStaminaNumericUpDown.TabIndex = 24;
            this.playerStaminaNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // playerHealthNumericUpDown
            // 
            this.playerHealthNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.playerHealthNumericUpDown.Location = new System.Drawing.Point(13, 254);
            this.playerHealthNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.playerHealthNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.playerHealthNumericUpDown.Name = "playerHealthNumericUpDown";
            this.playerHealthNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.playerHealthNumericUpDown.TabIndex = 23;
            this.playerHealthNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // playerDragonSoulsNumericUpDown
            // 
            this.playerDragonSoulsNumericUpDown.Location = new System.Drawing.Point(13, 209);
            this.playerDragonSoulsNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.playerDragonSoulsNumericUpDown.Name = "playerDragonSoulsNumericUpDown";
            this.playerDragonSoulsNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.playerDragonSoulsNumericUpDown.TabIndex = 22;
            // 
            // playerCarryWeightNumericUpDown
            // 
            this.playerCarryWeightNumericUpDown.Location = new System.Drawing.Point(13, 163);
            this.playerCarryWeightNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.playerCarryWeightNumericUpDown.Name = "playerCarryWeightNumericUpDown";
            this.playerCarryWeightNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.playerCarryWeightNumericUpDown.TabIndex = 21;
            this.playerCarryWeightNumericUpDown.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // playerGoldNumericUpDown
            // 
            this.playerGoldNumericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.playerGoldNumericUpDown.Location = new System.Drawing.Point(13, 118);
            this.playerGoldNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.playerGoldNumericUpDown.Name = "playerGoldNumericUpDown";
            this.playerGoldNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.playerGoldNumericUpDown.TabIndex = 20;
            // 
            // playerLevelNumericUpDown
            // 
            this.playerLevelNumericUpDown.Location = new System.Drawing.Point(13, 73);
            this.playerLevelNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.playerLevelNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.playerLevelNumericUpDown.Name = "playerLevelNumericUpDown";
            this.playerLevelNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.playerLevelNumericUpDown.TabIndex = 19;
            this.playerLevelNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(223, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 15);
            this.label19.TabIndex = 18;
            this.label19.Text = "TwoHanded";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(223, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 15);
            this.label18.TabIndex = 16;
            this.label18.Text = "OneHanded";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 325);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 15);
            this.label17.TabIndex = 14;
            this.label17.Text = "Magicka";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 280);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 15);
            this.label16.TabIndex = 12;
            this.label16.Text = "Stamina";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 235);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 15);
            this.label15.TabIndex = 10;
            this.label15.Text = "Health";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 190);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 15);
            this.label14.TabIndex = 8;
            this.label14.Text = "Dragon Souls";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 15);
            this.label13.TabIndex = 6;
            this.label13.Text = "Carry Weight";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 15);
            this.label12.TabIndex = 4;
            this.label12.Text = "Gold";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Level";
            // 
            // profileNameTextBox
            // 
            this.profileNameTextBox.Location = new System.Drawing.Point(13, 29);
            this.profileNameTextBox.Name = "profileNameTextBox";
            this.profileNameTextBox.Size = new System.Drawing.Size(116, 23);
            this.profileNameTextBox.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Profile Name:";
            // 
            // perkTabPage
            // 
            this.perkTabPage.Controls.Add(this.label44);
            this.perkTabPage.Controls.Add(this.label43);
            this.perkTabPage.Controls.Add(this.perkCheckBoxList);
            this.perkTabPage.Controls.Add(this.label42);
            this.perkTabPage.Location = new System.Drawing.Point(4, 24);
            this.perkTabPage.Name = "perkTabPage";
            this.perkTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.perkTabPage.Size = new System.Drawing.Size(888, 373);
            this.perkTabPage.TabIndex = 6;
            this.perkTabPage.Text = "Perks";
            this.perkTabPage.UseVisualStyleBackColor = true;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(242, 12);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(55, 15);
            this.label44.TabIndex = 12;
            this.label44.Text = "Skill Type";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(389, 12);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(67, 15);
            this.label43.TabIndex = 11;
            this.label43.Text = "Description";
            // 
            // perkCheckBoxList
            // 
            this.perkCheckBoxList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.perkCheckBoxList.CheckOnClick = true;
            this.perkCheckBoxList.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.perkCheckBoxList.FormattingEnabled = true;
            this.perkCheckBoxList.HorizontalScrollbar = true;
            this.perkCheckBoxList.Location = new System.Drawing.Point(3, 30);
            this.perkCheckBoxList.Name = "perkCheckBoxList";
            this.perkCheckBoxList.Size = new System.Drawing.Size(882, 340);
            this.perkCheckBoxList.TabIndex = 9;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(25, 12);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(65, 15);
            this.label42.TabIndex = 0;
            this.label42.Text = "Perk Name";
            // 
            // shoutsTabPage
            // 
            this.shoutsTabPage.Controls.Add(this.label48);
            this.shoutsTabPage.Controls.Add(this.label49);
            this.shoutsTabPage.Controls.Add(this.label50);
            this.shoutsTabPage.Controls.Add(this.shoutsCheckedListBox);
            this.shoutsTabPage.Location = new System.Drawing.Point(4, 24);
            this.shoutsTabPage.Name = "shoutsTabPage";
            this.shoutsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.shoutsTabPage.Size = new System.Drawing.Size(888, 373);
            this.shoutsTabPage.TabIndex = 8;
            this.shoutsTabPage.Text = "Shouts";
            this.shoutsTabPage.UseVisualStyleBackColor = true;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(737, 12);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(36, 15);
            this.label48.TabIndex = 19;
            this.label48.Text = "Word";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(242, 12);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(73, 15);
            this.label49.TabIndex = 18;
            this.label49.Text = "Shout Name";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(25, 12);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(76, 15);
            this.label50.TabIndex = 17;
            this.label50.Text = "Plugin Name";
            // 
            // shoutsCheckedListBox
            // 
            this.shoutsCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shoutsCheckedListBox.CheckOnClick = true;
            this.shoutsCheckedListBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shoutsCheckedListBox.FormattingEnabled = true;
            this.shoutsCheckedListBox.Location = new System.Drawing.Point(3, 30);
            this.shoutsCheckedListBox.Name = "shoutsCheckedListBox";
            this.shoutsCheckedListBox.Size = new System.Drawing.Size(882, 340);
            this.shoutsCheckedListBox.TabIndex = 16;
            // 
            // weaponsTab
            // 
            this.weaponsTab.AutoScroll = true;
            this.weaponsTab.Controls.Add(this.label3);
            this.weaponsTab.Controls.Add(this.label2);
            this.weaponsTab.Controls.Add(this.label1);
            this.weaponsTab.Controls.Add(this.weaponCheckBoxList);
            this.weaponsTab.Location = new System.Drawing.Point(4, 24);
            this.weaponsTab.Name = "weaponsTab";
            this.weaponsTab.Padding = new System.Windows.Forms.Padding(3);
            this.weaponsTab.Size = new System.Drawing.Size(888, 373);
            this.weaponsTab.TabIndex = 0;
            this.weaponsTab.Text = "Weapons";
            this.weaponsTab.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(737, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Weapon Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Weapon Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plugin Name";
            // 
            // weaponCheckBoxList
            // 
            this.weaponCheckBoxList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weaponCheckBoxList.CheckOnClick = true;
            this.weaponCheckBoxList.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.weaponCheckBoxList.FormattingEnabled = true;
            this.weaponCheckBoxList.Location = new System.Drawing.Point(3, 30);
            this.weaponCheckBoxList.Name = "weaponCheckBoxList";
            this.weaponCheckBoxList.Size = new System.Drawing.Size(882, 340);
            this.weaponCheckBoxList.TabIndex = 0;
            // 
            // armorTab
            // 
            this.armorTab.Controls.Add(this.label4);
            this.armorTab.Controls.Add(this.label5);
            this.armorTab.Controls.Add(this.label6);
            this.armorTab.Controls.Add(this.armorCheckBoxList);
            this.armorTab.Location = new System.Drawing.Point(4, 24);
            this.armorTab.Name = "armorTab";
            this.armorTab.Padding = new System.Windows.Forms.Padding(3);
            this.armorTab.Size = new System.Drawing.Size(888, 373);
            this.armorTab.TabIndex = 1;
            this.armorTab.Text = "Armor";
            this.armorTab.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(737, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Armor Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Armor Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Plugin Name";
            // 
            // armorCheckBoxList
            // 
            this.armorCheckBoxList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.armorCheckBoxList.CheckOnClick = true;
            this.armorCheckBoxList.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.armorCheckBoxList.FormattingEnabled = true;
            this.armorCheckBoxList.Location = new System.Drawing.Point(3, 30);
            this.armorCheckBoxList.Name = "armorCheckBoxList";
            this.armorCheckBoxList.Size = new System.Drawing.Size(882, 340);
            this.armorCheckBoxList.TabIndex = 0;
            // 
            // spellsTab
            // 
            this.spellsTab.Controls.Add(this.label7);
            this.spellsTab.Controls.Add(this.label8);
            this.spellsTab.Controls.Add(this.label9);
            this.spellsTab.Controls.Add(this.spellsCheckBoxList);
            this.spellsTab.Location = new System.Drawing.Point(4, 24);
            this.spellsTab.Name = "spellsTab";
            this.spellsTab.Padding = new System.Windows.Forms.Padding(3);
            this.spellsTab.Size = new System.Drawing.Size(888, 373);
            this.spellsTab.TabIndex = 2;
            this.spellsTab.Text = "Spells";
            this.spellsTab.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(737, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "School";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Spell Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Plugin Name";
            // 
            // spellsCheckBoxList
            // 
            this.spellsCheckBoxList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spellsCheckBoxList.CheckOnClick = true;
            this.spellsCheckBoxList.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.spellsCheckBoxList.FormattingEnabled = true;
            this.spellsCheckBoxList.Location = new System.Drawing.Point(3, 30);
            this.spellsCheckBoxList.Name = "spellsCheckBoxList";
            this.spellsCheckBoxList.Size = new System.Drawing.Size(882, 340);
            this.spellsCheckBoxList.TabIndex = 0;
            // 
            // ingredientsTabPage
            // 
            this.ingredientsTabPage.Controls.Add(this.label31);
            this.ingredientsTabPage.Controls.Add(this.label37);
            this.ingredientsTabPage.Controls.Add(this.label38);
            this.ingredientsTabPage.Controls.Add(this.ingredientsCheckedListBox);
            this.ingredientsTabPage.Location = new System.Drawing.Point(4, 24);
            this.ingredientsTabPage.Name = "ingredientsTabPage";
            this.ingredientsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ingredientsTabPage.Size = new System.Drawing.Size(888, 373);
            this.ingredientsTabPage.TabIndex = 4;
            this.ingredientsTabPage.Text = "Ingredients";
            this.ingredientsTabPage.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(737, 12);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(31, 15);
            this.label31.TabIndex = 7;
            this.label31.Text = "Type";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(242, 12);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(101, 15);
            this.label37.TabIndex = 6;
            this.label37.Text = "Ingredients Name";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(25, 12);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(76, 15);
            this.label38.TabIndex = 5;
            this.label38.Text = "Plugin Name";
            // 
            // ingredientsCheckedListBox
            // 
            this.ingredientsCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ingredientsCheckedListBox.CheckOnClick = true;
            this.ingredientsCheckedListBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ingredientsCheckedListBox.FormattingEnabled = true;
            this.ingredientsCheckedListBox.Location = new System.Drawing.Point(3, 30);
            this.ingredientsCheckedListBox.Name = "ingredientsCheckedListBox";
            this.ingredientsCheckedListBox.Size = new System.Drawing.Size(882, 340);
            this.ingredientsCheckedListBox.TabIndex = 4;
            // 
            // foodAndPotionsTabPage
            // 
            this.foodAndPotionsTabPage.Controls.Add(this.label39);
            this.foodAndPotionsTabPage.Controls.Add(this.label40);
            this.foodAndPotionsTabPage.Controls.Add(this.label41);
            this.foodAndPotionsTabPage.Controls.Add(this.foodAndPotionsCheckedListBox);
            this.foodAndPotionsTabPage.Location = new System.Drawing.Point(4, 24);
            this.foodAndPotionsTabPage.Name = "foodAndPotionsTabPage";
            this.foodAndPotionsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.foodAndPotionsTabPage.Size = new System.Drawing.Size(888, 373);
            this.foodAndPotionsTabPage.TabIndex = 5;
            this.foodAndPotionsTabPage.Text = "Food and Potions";
            this.foodAndPotionsTabPage.UseVisualStyleBackColor = true;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(737, 12);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(31, 15);
            this.label39.TabIndex = 11;
            this.label39.Text = "Type";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(242, 12);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(109, 15);
            this.label40.TabIndex = 10;
            this.label40.Text = "Consumable Name";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(25, 12);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(76, 15);
            this.label41.TabIndex = 9;
            this.label41.Text = "Plugin Name";
            // 
            // foodAndPotionsCheckedListBox
            // 
            this.foodAndPotionsCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.foodAndPotionsCheckedListBox.CheckOnClick = true;
            this.foodAndPotionsCheckedListBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foodAndPotionsCheckedListBox.FormattingEnabled = true;
            this.foodAndPotionsCheckedListBox.Location = new System.Drawing.Point(3, 30);
            this.foodAndPotionsCheckedListBox.Name = "foodAndPotionsCheckedListBox";
            this.foodAndPotionsCheckedListBox.Size = new System.Drawing.Size(882, 340);
            this.foodAndPotionsCheckedListBox.TabIndex = 8;
            // 
            // booksAndScrollsTabPage
            // 
            this.booksAndScrollsTabPage.Controls.Add(this.label51);
            this.booksAndScrollsTabPage.Controls.Add(this.label52);
            this.booksAndScrollsTabPage.Controls.Add(this.label53);
            this.booksAndScrollsTabPage.Controls.Add(this.booksAndScrollsCheckedListBox);
            this.booksAndScrollsTabPage.Location = new System.Drawing.Point(4, 24);
            this.booksAndScrollsTabPage.Name = "booksAndScrollsTabPage";
            this.booksAndScrollsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.booksAndScrollsTabPage.Size = new System.Drawing.Size(888, 373);
            this.booksAndScrollsTabPage.TabIndex = 9;
            this.booksAndScrollsTabPage.Text = "Books and Scrolls";
            this.booksAndScrollsTabPage.UseVisualStyleBackColor = true;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(737, 12);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(31, 15);
            this.label51.TabIndex = 19;
            this.label51.Text = "Type";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(242, 12);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(66, 15);
            this.label52.TabIndex = 18;
            this.label52.Text = "Item Name";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(25, 12);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(76, 15);
            this.label53.TabIndex = 17;
            this.label53.Text = "Plugin Name";
            // 
            // booksAndScrollsCheckedListBox
            // 
            this.booksAndScrollsCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.booksAndScrollsCheckedListBox.CheckOnClick = true;
            this.booksAndScrollsCheckedListBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.booksAndScrollsCheckedListBox.FormattingEnabled = true;
            this.booksAndScrollsCheckedListBox.Location = new System.Drawing.Point(3, 30);
            this.booksAndScrollsCheckedListBox.Name = "booksAndScrollsCheckedListBox";
            this.booksAndScrollsCheckedListBox.Size = new System.Drawing.Size(882, 340);
            this.booksAndScrollsCheckedListBox.TabIndex = 16;
            // 
            // miscTabPage
            // 
            this.miscTabPage.Controls.Add(this.label45);
            this.miscTabPage.Controls.Add(this.label46);
            this.miscTabPage.Controls.Add(this.label47);
            this.miscTabPage.Controls.Add(this.miscCheckedListBox);
            this.miscTabPage.Location = new System.Drawing.Point(4, 24);
            this.miscTabPage.Name = "miscTabPage";
            this.miscTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.miscTabPage.Size = new System.Drawing.Size(888, 373);
            this.miscTabPage.TabIndex = 7;
            this.miscTabPage.Text = "Misc Items";
            this.miscTabPage.UseVisualStyleBackColor = true;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(737, 12);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(31, 15);
            this.label45.TabIndex = 15;
            this.label45.Text = "Type";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(242, 12);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(66, 15);
            this.label46.TabIndex = 14;
            this.label46.Text = "Item Name";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(25, 12);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(76, 15);
            this.label47.TabIndex = 13;
            this.label47.Text = "Plugin Name";
            // 
            // miscCheckedListBox
            // 
            this.miscCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.miscCheckedListBox.CheckOnClick = true;
            this.miscCheckedListBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.miscCheckedListBox.FormattingEnabled = true;
            this.miscCheckedListBox.Location = new System.Drawing.Point(3, 30);
            this.miscCheckedListBox.Name = "miscCheckedListBox";
            this.miscCheckedListBox.Size = new System.Drawing.Size(882, 340);
            this.miscCheckedListBox.TabIndex = 12;
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.SystemColors.Desktop;
            this.console.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.console.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.console.ForeColor = System.Drawing.SystemColors.Window;
            this.console.Location = new System.Drawing.Point(0, 434);
            this.console.MaxLength = 1000000000;
            this.console.Multiline = true;
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.console.Size = new System.Drawing.Size(1242, 109);
            this.console.TabIndex = 6;
            // 
            // loadOrderTextBox
            // 
            this.loadOrderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.loadOrderTextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadOrderTextBox.Location = new System.Drawing.Point(12, 51);
            this.loadOrderTextBox.MaxLength = 1000000000;
            this.loadOrderTextBox.Multiline = true;
            this.loadOrderTextBox.Name = "loadOrderTextBox";
            this.loadOrderTextBox.ReadOnly = true;
            this.loadOrderTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.loadOrderTextBox.Size = new System.Drawing.Size(316, 373);
            this.loadOrderTextBox.TabIndex = 7;
            this.loadOrderTextBox.Text = "\r\n";
            this.loadOrderTextBox.WordWrap = false;
            // 
            // sortComboBox
            // 
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "Item Name",
            "Plugin Name",
            "Type"});
            this.sortComboBox.Location = new System.Drawing.Point(198, 27);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(130, 23);
            this.sortComboBox.TabIndex = 8;
            this.sortComboBox.SelectedIndexChanged += new System.EventHandler(this.sortComboBox_SelectedIndexChanged);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(148, 30);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(44, 15);
            this.label54.TabIndex = 9;
            this.label54.Text = "Sort by";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 543);
            this.Controls.Add(this.label54);
            this.Controls.Add(this.sortComboBox);
            this.Controls.Add(this.loadOrderTextBox);
            this.Controls.Add(this.console);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1258, 582);
            this.Name = "MainForm";
            this.Text = "Skyrim Batch Builder: Profile Creation";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.playerAVTabPage.ResumeLayout(false);
            this.playerAVTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerSpeechcraftNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerSneakNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPickpocketNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerLockpickingNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerAlchemyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerRestorationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerIllusionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerEnchantingNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDestructionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerConjurationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerAlterationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerMarksmanNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerLightArmorNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerHeavyArmorNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerSmithingNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBlockNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerTwoHandedNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerOneHandedNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerMagickaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerStaminaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerHealthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDragonSoulsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCarryWeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerGoldNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerLevelNumericUpDown)).EndInit();
            this.perkTabPage.ResumeLayout(false);
            this.perkTabPage.PerformLayout();
            this.shoutsTabPage.ResumeLayout(false);
            this.shoutsTabPage.PerformLayout();
            this.weaponsTab.ResumeLayout(false);
            this.weaponsTab.PerformLayout();
            this.armorTab.ResumeLayout(false);
            this.armorTab.PerformLayout();
            this.spellsTab.ResumeLayout(false);
            this.spellsTab.PerformLayout();
            this.ingredientsTabPage.ResumeLayout(false);
            this.ingredientsTabPage.PerformLayout();
            this.foodAndPotionsTabPage.ResumeLayout(false);
            this.foodAndPotionsTabPage.PerformLayout();
            this.booksAndScrollsTabPage.ResumeLayout(false);
            this.booksAndScrollsTabPage.PerformLayout();
            this.miscTabPage.ResumeLayout(false);
            this.miscTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage weaponsTab;
        private System.Windows.Forms.TabPage armorTab;
        private System.Windows.Forms.TabPage spellsTab;
        private System.Windows.Forms.CheckedListBox armorCheckBoxList;
        private System.Windows.Forms.CheckedListBox spellsCheckBoxList;
        private System.Windows.Forms.ToolStripMenuItem settings;
        private System.Windows.Forms.ToolStripMenuItem generateItemListsMenuItem;
        private System.Windows.Forms.CheckedListBox weaponCheckBoxList;
        private System.Windows.Forms.TextBox console;
        private System.Windows.Forms.ToolStripMenuItem fileStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildReferencesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadReferencesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadProfileMenuItem;
        private System.Windows.Forms.TextBox loadOrderTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem buildProfileMenuItem;
        private System.Windows.Forms.TabPage playerAVTabPage;
        private System.Windows.Forms.TextBox profileNameTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown playerLevelNumericUpDown;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown playerSpeechcraftNumericUpDown;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.NumericUpDown playerSneakNumericUpDown;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.NumericUpDown playerPickpocketNumericUpDown;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.NumericUpDown playerLockpickingNumericUpDown;
        private System.Windows.Forms.NumericUpDown playerAlchemyNumericUpDown;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.NumericUpDown playerRestorationNumericUpDown;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.NumericUpDown playerIllusionNumericUpDown;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.NumericUpDown playerEnchantingNumericUpDown;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.NumericUpDown playerDestructionNumericUpDown;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.NumericUpDown playerConjurationNumericUpDown;
        private System.Windows.Forms.NumericUpDown playerAlterationNumericUpDown;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.NumericUpDown playerMarksmanNumericUpDown;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.NumericUpDown playerLightArmorNumericUpDown;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.NumericUpDown playerHeavyArmorNumericUpDown;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown playerSmithingNumericUpDown;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown playerBlockNumericUpDown;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown playerTwoHandedNumericUpDown;
        private System.Windows.Forms.NumericUpDown playerOneHandedNumericUpDown;
        private System.Windows.Forms.NumericUpDown playerMagickaNumericUpDown;
        private System.Windows.Forms.NumericUpDown playerStaminaNumericUpDown;
        private System.Windows.Forms.NumericUpDown playerHealthNumericUpDown;
        private System.Windows.Forms.NumericUpDown playerDragonSoulsNumericUpDown;
        private System.Windows.Forms.NumericUpDown playerCarryWeightNumericUpDown;
        private System.Windows.Forms.NumericUpDown playerGoldNumericUpDown;
        private System.Windows.Forms.TabPage ingredientsTabPage;
        private System.Windows.Forms.TabPage foodAndPotionsTabPage;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.CheckedListBox ingredientsCheckedListBox;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.CheckedListBox foodAndPotionsCheckedListBox;
        private System.Windows.Forms.ToolStripMenuItem exportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportProfileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportCurrentSessionMenuItem;
        private System.Windows.Forms.TabPage perkTabPage;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.CheckedListBox perkCheckBoxList;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.ToolStripMenuItem loadPerksListMenuItem;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.ToolStripMenuItem generateStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generatePerkListMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TabPage miscTabPage;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.CheckedListBox miscCheckedListBox;
        private System.Windows.Forms.TabPage shoutsTabPage;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.CheckedListBox shoutsCheckedListBox;
        private System.Windows.Forms.ToolStripMenuItem buildOverloadProfileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadOverloadMenuItem;
        private System.Windows.Forms.TabPage booksAndScrollsTabPage;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.CheckedListBox booksAndScrollsCheckedListBox;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.Label label54;
    }
}

