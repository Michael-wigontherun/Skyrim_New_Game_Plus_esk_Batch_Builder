using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SkyrimBatchBuilderPerkOrderBuilder
{
    class Program
    {
        public static List<Perk> perks = new List<Perk>();
        static void Main(string[] args)
        {
            string fileName = args[0];
            if (File.Exists(fileName))
            {
                
                using (var reader = new StreamReader(fileName))
                {
                    reader.ReadLine();
                    while (!reader.EndOfStream)
                    {
                        string s = reader.ReadLine();
                        perks.Add(new Perk(s));
                    }
                }

                List<Perk> sortedList = perks.OrderBy(o => o.SkillType).ThenBy(o => o.RequiredAV).ToList();
                
                using (StreamWriter sw = File.CreateText(fileName))
                {
                    foreach (Perk perk in sortedList)
                    {
                        sw.WriteLine(perk.ToString());
                        Console.WriteLine(perk.ToString());
                    }
                }
            }
            else
            {
                Console.WriteLine("Missing PerksList");
            }
            Console.WriteLine("Press enter to end program...");
            Console.ReadLine();
        }
    }
}
