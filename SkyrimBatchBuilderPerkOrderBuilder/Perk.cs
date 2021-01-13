using System;
using System.Collections.Generic;
using System.Text;

namespace SkyrimBatchBuilderPerkOrderBuilder
{
    public class Perk
    {
        public string pluginName { get; set; }
        public string FormID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SkillType { get; set; }
        public int RequiredAV { get; set; }

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
            return this;
        }


        public string ToString()
        {
            return $"{pluginName};{FormID};{Name};{Description};{SkillType};{RequiredAV}";
        }
    }
}
