using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Text.Json.Serialization;

namespace SkyrimBatchBuilder.SkyrimReferences
{
    public class ItemFilter
    {
        public string PluginName { get; set; }
        public string EditorIDFilter { get; set; }
        public ItemFilter() { }
        public ItemFilter(string csvFilters)
        {
            SetFilter(csvFilters);
        }

        public ItemFilter SetFilter(string csvFilters)
        {
            string[] csvArr = csvFilters.Split(';');
            PluginName = csvArr[0];
            EditorIDFilter = csvArr[1];
            if (PluginName.Equals(string.Empty))
            {
                PluginName = "79683495726347856279497896342785435.exe";
            }
            if (EditorIDFilter.Equals(string.Empty))
            {
                EditorIDFilter = "79683495726347856279497896342785435.exe";
            }
            return this;
        }

        public bool ShouldRemove(Item item)
        {
            string itemPluginName = item.pluginName + " ";
            if (itemPluginName.Contains(PluginName))
            {
                string itemEditorID = item.EditorID + " ";
                if (itemEditorID.Contains(EditorIDFilter))
                {
                    return true;
                }
            }

            return false;
        }
    }

    public class ReferenceLists
    {
        //[JsonInclude]
        //public List<Plugin> plugins = new List<Plugin>();
        [JsonInclude]
        public SortedDictionary<string, Plugin> plugins = new SortedDictionary<string, Plugin>();
        [JsonInclude]
        public List<Plugin> LoadOrder = new List<Plugin>();
        [JsonInclude]
        public List<Item> Weapons = new List<Item>();
        [JsonInclude]
        public List<Item> Armor = new List<Item>();
        [JsonInclude]
        public List<Item> Spells = new List<Item>();
        [JsonInclude]
        public List<Item> FoodAndPotions = new List<Item>();
        [JsonInclude]
        public List<Item> Ingredients = new List<Item>();
        [JsonInclude]
        public List<Item> Misc = new List<Item>();
        [JsonInclude]
        public List<Item> Shouts = new List<Item>();
        [JsonInclude]
        public List<Item> Books = new List<Item>();
    }

    public class Plugin
    {
        [JsonInclude]
        public string pluginName { get; set; }
        [JsonInclude]
        public string modIndex { get; set; }
        [JsonInclude]
        public bool IsESLFlagged { get; set; }

        public Plugin() { }

        public Plugin(string csvString)
        {
            SetPlugin(csvString);
        }

        public Plugin SetPlugin(string csvString)//[00] Skyrim.esm
        {
            modIndex = csvString.Substring(csvString.IndexOf('[')+1, csvString.IndexOf(']') - csvString.IndexOf('[')-1).Replace(" ", "");
            pluginName = csvString.Substring(csvString.IndexOf(']')+2);
            IsESLFlagged = modIndex.Length > 2;
            return this;
        }

        public string ToString()
        {
            return $"{ReferencesUtil.FormatStringLength($"[{modIndex}]", 7)} {pluginName}";
        }
        
    }
    
    public class Perk
    {
        [JsonInclude]
        public string pluginName { get; set; }
        [JsonInclude]
        public string FormID { get; set; }
        [JsonInclude]
        public string Name { get; set; }
        [JsonInclude]
        public string Description { get; set; }
        [JsonInclude]
        public string SkillType { get; set; }
        [JsonInclude]
        public int RequiredAV { get; set; }
        [JsonInclude]
        public string ListString { get; set; }

        public Perk() { }

        public Perk(string csvString)
        {
            SetItem(csvString);
        }

        public Perk SetItem(string csvString)//Skyrim.esm;000153CD;Alteration Dual Casting;Dual casting an Alteration spell overcharges...;Alteration;20
        {
            string[] csvArr = csvString.Split(';');
            pluginName = csvArr[0];
            FormID = csvArr[1];
            Name = csvArr[2];
            Description = csvArr[3];
            SkillType = csvArr[4];
            if (Double.TryParse(csvArr[5].Trim(), out _))
            {
                RequiredAV = (int)Double.Parse(csvArr[5].Trim());
            }
            else RequiredAV = 0;
            CreateListString();
            return this;
        }

        public void FixFormID(string newModFormID)
        {
            FormID = newModFormID + FormID.Remove(0, newModFormID.Length);
        }

        public void CreateListString()
        {
            ListString = $"{ReferencesUtil.FormatStringLength(Name, 30)}|{ReferencesUtil.FormatStringLength(SkillType, 20)}|{Description}";
        }
    }

    public class Item
    {
        [JsonInclude]
        public string pluginName { get; set; }
        [JsonInclude]
        public string FormID { get; set; }
        [JsonInclude]
        public string EditorID { get; set; }
        [JsonInclude]
        public string Name { get; set; }
        [JsonInclude]
        public string Type { get; set; }
        [JsonInclude]
        public string ListString { get; set; }
        [JsonInclude]
        public int Amount { get; set; }
        public Item() { }

        public Item(string csvString)
        {
            SetItem(csvString);
        }

        public Item SetItem(string csvString)//Skyrim.esm;000006D4;ArmorImperialGauntlets;Imperial Bracers;Heavy Armor
        {
            string[] csvArr = csvString.Split(';');
            pluginName = csvArr[0];
            FormID = csvArr[1];
            EditorID = csvArr[2];
            Name = csvArr[3];
            Type = csvArr[4];
            CreateListString();
            Amount = 1;
            return this;
        }

        public void FixFormID(string newModFormID)
        {
            FormID = newModFormID + FormID.Remove(0, newModFormID.Length);
        }

        

        public void CreateListString()
        {
            ListString = $"{ReferencesUtil.FormatStringLength(pluginName, 30)}|{ReferencesUtil.FormatStringLength(Name, 70)}|{ReferencesUtil.FormatStringLength(Type, 20)}";
        }

        public bool Equals(string text)
        {
            return ListString.Equals(text);
        }
    }
    
}
