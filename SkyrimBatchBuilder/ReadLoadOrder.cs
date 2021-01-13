using SkyrimBatchBuilder.SkyrimReferences;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SkyrimBatchBuilder
{
    public partial class ReadLoadOrder : Form
    {
        private ReferenceLists referenceList = new ReferenceLists();
        public ReadLoadOrder()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
            if (!File.Exists("ListReader.log"))
            {
                File.Create("ListReader.log").Close();
            }
            WriteLN("Hello World!", DebugMode.Enabled);
        }
        
        private void WriteLN(string output, DebugMode modeReqirment = DebugMode.Enabled)
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
            using (StreamWriter log = File.AppendText("ListReader.log"))
            {
                log.WriteLine(output);
            }
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buildAllListsMenuItem_Click(object sender, EventArgs e)
        {
            ImportNewItemList();
        }

        private void justLoadOrderMenuItem_Click(object sender, EventArgs e)
        {
            referenceList = References.ImportItemList();
            referenceList.plugins.Clear();
            ImportNewLoadOrder();
        }

        public void ImportNewLoadOrder()
        {
            if (File.Exists($"{ConfigurationManager.AppSettings["sseedit"]}\\BatchBuilder\\xEditOutput\\loadorder.csv"))
            {
                WriteLN("Reading \"Loadorder.csv\".", DebugMode.Disabled);
                using (var reader = new StreamReader($"{ConfigurationManager.AppSettings["sseedit"]}\\BatchBuilder\\xEditOutput\\loadorder.csv"))
                {
                    while (!reader.EndOfStream)
                    {
                        string s = reader.ReadLine();
                        WriteLN(s, DebugMode.Enabled);
                        Plugin plugin = new Plugin(s);
                        referenceList.plugins.Add(plugin.pluginName, plugin);
                        referenceList.LoadOrder.Add(plugin);
                    }
                }
                WriteLN("Loaded \"loadorder.csv\".", DebugMode.Disabled);
            }
            else
            {
                WriteLN("\"loadorder.csv\" was not detected.", DebugMode.Disabled);
            }
        }

        public bool IsValidFilter(string filter)
        {
            if (!filter.Equals(string.Empty) && (filter.Split(';').Length - 1) == 2 &&
                !filter.Equals(";;") && !filter.Equals("; ;") && !filter.Equals(".; ;") &&
                 filter.Substring(filter.IndexOf(';', filter.IndexOf(';') + 1)).Equals(";"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void GetAndFilterSpells()
        {
            if (File.Exists($"{ConfigurationManager.AppSettings["sseedit"]}\\BatchBuilder\\xEditOutput\\Spells.csv"))
            {

                WriteLN("Reading \"Spells.csv\".", DebugMode.Disabled);
                using (var reader = new StreamReader($"{ConfigurationManager.AppSettings["sseedit"]}\\BatchBuilder\\xEditOutput\\Spells.csv"))
                {
                    reader.ReadLine();
                    while (!reader.EndOfStream)
                    {
                        string s = reader.ReadLine();
                        Item item = new Item(s);
                        WriteLN(s, DebugMode.Enabled);
                        referenceList.Spells.Add(item);
                    }
                }
                WriteLN("Loaded \"Spells.csv\".", DebugMode.Disabled);

                WriteLN("Removeing duplicate spells.", DebugMode.Disabled);
                List<Item> spells = new List<Item>();
                spells.AddRange(referenceList.Spells);
                foreach (Item item in spells)
                {
                    Plugin plugin = new Plugin();
                    if (referenceList.plugins.TryGetValue(item.pluginName, out plugin))
                    {
                        if (item.FormID.IndexOf(plugin.modIndex) != 0)
                        {
                            WriteLN("Removing duplicate: " + item.ListString, DebugMode.Enabled);
                            referenceList.Spells.Remove(item);
                            WriteLN("Removed: " + (!referenceList.Spells.Contains(item)), DebugMode.Enabled);
                        }
                    }
                }
                WriteLN("Removeing duplicate spells.", DebugMode.Disabled);
                referenceList.Spells = referenceList.Spells.OrderBy(o => o.Name).ToList();
            }
        }

        public void GetAndFilterWeapons()
        {
            string type = "Weapons";
            if (File.Exists($"{ConfigurationManager.AppSettings["sseedit"]}\\BatchBuilder\\xEditOutput\\{type}.csv"))
            {

                WriteLN("Reading \"weapons.csv\".", DebugMode.Disabled);
                using (var reader = new StreamReader($"{ConfigurationManager.AppSettings["sseedit"]}\\BatchBuilder\\xEditOutput\\{type}.csv"))
                {
                    reader.ReadLine();
                    while (!reader.EndOfStream)
                    {
                        string s = reader.ReadLine();
                        WriteLN(s, DebugMode.Enabled);
                        referenceList.Weapons.Add(new Item(s));
                    }
                }
                WriteLN($"Loaded \"{type}.csv\".", DebugMode.Disabled);

                if (File.Exists($"{ConfigurationManager.AppSettings["resourcesfolder"]}{type}Filters.csv"))
                {
                    WriteLN($"Gathering {type} Filters.", DebugMode.Disabled);
                    List<ItemFilter> weaponFilters = new List<ItemFilter>();
                
                    using (var reader = new StreamReader($"{ ConfigurationManager.AppSettings["resourcesfolder"]}{type}Filters.csv"))
                    {
                        int filterCount = 1;
                        while (!reader.EndOfStream)
                        {
                            string s = reader.ReadLine();
                            WriteLN(s, DebugMode.Enabled);
                            if (IsValidFilter(s))
                            {
                                weaponFilters.Add(new ItemFilter(s));
                            }
                            else
                            {
                                WriteLN($"{type} filter at line {filterCount} not excepted.", DebugMode.Disabled);
                            }
                            filterCount++;
                        }
                    }
                    WriteLN($"{type} filters Gathered.", DebugMode.Disabled);

                    WriteLN($"Filtering {type}.", DebugMode.Disabled);
                    List<Item> weapons = new List<Item>();
                    weapons.AddRange(referenceList.Weapons);
                    foreach (Item item in weapons)
                    {

                        foreach (ItemFilter itemFilter in weaponFilters)
                        {
                            if (itemFilter.ShouldRemove(item))
                            {
                                WriteLN("Removing: " + item.ListString, DebugMode.Enabled);
                                referenceList.Weapons.Remove(item);
                                WriteLN("Removed: " + !referenceList.Weapons.Contains(item), DebugMode.Enabled);
                                break;
                            }
                        }
                    }
                    WriteLN($"{type} Filtered.", DebugMode.Disabled);
                    referenceList.Weapons = referenceList.Weapons.OrderBy(o => o.Name).ToList();
                }
                else
                {
                    WriteLN($"\"{type}Filters.csv\" not detected no filters applied to {type}.", DebugMode.Disabled);
                }

            }
            else
            {
                WriteLN($"\"{type}.csv\" not detected.", DebugMode.Disabled);
            }
        }

        public void GetAndFilterArmor()
        {
            string type = "Armor";
            if (File.Exists($"{ConfigurationManager.AppSettings["sseedit"]}\\BatchBuilder\\xEditOutput\\{type}.csv"))
            {
                WriteLN($"Reading \"{type}.csv\".", DebugMode.Disabled);
                using (var reader = new StreamReader($"{ConfigurationManager.AppSettings["sseedit"]}\\BatchBuilder\\xEditOutput\\{type}.csv"))
                {
                    reader.ReadLine();
                    while (!reader.EndOfStream)
                    {
                        string s = reader.ReadLine();
                        WriteLN(s, DebugMode.Enabled);
                        referenceList.Armor.Add(new Item(s));
                    }
                }
                WriteLN($"Loaded \"{type}.csv\".", DebugMode.Disabled);

                if (File.Exists($"{ConfigurationManager.AppSettings["resourcesfolder"]}{type}Filters.csv"))
                {
                    WriteLN($"Gathering {type} Filters.", DebugMode.Disabled);
                    List<ItemFilter> armorFilters = new List<ItemFilter>();

                    using (var reader = new StreamReader($"{ConfigurationManager.AppSettings["resourcesfolder"]}{type}Filters.csv"))
                    {
                        int filterCount = 1;
                        while (!reader.EndOfStream)
                        {
                            string s = reader.ReadLine();
                            WriteLN(s, DebugMode.Enabled);
                            if (IsValidFilter(s))
                            {
                                ItemFilter itemFilter = new ItemFilter(s);
                                armorFilters.Add(itemFilter);
                            }
                            else
                            {
                                WriteLN($"Armor filter at line {filterCount} not excepted.", DebugMode.Disabled);
                            }
                            filterCount++;
                        }
                    }
                    WriteLN($"{type} filters Gathered.", DebugMode.Disabled);
                    WriteLN($"Filtering {type}.", DebugMode.Disabled);
                    List<Item> armor = new List<Item>();
                    armor.AddRange(referenceList.Armor);
                    foreach (Item item in armor)
                    {
                        foreach (ItemFilter itemFilter in armorFilters)
                        {
                            if (itemFilter.ShouldRemove(item))
                            {
                                WriteLN("Removing: " + item.ListString, DebugMode.Enabled);
                                referenceList.Armor.Remove(item);
                                WriteLN("Removed: " + (!referenceList.Armor.Contains(item)), DebugMode.Enabled);
                                break;
                            }
                        }
                    }
                    WriteLN($"{type} Filtered.", DebugMode.Disabled);
                    referenceList.Armor = referenceList.Armor.OrderBy(o => o.Name).ToList();
                }
                else
                {
                    WriteLN($"\"{type}Filters.csv\" not detected no filters applied to {type}.", DebugMode.Disabled);
                }
            }
            else
            {
                WriteLN($"\"{type}.csv\" not detected.", DebugMode.Disabled);
            }
        }

        public void GetAndFilterMisc()
        {
            string type = "Misc";
            if (File.Exists($"{ConfigurationManager.AppSettings["sseedit"]}\\BatchBuilder\\xEditOutput\\{type}.csv"))
            {
                WriteLN("Reading \"Misc.csv\".", DebugMode.Disabled);
                using (var reader = new StreamReader($"{ConfigurationManager.AppSettings["sseedit"]}\\BatchBuilder\\xEditOutput\\{type}.csv"))
                {
                    reader.ReadLine();
                    while (!reader.EndOfStream)
                    {
                        string s = reader.ReadLine();
                        WriteLN(s, DebugMode.Enabled);
                        referenceList.Misc.Add(new Item(s));
                    }
                }
                WriteLN($"Loaded \"{type}Misc.csv\".", DebugMode.Disabled);

                if (File.Exists($"{ConfigurationManager.AppSettings["resourcesfolder"]}{type}Filters.csv"))
                {
                    WriteLN("Gathering Misc Filters.", DebugMode.Disabled);
                    List<ItemFilter> miscFilters = new List<ItemFilter>();

                    using (var reader = new StreamReader($"{ConfigurationManager.AppSettings["resourcesfolder"]}{type}Filters.csv"))
                    {
                        int filterCount = 1;
                        while (!reader.EndOfStream)
                        {
                            string s = reader.ReadLine();
                            WriteLN(s, DebugMode.Enabled);
                            if (IsValidFilter(s))
                            {
                                ItemFilter itemFilter = new ItemFilter(s);
                                miscFilters.Add(itemFilter);
                            }
                            else
                            {
                                WriteLN($"{type} filter at line {filterCount} not excepted.", DebugMode.Disabled);
                            }
                            filterCount++;
                        }
                    }
                    WriteLN($"{type} filters Gathered.", DebugMode.Disabled);
                    WriteLN($"Filtering {type}.", DebugMode.Disabled);
                    List<Item> misc = new List<Item>();
                    misc.AddRange(referenceList.Misc);
                    foreach (Item item in misc)
                    {
                        foreach (ItemFilter itemFilter in miscFilters)
                        {
                            if (itemFilter.ShouldRemove(item))
                            {
                                WriteLN("Removing: " + item.ListString, DebugMode.Enabled);
                                referenceList.Misc.Remove(item);
                                WriteLN("Removed: " + (!referenceList.Misc.Contains(item)), DebugMode.Enabled);
                                break;
                            }
                        }
                    }
                    WriteLN($"{type} Filtered.", DebugMode.Disabled);
                    referenceList.Misc = referenceList.Misc.OrderBy(o => o.Name).ToList();
                }
                else
                {
                    WriteLN($"\"{type}Filters.csv\" not detected. No filters applied to Filters.", DebugMode.Disabled);
                }
            }
            else
            {
                WriteLN($"\"{type}.csv\" not detected.", DebugMode.Disabled);
            }
        }

        public void GetAndFilterShouts()
        {
            string type = "Shouts";
            if (File.Exists($"{ConfigurationManager.AppSettings["sseedit"]}\\BatchBuilder\\xEditOutput\\{type}.csv"))
            {
                WriteLN($"Reading \"{type}.csv\".", DebugMode.Disabled);
                using (var reader = new StreamReader($"{ConfigurationManager.AppSettings["sseedit"]}\\BatchBuilder\\xEditOutput\\{type}.csv"))
                {
                    reader.ReadLine();
                    while (!reader.EndOfStream)
                    {
                        string s = reader.ReadLine();
                        WriteLN(s, DebugMode.Enabled);
                        referenceList.Shouts.Add(new Item(s));
                    }
                }
                WriteLN($"Loaded \"{type}.csv\".", DebugMode.Disabled);

                if (File.Exists($"{ConfigurationManager.AppSettings["resourcesfolder"]}{type}Filters.csv"))
                {
                    WriteLN($"Gathering {type} Filters.", DebugMode.Disabled);
                    List<ItemFilter> miscFilters = new List<ItemFilter>();

                    using (var reader = new StreamReader($"{ConfigurationManager.AppSettings["resourcesfolder"]}{type}Filters.csv"))
                    {
                        int filterCount = 1;
                        while (!reader.EndOfStream)
                        {
                            string s = reader.ReadLine();
                            WriteLN(s, DebugMode.Enabled);
                            if (IsValidFilter(s))
                            {
                                ItemFilter itemFilter = new ItemFilter(s);
                                miscFilters.Add(itemFilter);
                            }
                            else
                            {
                                WriteLN($"{type} filter at line {filterCount} not excepted.", DebugMode.Disabled);
                            }
                            filterCount++;
                        }
                    }
                    WriteLN($"{type} filters Gathered.", DebugMode.Disabled);
                    WriteLN($"Filtering {type}.", DebugMode.Disabled);
                    List<Item> misc = new List<Item>();
                    misc.AddRange(referenceList.Shouts);
                    foreach (Item item in misc)
                    {
                        foreach (ItemFilter itemFilter in miscFilters)
                        {
                            if (itemFilter.ShouldRemove(item))
                            {
                                WriteLN("Removing: " + item.ListString, DebugMode.Enabled);
                                referenceList.Shouts.Remove(item);
                                WriteLN("Removed: " + (!referenceList.Shouts.Contains(item)), DebugMode.Enabled);
                                break;
                            }
                        }
                    }
                    WriteLN($"{type} Filtered.", DebugMode.Disabled);
                    referenceList.Shouts = referenceList.Shouts.OrderBy(o => o.Name).ToList();
                }
                else
                {
                    WriteLN($"\"{type}Filters.csv\" not detected. No filters applied to {type.ToLower()}.", DebugMode.Disabled);
                }
            }
            else
            {
                WriteLN($"\"{type}.csv\" not detected.", DebugMode.Disabled);
            }
        }

        public void GetAndFilterBooks()
        {
            string type = "Books";
            if (File.Exists($"{ConfigurationManager.AppSettings["sseedit"]}\\BatchBuilder\\xEditOutput\\{type}.csv"))
            {
                WriteLN($"Reading \"{type}.csv\".", DebugMode.Disabled);
                using (var reader = new StreamReader($"{ConfigurationManager.AppSettings["sseedit"]}\\BatchBuilder\\xEditOutput\\{type}.csv"))
                {
                    reader.ReadLine();
                    while (!reader.EndOfStream)
                    {
                        string s = reader.ReadLine();
                        WriteLN(s, DebugMode.Enabled);
                        referenceList.Books.Add(new Item(s));
                    }
                }
                WriteLN($"Loaded \"{type}.csv\".", DebugMode.Disabled);

                if (File.Exists($"{ConfigurationManager.AppSettings["resourcesfolder"]}{type}Filters.csv"))
                {
                    WriteLN($"Gathering {type} Filters.", DebugMode.Disabled);
                    List<ItemFilter> BookFilters = new List<ItemFilter>();

                    using (var reader = new StreamReader($"{ConfigurationManager.AppSettings["resourcesfolder"]}{type}Filters.csv"))
                    {
                        int filterCount = 1;
                        while (!reader.EndOfStream)
                        {
                            string s = reader.ReadLine();
                            WriteLN(s, DebugMode.Enabled);
                            if (IsValidFilter(s))
                            {
                                ItemFilter itemFilter = new ItemFilter(s);
                                BookFilters.Add(itemFilter);
                            }
                            else
                            {
                                WriteLN($"{type} filter at line {filterCount} not excepted.", DebugMode.Disabled);
                            }
                            filterCount++;
                        }
                    }
                    WriteLN($"{type} filters Gathered.", DebugMode.Disabled);
                    WriteLN($"Filtering {type}.", DebugMode.Disabled);
                    List<Item> misc = new List<Item>();
                    misc.AddRange(referenceList.Books);
                    foreach (Item item in misc)
                    {
                        foreach (ItemFilter itemFilter in BookFilters)
                        {
                            if (itemFilter.ShouldRemove(item))
                            {
                                WriteLN("Removing: " + item.ListString, DebugMode.Enabled);
                                referenceList.Books.Remove(item);
                                WriteLN("Removed: " + (!referenceList.Books.Contains(item)), DebugMode.Enabled);
                                break;
                            }
                        }
                    }
                    WriteLN($"{type} Filtered.", DebugMode.Disabled);
                    referenceList.Books = referenceList.Books.OrderBy(o => o.Name).ToList();
                }
                else
                {
                    WriteLN($"\"{type}Filters.csv\" not detected. No filters applied to {type.ToLower()}.", DebugMode.Disabled);
                }
            }
            else
            {
                WriteLN($"\"{type}.csv\" not detected.", DebugMode.Disabled);
            }
        }

        public void ImportNewItemList()
        {
            referenceList = new ReferenceLists();
            if (!File.Exists($"{ConfigurationManager.AppSettings["sseedit"]}\\BatchBuilder\\xEditOutput\\loadorder.csv") ||
                !File.Exists($"{ConfigurationManager.AppSettings["sseedit"]}\\BatchBuilder\\xEditOutput\\Armor.csv") ||
                !File.Exists($"{ConfigurationManager.AppSettings["sseedit"]}\\BatchBuilder\\xEditOutput\\Spells.csv") ||
                !File.Exists($"{ConfigurationManager.AppSettings["sseedit"]}\\BatchBuilder\\xEditOutput\\foodandpotions.csv") ||
                !File.Exists($"{ConfigurationManager.AppSettings["sseedit"]}\\BatchBuilder\\xEditOutput\\ingredients.csv") ||
                !File.Exists($"{ConfigurationManager.AppSettings["sseedit"]}\\BatchBuilder\\xEditOutput\\weapons.csv"))
            {
                WriteLN("One or more Files missing.", DebugMode.Disabled);
            }
            WriteLN("Varified SSE Edit Output Directory.", DebugMode.Disabled);

            ImportNewLoadOrder();

            GetAndFilterArmor();

            GetAndFilterWeapons();

            GetAndFilterSpells();

            GetAndFilterMisc();

            GetAndFilterShouts();

            GetAndFilterBooks();

            if (File.Exists($"{ConfigurationManager.AppSettings["sseedit"]}\\BatchBuilder\\xEditOutput\\foodandpotions.csv"))
            {

                WriteLN("Reading \"foodandpotions.csv\".", DebugMode.Disabled);
                using (var reader = new StreamReader($"{ConfigurationManager.AppSettings["sseedit"]}\\BatchBuilder\\xEditOutput\\foodandpotions.csv"))
                {
                    reader.ReadLine();
                    while (!reader.EndOfStream)
                    {
                        string s = reader.ReadLine();
                        WriteLN(s, DebugMode.Enabled);
                        referenceList.FoodAndPotions.Add(new Item(s));
                    }
                }
                WriteLN("Loaded \"foodandpotions.csv\".", DebugMode.Disabled);
                referenceList.FoodAndPotions = referenceList.FoodAndPotions.OrderBy(o => o.Name).ToList();
            }
            else
            {
                WriteLN("\"foodandpotions.csv\" not detected.", DebugMode.Disabled);
            }

            if (File.Exists($"{ConfigurationManager.AppSettings["sseedit"]}\\BatchBuilder\\xEditOutput\\ingredients.csv"))
            {
                WriteLN("Reading \"ingredients.csv\".", DebugMode.Disabled);
                using (var reader = new StreamReader($"{ConfigurationManager.AppSettings["sseedit"]}\\BatchBuilder\\xEditOutput\\ingredients.csv"))
                {
                    reader.ReadLine();
                    while (!reader.EndOfStream)
                    {
                        string s = reader.ReadLine();
                        WriteLN(s, DebugMode.Enabled);
                        referenceList.Ingredients.Add(new Item(s));
                    }
                }
                WriteLN("Loaded \"ingredients.csv\".", DebugMode.Disabled);
                referenceList.Ingredients = referenceList.Ingredients.OrderBy(o => o.Name).ToList();
            }
            else
            {
                WriteLN("\"ingredients.csv\" not detected.", DebugMode.Disabled);
            }
            References.ExportItemList(referenceList);
            WriteLN("Files read successfully. Free to close.", DebugMode.Disabled);
        }

        public void ImportNewPerksList()
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = $"{ConfigurationManager.AppSettings["sseedit"]}\\BatchBuilder\\xEditOutput";
                openFileDialog.Filter = "xEdit genorated PerksList (PerksList.csv)|PerksList.csv|Manualy Made Perks List (*.csv)|*.csv";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    new MessageBoxForm($"It is recommended to manually edit the perks list before import, even if using the perk organizer. {Environment.NewLine}Just press ok when ready.").ShowDialog();
                    PerksListNameForm perksListNameForm = new PerksListNameForm();
                    if (perksListNameForm.ShowDialog() == DialogResult.OK)
                    {
                        List<Perk> perks = new List<Perk>();
                        WriteLN("Reading perks list.", DebugMode.Disabled);
                        using (var reader = new StreamReader(openFileDialog.OpenFile()))
                        {
                            reader.ReadLine();
                            while (!reader.EndOfStream)
                            {
                                string s = reader.ReadLine();
                                WriteLN(s, DebugMode.Enabled);
                                perks.Add(new Perk(s));
                            }
                        }
                        References.ExportPerksList(perks, perksListNameForm.perksListNameBox.Text.ToString());
                        WriteLN("Perks list built.", DebugMode.Disabled);
                    }
                    else
                    {
                        WriteLN("Perk import canceled.", DebugMode.Disabled);
                    }
                }
                else
                {
                    WriteLN("Perk import canceled.", DebugMode.Disabled);
                }
            }
        }

        private void buildPerksListMenuItem_Click(object sender, EventArgs e)
        {
            ImportNewPerksList();
        }
    }
}
