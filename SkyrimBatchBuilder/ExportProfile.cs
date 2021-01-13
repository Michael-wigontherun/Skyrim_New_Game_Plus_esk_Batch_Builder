using SkyrimBatchBuilder.SkyrimReferences;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SkyrimBatchBuilder
{
    public partial class ExportProfile : Form
    {
        Profile profile;
        private SortedDictionary<string, Plugin> plugins = new SortedDictionary<string, Plugin>();

        public ExportProfile(string profileFullPath)
        {
            InitializeComponent();
            profile = References.ImportProfile(profileFullPath);
            FormatDataGrids();
            if (!File.Exists("ProfileBatBuilder.log"))
            {
                File.Create("ProfileBatBuilder.log").Close();
            }
            WriteLN("Hello World!", DebugMode.Enabled);
        }

        public ExportProfile(Profile unsavedProfile)
        {
            InitializeComponent();
            profile = unsavedProfile;
            FormatDataGrids();
            if (!File.Exists("ProfileBatBuilder.log"))
            {
                File.Create("ProfileBatBuilder.log").Close();
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
            using (StreamWriter log = File.AppendText("ProfileBatBuilder.log"))
            {
                log.WriteLine(output);
            }
        }

        #region Form item events region. Add all Menu item events here.

        private void exitStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void existingStripMenuItem_Click(object sender, EventArgs e)
        {
            plugins.Clear();
            plugins = References.ImportItemList().plugins;
            if (ValidLoadOrderWithProfile())
            {
                FixFormIDs();
            }
        }

        private void newStripMenuItem_Click(object sender, EventArgs e)
        {
            Process _ExportItems = new Process();
            _ExportItems.StartInfo.FileName = ConfigurationManager.AppSettings["sseedit"] + "\\SSEEdit.exe";
            _ExportItems.StartInfo.Arguments = "-script:\"_ExportLoadOrder.pas\" -nobuildrefs";
            _ExportItems.StartInfo.WorkingDirectory = ConfigurationManager.AppSettings["sseedit"];
            _ExportItems.EnableRaisingEvents = true;
            WriteLN("xEdit building load order.", DebugMode.Disabled);
            _ExportItems.Start();
            _ExportItems.WaitForExit();
            plugins.Clear();
            if (File.Exists($"{ConfigurationManager.AppSettings["sseedit"]}\\BatchBuilder\\xEditOutput\\loadorder.csv"))
            {
                WriteLN("Load order built.", DebugMode.Disabled);
                WriteLN("Reading \"Loadorder.csv\".", DebugMode.Disabled);
                using (var reader = new StreamReader($"{ConfigurationManager.AppSettings["sseedit"]}\\BatchBuilder\\xEditOutput\\loadorder.csv"))
                {
                    while (!reader.EndOfStream)
                    {
                        string s = reader.ReadLine();
                        WriteLN(s, DebugMode.Enabled);
                        Plugin plugin = new Plugin(s);
                        plugins.Add(plugin.pluginName, plugin);
                    }
                }
                WriteLN("Loaded \"loadorder.csv\".", DebugMode.Disabled);
                if (ValidLoadOrderWithProfile())
                {
                    FixFormIDs();
                }
            }
            else
            {
                WriteLN("\"Loadorder.csv\" not found.", DebugMode.Disabled);
            }

        }

        private void buildAllMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidLoadOrderWithProfile())
            {
                BuildBatch(false);
            }
        }

        private void buildOnlyItemsMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidLoadOrderWithProfile())
            {
                BuildBatch(true);
            }
        }

        private bool ValidLoadOrderWithProfile()
        {
            if(plugins.Count < 1)
            {
                WriteLN("Load order missing.", DebugMode.Disabled);
                return false;
            }
            bool check = true;
            foreach (string s in profile.Dependencies)
            {
                if (!plugins.ContainsKey(s))
                {
                    check = false;
                    WriteLN("Missing plugin: " + s, DebugMode.Disabled);
                }
            }
            return check;
        }

        #endregion

        #region Profile stuff. Put all things that need to import and export profiles.

        //add all dataview grid formating here
        private void FormatDataGrids()
        {
            weaponsDataGrid.DataSource = profile.Weapons;
            FormatDataGrid(weaponsDataGrid);

            armorDataGridView.DataSource = profile.Armor;
            FormatDataGrid(armorDataGridView);

            ingredientsDataGridView.DataSource = profile.Ingredients;
            FormatDataGrid(ingredientsDataGridView);

            foodAndPotionsDataGridView.DataSource = profile.FoodAndPotions;
            FormatDataGrid(foodAndPotionsDataGridView);

            booksDataGridView.DataSource = profile.Books;
            FormatDataGrid(booksDataGridView);

            miscDataGridView.DataSource = profile.Misc;
            FormatDataGrid(miscDataGridView);
        }

        //formats the sizes of item columns
        private void FormatDataGrid(DataGridView dataGridView)
        {
            dataGridView.Columns["pluginName"].ReadOnly = true;
            dataGridView.Columns["pluginName"].Width = 120;
            dataGridView.Columns["FormID"].ReadOnly = true;
            dataGridView.Columns["FormID"].Width = 70;
            dataGridView.Columns["EditorID"].ReadOnly = true;
            dataGridView.Columns["EditorID"].Width = 190;
            dataGridView.Columns["Name"].ReadOnly = true;
            dataGridView.Columns["Name"].Width = 160;
            dataGridView.Columns["Type"].ReadOnly = true;
            dataGridView.Columns["Type"].Width = 70;
            dataGridView.Columns["ListString"].ReadOnly = true;
            dataGridView.Columns["ListString"].Visible = false;
        }

        //fixes all form ids
        private void FixFormIDs()
        {
            WriteLN("Fixing FormIDs", DebugMode.Disabled);
            for (int i = 0; i < profile.Shouts.Count; i++)
            {
                profile.Shouts[i].FixFormID(plugins.GetValueOrDefault(profile.FoodAndPotions[i].pluginName).modIndex);
            }
            for (int i = 0; i < profile.Spells.Count; i++)
            {
                profile.Spells[i].FixFormID(plugins.GetValueOrDefault(profile.Spells[i].pluginName).modIndex);
            }
            for (int i = 0; i < profile.PerkList.Count; i++)
            {
                profile.PerkList[i].FixFormID(plugins.GetValueOrDefault(profile.PerkList[i].pluginName).modIndex);
            }
            for (int i = 0; i < profile.Weapons.Count; i++)
            {
                profile.Weapons[i].FixFormID(plugins.GetValueOrDefault(profile.Weapons[i].pluginName).modIndex);
            }
            for (int i = 0; i < profile.Armor.Count; i++)
            {
                profile.Armor[i].FixFormID(plugins.GetValueOrDefault(profile.Armor[i].pluginName).modIndex);
            }
            for (int i = 0; i < profile.Ingredients.Count; i++)
            {
                profile.Ingredients[i].FixFormID(plugins.GetValueOrDefault(profile.Ingredients[i].pluginName).modIndex);
            }
            for (int i = 0; i < profile.FoodAndPotions.Count; i++)
            {
                profile.FoodAndPotions[i].FixFormID(plugins.GetValueOrDefault(profile.FoodAndPotions[i].pluginName).modIndex);
            }
            for (int i = 0; i < profile.Misc.Count; i++)
            {
                profile.Misc[i].FixFormID(plugins.GetValueOrDefault(profile.FoodAndPotions[i].pluginName).modIndex);
            }
            
            for (int i = 0; i < profile.Shouts.Count; i++)
            {
                profile.Books[i].FixFormID(plugins.GetValueOrDefault(profile.FoodAndPotions[i].pluginName).modIndex);
            }
            WriteLN("Fixed FormIDs", DebugMode.Disabled);
        }

        //outputs the profile to a bat file to be used by skyrims console
        private void BuildBatch(bool buildOnlyItems = false)
        {
            File.Create($"{ConfigurationManager.AppSettings["profilesfolder"]}Output\\{profile.ProfileName}.bat").Close();
            WriteLN($"Building batch {profile.ProfileName}", DebugMode.Disabled);
            using (StreamWriter profileOutput = File.AppendText($"{ConfigurationManager.AppSettings["profilesfolder"]}Output\\{profile.ProfileName}.bat"))
            {
                if (!buildOnlyItems)
                {
                    profileOutput.WriteLine($"player.setlevel {profile.Level};");
                    profileOutput.WriteLine($"player.modav health {profile.Health};");
                    profileOutput.WriteLine($"player.modav stamina {profile.Stamina};");
                    profileOutput.WriteLine($"player.modav magicka {profile.Magicka};");
                    profileOutput.WriteLine($"player.modav carryweight {profile.Carryweight};");
                    profileOutput.WriteLine($"player.forceav dragonsouls {profile.DragonSouls};");
                    profileOutput.WriteLine($"player.additem 0000000f {profile.Gold};");

                    profileOutput.WriteLine($"player.setav onehanded {profile.OneHanded};");
                    profileOutput.WriteLine($"player.setav twohanded {profile.TwoHanded};");
                    profileOutput.WriteLine($"player.setav block {profile.Block};");
                    profileOutput.WriteLine($"player.setav smithing {profile.Smithing};");
                    profileOutput.WriteLine($"player.setav heavyarmor {profile.HeavyArmor};");
                    profileOutput.WriteLine($"player.setav lightarmor {profile.LightArmor};");

                    profileOutput.WriteLine($"player.setav alteration {profile.Alteration};");
                    profileOutput.WriteLine($"player.setav conjuration {profile.Conjuration};");
                    profileOutput.WriteLine($"player.setav destruction {profile.Destruction};");
                    profileOutput.WriteLine($"player.setav enchanting {profile.Enchanting};");
                    profileOutput.WriteLine($"player.setav illusion {profile.Illusion};");
                    profileOutput.WriteLine($"player.setav restoration {profile.Restoration};");

                    profileOutput.WriteLine($"player.setav alchemy {profile.Alchemy};");
                    profileOutput.WriteLine($"player.setav lockpicking {profile.Lockpicking};");
                    profileOutput.WriteLine($"player.setav pickpocket {profile.Pickpocket};");
                    profileOutput.WriteLine($"player.setav sneak {profile.Sneak};");
                    profileOutput.WriteLine($"player.setav speechcraft {profile.Speechcraft};");
                    profileOutput.WriteLine($"player.setav marksman {profile.Marksman};");
                    foreach (Perk item in profile.PerkList)
                    {
                        profileOutput.WriteLine($"player.addperk {item.FormID};");
                    }
                    foreach (Item item in profile.Shouts)
                    {
                        profileOutput.WriteLine($"player.teachword {item.FormID};");
                    }
                    foreach (Item item in profile.Spells)
                    {
                        profileOutput.WriteLine($"player.addspell {item.FormID} {item.Amount};");
                    }
                }
                
                foreach (Item item in profile.Weapons)
                {
                    profileOutput.WriteLine($"player.additem {item.FormID} {item.Amount};");
                }
                foreach (Item item in profile.Armor)
                {
                    profileOutput.WriteLine($"player.additem {item.FormID} {item.Amount};");
                }
                foreach (Item item in profile.Ingredients)
                {
                    profileOutput.WriteLine($"player.additem {item.FormID} {item.Amount};");
                }
                foreach (Item item in profile.FoodAndPotions)
                {
                    profileOutput.WriteLine($"player.additem {item.FormID} {item.Amount};");
                }
                foreach (Item item in profile.Misc)
                {
                    profileOutput.WriteLine($"player.additem {item.FormID} {item.Amount};");
                }
                foreach (Item item in profile.Books)
                {
                    profileOutput.WriteLine($"player.additem {item.FormID} {item.Amount};");
                }
                WriteLN("Batch outputed to: ");
                WriteLN($"     {Directory.GetCurrentDirectory()}{ConfigurationManager.AppSettings["profilesfolder"].Replace(".", "")}output\\{profile.ProfileName}.bat", DebugMode.Disabled);
                Process.Start("explorer.exe", $"{ConfigurationManager.AppSettings["profilesfolder"]}output");
            }
        }


        #endregion

        
    }
}
