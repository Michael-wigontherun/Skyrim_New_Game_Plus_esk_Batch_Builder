using SkyrimBatchBuilder.SkyrimReferences;
using System;
using System.Windows.Forms;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace SkyrimBatchBuilder
{
    public partial class MainForm : Form
    {
        public ReferenceLists itemsList = new ReferenceLists();
        public List<Perk> perksList = new List<Perk>();
        public MainForm()
        {
            InitializeComponent();

            if (!File.Exists("ProfileCreation.log"))
            {
                File.Create("ProfileCreation.log").Close();
            }

            WriteLN("Hello World!", DebugMode.Enabled);

            
        }

        //writes to console and log
        protected void WriteLN(string output, DebugMode modeReqirment = DebugMode.Enabled)
        {
            if (String.IsNullOrEmpty(ConfigurationManager.AppSettings["debugmode"]) ||
                !Int32.TryParse(ConfigurationManager.AppSettings["debugmode"], out _))
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                config.AppSettings.Settings.Add("debugmode", 1 + "");
                config.Save(ConfigurationSaveMode.Minimal);
                ConfigurationManager.RefreshSection("appSettings");
            }
            if (Int32.Parse(ConfigurationManager.AppSettings["debugmode"]) <= (int)modeReqirment)
            {
                console.AppendText(output + Environment.NewLine);
            }
            using (StreamWriter log = File.AppendText("ProfileCreation.log"))
            {
                log.WriteLine(output);
            }
        }

        #region Form item events region. Add all Menu item events here.
        //form fully loaded Event
        private void MainForm_Shown(object sender, EventArgs e)
        {
            SSEEditCheck();
        }
        //exit menu item click
        private void exit(object sender, EventArgs e) 
        {
            Application.Exit();
        }

        //settings menu item click
        private void settingsClick(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings();
            if(settingsForm.ShowDialog() == DialogResult.Cancel && !File.Exists(ConfigurationManager.AppSettings["sseedit"] + "\\SSEEdit.exe"))
            {
                this.Close();
            }
            else
            {
                SSEEditCheck();
            }
        }

        private void SSEEditCheck()
        {
            if (!File.Exists(ConfigurationManager.AppSettings["sseedit"] + "\\SSEEdit.exe"))
            {
                WriteLN("Set SSE Edit path in settings.", DebugMode.Disabled);
                settingsClick(null, null);
            }
        }

        //build item list menu item click
        private void GenerateItemListsMenuItem_Click(object sender, EventArgs e)
        {
            Process _ExportItems = new Process();
            _ExportItems.StartInfo.FileName = ConfigurationManager.AppSettings["sseedit"] + "\\SSEEdit.exe";
            _ExportItems.StartInfo.Arguments = "-script:\"_ExportItems.pas\" -nobuildrefs";
            _ExportItems.StartInfo.WorkingDirectory = ConfigurationManager.AppSettings["sseedit"];
            _ExportItems.EnableRaisingEvents = true;
            WriteLN("Generateing item lists.", DebugMode.Disabled);
            _ExportItems.Start();
            _ExportItems.WaitForExit();
            WriteLN("Item lists generated. Please build references under the build menu.", DebugMode.Disabled);
        }

        //Generates the perk list from xedit
        private void GeneratePerkListMenuItem_Click(object sender, EventArgs e)
        {
            Process _ExportPerks = new Process();
            _ExportPerks.StartInfo.FileName = ConfigurationManager.AppSettings["sseedit"] + "\\SSEEdit.exe";
            _ExportPerks.StartInfo.Arguments = "-script:\"_ExportPerks.pas\" -nobuildrefs";
            _ExportPerks.StartInfo.WorkingDirectory = ConfigurationManager.AppSettings["sseedit"];
            _ExportPerks.EnableRaisingEvents = true;
            WriteLN("Generateing perk lists.", DebugMode.Disabled);
            _ExportPerks.Start();
            _ExportPerks.WaitForExit();
            WriteLN("Perk lists generated. It is recommended to manually edit the perks list before import, even if using the perk organizer.", DebugMode.Disabled);
            if (File.Exists(".\\PerkOrgonizer\\SkyrimBatchBuilderPerkOrderBuilder.exe"))
            {
                OkNoDialogForm okNoDialogForm = new OkNoDialogForm("Would you like to use the Exparamental perk orgonizer?");
                if (okNoDialogForm.ShowDialog() == DialogResult.OK)
                {
                    Process SkyrimBatchBuilderPerkOrderBuilder = new Process();
                    SkyrimBatchBuilderPerkOrderBuilder.StartInfo.FileName = ".\\PerkOrgonizer\\SkyrimBatchBuilderPerkOrderBuilder.exe";
                    SkyrimBatchBuilderPerkOrderBuilder.StartInfo.Arguments = $"{ConfigurationManager.AppSettings["sseedit"]}\\BatchBuilder\\xEditOutput\\PerksList.csv";
                    SkyrimBatchBuilderPerkOrderBuilder.StartInfo.WorkingDirectory = ".\\PerkOrgonizer\\";
                    SkyrimBatchBuilderPerkOrderBuilder.EnableRaisingEvents = true;
                    SkyrimBatchBuilderPerkOrderBuilder.Start();
                    SkyrimBatchBuilderPerkOrderBuilder.WaitForExit();
                }
            }
            new MessageBoxForm($"It is recommended to manually edit the perks list before import, even if using the perk organizer.{Environment.NewLine}Just press ok when ready.").ShowDialog();

        }

        //build references menu item click
        private void BuildReferencesMenuItem_Click(object sender, EventArgs e)
        {
            ReadLoadOrder readLoadOrder = new ReadLoadOrder();
            WriteLN("Reference builder opened.", DebugMode.Disabled);
            readLoadOrder.ShowDialog();
            WriteLN("Reference builder closed.", DebugMode.Disabled);
        }

        //builds and ouputs the profile
        private void buildProfileMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(profileNameTextBox.Text))
            {
                References.ExportProfile(BuildFullProfile(), profileNameTextBox.Text);
                WriteLN($"Profile {profileNameTextBox.Text} writen to profile folder.", DebugMode.Disabled);
            }
            else
            {
                WriteLN("Please enter profile name before profile build.", DebugMode.Disabled);
            }
        }

        //load references menu item click
        private void loadReferencesMenuItem_Click(object sender, EventArgs e)
        {
            itemsList = References.ImportItemList();
            ShowLoadOrder();
            LoadTabs();
            WriteLN("References loaded.", DebugMode.Disabled);
        }

        //prints load order to load order text box
        private void ShowLoadOrder()
        {
            loadOrderTextBox.Text = "";
            foreach (Plugin plugin in itemsList.LoadOrder)
            {
                loadOrderTextBox.AppendText(plugin.ToString() + Environment.NewLine);
            }
        }

        //refreshes the checkboxlist with its data scource
        private void refreshView(ListBox checkboxlist, object dataSource)
        {
            CurrencyManager cm = (CurrencyManager)checkboxlist.BindingContext[dataSource];
            cm.Refresh();
        }
        
        //loads a saved profile
        private void LoadProfile(string profileFullPath)
        {
            Profile profile = References.ImportProfile(profileFullPath);
            profileNameTextBox.Text = profile.ProfileName;
            playerLevelNumericUpDown.Value = profile.Level;
            playerHealthNumericUpDown.Value = profile.Health;
            playerStaminaNumericUpDown.Value = profile.Stamina;
            playerMagickaNumericUpDown.Value = profile.Magicka;
            playerCarryWeightNumericUpDown.Value = profile.Carryweight;
            playerDragonSoulsNumericUpDown.Value = profile.DragonSouls;
            playerGoldNumericUpDown.Value = profile.Gold;
            playerOneHandedNumericUpDown.Value = profile.OneHanded;
            playerTwoHandedNumericUpDown.Value = profile.TwoHanded;
            playerBlockNumericUpDown.Value = profile.Block;
            playerSmithingNumericUpDown.Value = profile.Smithing;
            playerHeavyArmorNumericUpDown.Value = profile.HeavyArmor;
            playerLightArmorNumericUpDown.Value = profile.LightArmor;
            playerMarksmanNumericUpDown.Value = profile.Marksman;
            playerAlterationNumericUpDown.Value = profile.Alteration;
            playerConjurationNumericUpDown.Value = profile.Conjuration;
            playerDestructionNumericUpDown.Value = profile.Destruction;
            playerEnchantingNumericUpDown.Value = profile.Enchanting;
            playerIllusionNumericUpDown.Value = profile.Illusion;
            playerRestorationNumericUpDown.Value = profile.Restoration;
            playerAlchemyNumericUpDown.Value = profile.Alchemy;
            playerLockpickingNumericUpDown.Value = profile.Lockpicking;
            playerPickpocketNumericUpDown.Value = profile.Pickpocket;
            playerSneakNumericUpDown.Value = profile.Sneak;
            playerSpeechcraftNumericUpDown.Value = profile.Speechcraft;
            ProfileCheckListImport(profile, true);
            
        }

        //loads a profile to edit
        private void loadProfileMenuItem_Click(object sender, EventArgs e)
        {
            string profileFullPath = getProfile();
            if (!profileFullPath.Equals("Failed"))
            {
                LoadProfile(profileFullPath);
            }
            else
            {
                WriteLN("Failed to load a profile.", DebugMode.Disabled);
            }
        }

        //opens file dialog and gets the full path of a profile
        private string getProfile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = $"{Directory.GetCurrentDirectory()}{ConfigurationManager.AppSettings["profilesfolder"].Replace(".", "")}";
                openFileDialog.Filter = "Profiles files (*.json)|*.json";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName;
                }
            }
            return "Failed";
        }

        //opens export profile window
        private void exportProfileMenuItem_Click(object sender, EventArgs e)
        {
            string profileFullPath = getProfile();
            if (!profileFullPath.Equals("Failed"))
            {
                WriteLN("Loaded profile export.", DebugMode.Disabled);
                ExportProfile exportProfile = new ExportProfile(profileFullPath);
                exportProfile.ShowDialog();
            }
            else
            {
                WriteLN("Failed to load a profile.", DebugMode.Disabled);
            }
        }
        
        //exports current sessions lists and sends it to the export window
        private void exportCurrentSessionMenuItem_Click(object sender, EventArgs e)
        {
            WriteLN("Loaded profile export.", DebugMode.Disabled);
            ExportProfile exportProfile = new ExportProfile(BuildFullProfile());
            exportProfile.ShowDialog();
        }

        //load perks from perk list file
        private void loadPerksListMenuItem_Click(object sender, EventArgs e)
        {
            string perkListFullPath = getPerkList();
            if (!perkListFullPath.Equals("Failed"))
            {
                perksList = References.ImportPerksList(perkListFullPath);
                ((ListBox)perkCheckBoxList).DataSource = perksList;
                ((ListBox)perkCheckBoxList).DisplayMember = "ListString";
                refreshView(((ListBox)perkCheckBoxList), perksList);
                WriteLN("Perk list Loaded.", DebugMode.Disabled);
            }
            else
            {
                WriteLN("Failed to load a Perk List.", DebugMode.Disabled);
            }
        }

        //opens file dialog and gets the full path of a PerkList
        private string getPerkList()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = $"{Directory.GetCurrentDirectory()}{ConfigurationManager.AppSettings["resourcesfolder"].Replace(".", "")}PerkList";
                openFileDialog.Filter = "PerksList (*_PerksList.json)|*_PerksList.json";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName;
                }
            }
            return "Failed";
        }

        //Unchecks all items in the checklistbox sent
        private void UncheckAllItems(CheckedListBox checkedListBox)
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, false);
            }
        }

        //builds a profile without AV values ment to be used to check a large amount to boxes at once
        private void buildOverloadProfileMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(profileNameTextBox.Text))
            {
                References.ExportOverloadProfile(BuildProfile(), profileNameTextBox.Text);
                WriteLN($"Profile {profileNameTextBox.Text} writen to overload profile folder.", DebugMode.Disabled);
            }
            else
            {
                WriteLN("Please enter overload profile name before profile build.", DebugMode.Disabled);
            }
        }

        //loads a profile to overload the lists
        private void loadOverloadMenuItem_Click(object sender, EventArgs e)
        {
            string profileFullPath = getOverloadProfile();
            if (!profileFullPath.Equals("Failed"))
            {
                ProfileCheckListImport(References.ImportOverloadProfile(profileFullPath), false);
            }
            else
            {
                WriteLN("Failed to load a overload profile.", DebugMode.Disabled);
            }
        }

        //opens file dialog and gets the full path of a Overload profile
        private string getOverloadProfile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = $"{Directory.GetCurrentDirectory()}{ConfigurationManager.AppSettings["profilesfolder"].Replace(".", "")}Overload\\";
                openFileDialog.Filter = "Profiles files (*.json)|*.json";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName;
                }
            }
            return "Failed";
        }

        //calls buildProfile to collect all item lists and then adds AVs to a profile variable
        private Profile BuildFullProfile()
        {
            Profile profile = BuildProfile();
            profile.Level = (int)playerLevelNumericUpDown.Value;
            profile.Health = (int)playerHealthNumericUpDown.Value;
            profile.Stamina = (int)playerStaminaNumericUpDown.Value;
            profile.Magicka = (int)playerMagickaNumericUpDown.Value;
            profile.Carryweight = (int)playerCarryWeightNumericUpDown.Value;
            profile.DragonSouls = (int)playerDragonSoulsNumericUpDown.Value;
            profile.Gold = (int)playerGoldNumericUpDown.Value;
            profile.OneHanded = (int)playerOneHandedNumericUpDown.Value;
            profile.TwoHanded = (int)playerTwoHandedNumericUpDown.Value;
            profile.Block = (int)playerBlockNumericUpDown.Value;
            profile.Smithing = (int)playerSmithingNumericUpDown.Value;
            profile.HeavyArmor = (int)playerHeavyArmorNumericUpDown.Value;
            profile.LightArmor = (int)playerLightArmorNumericUpDown.Value;
            profile.Marksman = (int)playerMarksmanNumericUpDown.Value;
            profile.Alteration = (int)playerAlterationNumericUpDown.Value;
            profile.Conjuration = (int)playerConjurationNumericUpDown.Value;
            profile.Destruction = (int)playerDestructionNumericUpDown.Value;
            profile.Enchanting = (int)playerEnchantingNumericUpDown.Value;
            profile.Illusion = (int)playerIllusionNumericUpDown.Value;
            profile.Restoration = (int)playerRestorationNumericUpDown.Value;
            profile.Alchemy = (int)playerAlchemyNumericUpDown.Value;
            profile.Lockpicking = (int)playerLockpickingNumericUpDown.Value;
            profile.Pickpocket = (int)playerPickpocketNumericUpDown.Value;
            profile.Sneak = (int)playerSneakNumericUpDown.Value;
            profile.Speechcraft = (int)playerSpeechcraftNumericUpDown.Value;

            return profile;
        }

        #endregion

        #region ChecklistBox stuff. Put all things that need to use all the check lists here.

        //collects all item lists profile variable
        private Profile BuildProfile()
        {
            Profile profile = new Profile();
            profile.ProfileName = profileNameTextBox.Text.ToString();

            for (int i = 0; i < perkCheckBoxList.Items.Count; i++)
            {
                if (perkCheckBoxList.GetItemChecked(i))
                {
                    Perk perk = (Perk)perkCheckBoxList.Items[i];
                    if (!profile.Dependencies.Contains(perk.pluginName))
                    {
                        profile.Dependencies.Add(perk.pluginName);
                    }
                    profile.PerkList.Add((Perk)perkCheckBoxList.Items[i]);
                }
            }

            for (int i = 0; i < weaponCheckBoxList.Items.Count; i++)
            {
                if (weaponCheckBoxList.GetItemChecked(i))
                {
                    Item item = (Item)weaponCheckBoxList.Items[i];
                    if (!profile.Dependencies.Contains(item.pluginName))
                    {
                        profile.Dependencies.Add(item.pluginName);
                    }
                    profile.Weapons.Add(item);
                }
            }

            for (int i = 0; i < armorCheckBoxList.Items.Count; i++)
            {
                if (armorCheckBoxList.GetItemChecked(i))
                {
                    Item item = (Item)armorCheckBoxList.Items[i];
                    if (!profile.Dependencies.Contains(item.pluginName))
                    {
                        profile.Dependencies.Add(item.pluginName);
                    }
                    profile.Armor.Add(item);
                }
            }

            for (int i = 0; i < spellsCheckBoxList.Items.Count; i++)
            {
                if (spellsCheckBoxList.GetItemChecked(i))
                {
                    Item item = (Item)spellsCheckBoxList.Items[i];
                    if (!profile.Dependencies.Contains(item.pluginName))
                    {
                        profile.Dependencies.Add(item.pluginName);
                    }
                    profile.Spells.Add(item);
                }
            }

            for (int i = 0; i < foodAndPotionsCheckedListBox.Items.Count; i++)
            {
                if (foodAndPotionsCheckedListBox.GetItemChecked(i))
                {
                    Item item = (Item)foodAndPotionsCheckedListBox.Items[i];
                    if (!profile.Dependencies.Contains(item.pluginName))
                    {
                        profile.Dependencies.Add(item.pluginName);
                    }
                    profile.FoodAndPotions.Add(item);
                }
            }

            for (int i = 0; i < ingredientsCheckedListBox.Items.Count; i++)
            {
                if (ingredientsCheckedListBox.GetItemChecked(i))
                {
                    Item item = (Item)ingredientsCheckedListBox.Items[i];
                    if (!profile.Dependencies.Contains(item.pluginName))
                    {
                        profile.Dependencies.Add(item.pluginName);
                    }
                    profile.Ingredients.Add(item);
                }
            }

            for (int i = 0; i < miscCheckedListBox.Items.Count; i++)
            {
                if (miscCheckedListBox.GetItemChecked(i))
                {
                    Item item = (Item)miscCheckedListBox.Items[i];
                    if (!profile.Dependencies.Contains(item.pluginName))
                    {
                        profile.Dependencies.Add(item.pluginName);
                    }
                    profile.Misc.Add(item);
                }
            }

            for (int i = 0; i < shoutsCheckedListBox.Items.Count; i++)
            {
                if (shoutsCheckedListBox.GetItemChecked(i))
                {
                    Item item = (Item)shoutsCheckedListBox.Items[i];
                    if (!profile.Dependencies.Contains(item.pluginName))
                    {
                        profile.Dependencies.Add(item.pluginName);
                    }
                    profile.Shouts.Add(item);
                }
            }

            for (int i = 0; i < booksAndScrollsCheckedListBox.Items.Count; i++)
            {
                if (booksAndScrollsCheckedListBox.GetItemChecked(i))
                {
                    Item item = (Item)booksAndScrollsCheckedListBox.Items[i];
                    if (!profile.Dependencies.Contains(item.pluginName))
                    {
                        profile.Dependencies.Add(item.pluginName);
                    }
                    profile.Books.Add(item);
                }
            }

            return profile;
        }

        //loads the check lists from a profile
        private void ProfileCheckListImport(Profile profile, bool uncheckLists)
        {
            if (uncheckLists)
            {
                UncheckAllItems(perkCheckBoxList);
                UncheckAllItems(weaponCheckBoxList);
                UncheckAllItems(armorCheckBoxList);
                UncheckAllItems(spellsCheckBoxList);
                UncheckAllItems(miscCheckedListBox);
                UncheckAllItems(foodAndPotionsCheckedListBox);
                UncheckAllItems(ingredientsCheckedListBox);
                UncheckAllItems(shoutsCheckedListBox);
                UncheckAllItems(booksAndScrollsCheckedListBox);
            }
            for (int i = 0; i < perkCheckBoxList.Items.Count; i++)
            {
                foreach (Perk item in profile.PerkList)
                {
                    if (((Perk)perkCheckBoxList.Items[i]).Name.Equals(item.Name))
                    {
                        perkCheckBoxList.SetItemChecked(i, true);
                    }
                }
            }
            for (int i = 0; i < weaponCheckBoxList.Items.Count; i++)
            {
                foreach (Item item in profile.Weapons)
                {
                    if (((Item)weaponCheckBoxList.Items[i]).EditorID.Equals(item.EditorID))
                    {
                        weaponCheckBoxList.SetItemChecked(i, true);
                    }
                }
            }
            for (int i = 0; i < armorCheckBoxList.Items.Count; i++)
            {
                foreach (Item item in profile.Armor)
                {
                    if (((Item)armorCheckBoxList.Items[i]).EditorID.Equals(item.EditorID))
                    {
                        armorCheckBoxList.SetItemChecked(i, true);
                    }
                }
            }
            for (int i = 0; i < spellsCheckBoxList.Items.Count; i++)
            {
                foreach (Item item in profile.Armor)
                {
                    if (((Item)spellsCheckBoxList.Items[i]).EditorID.Equals(item.EditorID))
                    {
                        spellsCheckBoxList.SetItemChecked(i, true);
                    }
                }
            }
            for (int i = 0; i < ingredientsCheckedListBox.Items.Count; i++)
            {
                foreach (Item item in profile.Ingredients)
                {
                    if (((Item)ingredientsCheckedListBox.Items[i]).EditorID.Equals(item.EditorID))
                    {
                        ingredientsCheckedListBox.SetItemChecked(i, true);
                    }
                }
            }
            for (int i = 0; i < foodAndPotionsCheckedListBox.Items.Count; i++)
            {
                foreach (Item item in profile.FoodAndPotions)
                {
                    if (((Item)foodAndPotionsCheckedListBox.Items[i]).EditorID.Equals(item.EditorID))
                    {
                        foodAndPotionsCheckedListBox.SetItemChecked(i, true);
                    }
                }
            }
            for (int i = 0; i < miscCheckedListBox.Items.Count; i++)
            {
                foreach (Item item in profile.Misc)
                {
                    if (((Item)miscCheckedListBox.Items[i]).EditorID.Equals(item.EditorID))
                    {
                        miscCheckedListBox.SetItemChecked(i, true);
                    }
                }
            }
            for (int i = 0; i < shoutsCheckedListBox.Items.Count; i++)
            {
                foreach (Item item in profile.Shouts)
                {
                    if (((Item)shoutsCheckedListBox.Items[i]).EditorID.Equals(item.EditorID))
                    {
                        shoutsCheckedListBox.SetItemChecked(i, true);
                    }
                }
            }
            for (int i = 0; i < booksAndScrollsCheckedListBox.Items.Count; i++)
            {
                foreach (Item item in profile.Books)
                {
                    if (((Item)booksAndScrollsCheckedListBox.Items[i]).EditorID.Equals(item.EditorID))
                    {
                        booksAndScrollsCheckedListBox.SetItemChecked(i, true);
                    }
                }
            }

        }

        //loads references to each tab
        private void LoadTabs()
        {
            ((ListBox)perkCheckBoxList).DataSource = perksList;
            ((ListBox)perkCheckBoxList).DisplayMember = "ListString";
            refreshView(((ListBox)perkCheckBoxList), perksList);

            ((ListBox)weaponCheckBoxList).DataSource = itemsList.Weapons;
            ((ListBox)weaponCheckBoxList).DisplayMember = "ListString";
            refreshView(((ListBox)weaponCheckBoxList), itemsList.Weapons);

            ((ListBox)armorCheckBoxList).DataSource = itemsList.Armor;
            ((ListBox)armorCheckBoxList).DisplayMember = "ListString";
            refreshView(((ListBox)armorCheckBoxList), itemsList.Armor);

            ((ListBox)spellsCheckBoxList).DataSource = itemsList.Spells;
            ((ListBox)spellsCheckBoxList).DisplayMember = "ListString";
            refreshView(((ListBox)spellsCheckBoxList), itemsList.Spells);

            ((ListBox)ingredientsCheckedListBox).DataSource = itemsList.Ingredients;
            ((ListBox)ingredientsCheckedListBox).DisplayMember = "ListString";
            refreshView(((ListBox)ingredientsCheckedListBox), itemsList.Ingredients);

            ((ListBox)foodAndPotionsCheckedListBox).DataSource = itemsList.FoodAndPotions;
            ((ListBox)foodAndPotionsCheckedListBox).DisplayMember = "ListString";
            refreshView(((ListBox)foodAndPotionsCheckedListBox), itemsList.FoodAndPotions);

            ((ListBox)miscCheckedListBox).DataSource = itemsList.Misc;
            ((ListBox)miscCheckedListBox).DisplayMember = "ListString";
            refreshView(((ListBox)miscCheckedListBox), itemsList.Misc);

            ((ListBox)shoutsCheckedListBox).DataSource = itemsList.Shouts;
            ((ListBox)shoutsCheckedListBox).DisplayMember = "ListString";
            refreshView(((ListBox)shoutsCheckedListBox), itemsList.Shouts);

            ((ListBox)booksAndScrollsCheckedListBox).DataSource = itemsList.Books;
            ((ListBox)booksAndScrollsCheckedListBox).DisplayMember = "ListString";
            refreshView(((ListBox)booksAndScrollsCheckedListBox), itemsList.Books);
        }

        //sorts the item lists
        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            switch (comboBox.SelectedIndex)
            {
                case 0:
                    itemsList.Weapons = itemsList.Weapons.OrderBy(o => o.Name).ToList();
                    itemsList.Armor = itemsList.Armor.OrderBy(o => o.Name).ToList();
                    itemsList.Spells = itemsList.Spells.OrderBy(o => o.Name).ToList();
                    itemsList.FoodAndPotions = itemsList.FoodAndPotions.OrderBy(o => o.Name).ToList();
                    itemsList.Ingredients = itemsList.Ingredients.OrderBy(o => o.Name).ToList();
                    itemsList.Misc = itemsList.Misc.OrderBy(o => o.Name).ToList();
                    itemsList.Shouts = itemsList.Shouts.OrderBy(o => o.Name).ToList();
                    itemsList.Books = itemsList.Books.OrderBy(o => o.Name).ToList();
                    LoadTabs();
                    break;
                case 1:
                    itemsList.Weapons = itemsList.Weapons.OrderBy(o => o.FormID).ToList();
                    itemsList.Armor = itemsList.Armor.OrderBy(o => o.FormID).ToList();
                    itemsList.Spells = itemsList.Spells.OrderBy(o => o.FormID).ToList();
                    itemsList.FoodAndPotions = itemsList.FoodAndPotions.OrderBy(o => o.FormID).ToList();
                    itemsList.Ingredients = itemsList.Ingredients.OrderBy(o => o.FormID).ToList();
                    itemsList.Misc = itemsList.Misc.OrderBy(o => o.FormID).ToList();
                    itemsList.Shouts = itemsList.Shouts.OrderBy(o => o.FormID).ToList();
                    itemsList.Books = itemsList.Books.OrderBy(o => o.FormID).ToList();
                    LoadTabs();
                    break;
                case 2:
                    itemsList.Weapons = itemsList.Weapons.OrderBy(o => o.Type).ToList();
                    itemsList.Armor = itemsList.Armor.OrderBy(o => o.Type).ToList();
                    itemsList.Spells = itemsList.Spells.OrderBy(o => o.Type).ToList();
                    itemsList.FoodAndPotions = itemsList.FoodAndPotions.OrderBy(o => o.Type).ToList();
                    itemsList.Ingredients = itemsList.Ingredients.OrderBy(o => o.Type).ToList();
                    itemsList.Misc = itemsList.Misc.OrderBy(o => o.Type).ToList();
                    itemsList.Books = itemsList.Books.OrderBy(o => o.Type).ToList();
                    LoadTabs();
                    break;
            }
        }

        #endregion


    }
}

