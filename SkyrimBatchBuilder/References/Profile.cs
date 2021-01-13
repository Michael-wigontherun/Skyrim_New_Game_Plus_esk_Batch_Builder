using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace SkyrimBatchBuilder.SkyrimReferences
{
    public class Profile
    {
        [JsonInclude]
        public string ProfileName { get; set; }
        [JsonInclude]
        public int Level { get; set; }
        [JsonInclude]
        public int Health { get; set; }
        [JsonInclude]
        public int Stamina { get; set; }
        [JsonInclude]
        public int Magicka { get; set; }
        [JsonInclude]
        public int Carryweight { get; set; }
        [JsonInclude]
        public int DragonSouls { get; set; }
        [JsonInclude]
        public int Gold { get; set; }
        [JsonInclude]
        public int OneHanded { get; set; }
        [JsonInclude]
        public int TwoHanded { get; set; }
        [JsonInclude]
        public int Block { get; set; }
        [JsonInclude]
        public int Smithing { get; set; }
        [JsonInclude]
        public int HeavyArmor { get; set; }
        [JsonInclude]
        public int LightArmor { get; set; }
        [JsonInclude]
        public int Alteration { get; set; }
        [JsonInclude]
        public int Conjuration { get; set; }
        [JsonInclude]
        public int Destruction { get; set; }
        [JsonInclude]
        public int Enchanting { get; set; }
        [JsonInclude]
        public int Illusion { get; set; }
        [JsonInclude]
        public int Restoration { get; set; }
        [JsonInclude]
        public int Alchemy { get; set; }
        [JsonInclude]
        public int Lockpicking { get; set; }
        [JsonInclude]
        public int Pickpocket { get; set; }
        [JsonInclude]
        public int Sneak { get; set; }
        [JsonInclude]
        public int Speechcraft { get; set; }
        [JsonInclude]
        public int Marksman { get; set; }

        [JsonInclude]
        public List<Perk> PerkList = new List<Perk>();
        [JsonInclude]
        public List<string> Dependencies = new List<string>();
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
}
