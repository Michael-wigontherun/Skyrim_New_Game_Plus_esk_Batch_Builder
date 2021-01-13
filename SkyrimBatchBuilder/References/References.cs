using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text.Json;

namespace SkyrimBatchBuilder.SkyrimReferences
{
    public static class References
    {
        public static void ExportItemList(ReferenceLists itemsList)
        {
            File.WriteAllText($"{ConfigurationManager.AppSettings["resourcesfolder"]}ItemsList.json", JsonSerializer.Serialize(itemsList));
        }

        public static ReferenceLists ImportItemList()
        {
            return JsonSerializer.Deserialize<ReferenceLists>(File.ReadAllText($"{ ConfigurationManager.AppSettings["resourcesfolder"]}ItemsList.json"));
        }

        public static void ExportPerksList(List<Perk> perksList, string perksListName)
        {
            File.WriteAllText($"{ConfigurationManager.AppSettings["resourcesfolder"]}\\PerkList\\{perksListName}_PerksList.json", JsonSerializer.Serialize(perksList));
        }

        public static List<Perk> ImportPerksList(string perkslistFullPath)
        {
            return JsonSerializer.Deserialize<List<Perk>>(File.ReadAllText(perkslistFullPath));
        }

        public static void ExportProfile(Profile profile, string profileName)
        {
            File.WriteAllText($"{ConfigurationManager.AppSettings["profilesfolder"]}{profileName}.json", JsonSerializer.Serialize(profile));
        }

        public static Profile ImportProfile(string profileFullPath)
        {
            return JsonSerializer.Deserialize<Profile>(File.ReadAllText(profileFullPath));
        }

        public static void ExportOverloadProfile(Profile profile, string profileName)
        {
            File.WriteAllText($"{ConfigurationManager.AppSettings["profilesfolder"]}Overload\\{profileName}.json", JsonSerializer.Serialize(profile));
        }

        public static Profile ImportOverloadProfile(string profileFullPath)
        {
            return JsonSerializer.Deserialize<Profile>(File.ReadAllText(profileFullPath));
        }
    }

    public static class ReferencesUtil
    {
        public static string FormatStringLength(string str, int lengthYouWant)
        {
            if (str.Length < lengthYouWant)
            {
                str = str.PadRight(lengthYouWant);
            }
            else if (str.Length > lengthYouWant)
            {
                str = str.Remove(lengthYouWant);
            }
            return str;
        }
    }
}
