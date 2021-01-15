Overview

With the lack of a true new game plus feature, I have always tried to build my load order around a large number of mods so I can play a character for a long time. But with the impending releases of Beyond Skyrim, I have needed a way to play them with the character I have been playing for 3 years now. I was able to get away with it with Bruma by just adding it to my game mid playthrough, even if it made my game fairly unstable, once I was finally able to finish it I had to reload a save without it losing all my character progression during it and had to manually add all of it after but now because I have had so much free time I have completely done everything with the character, the base game+DLC and all the mods. now I would normally just add or remove a few more mods to continue but it is so unstable at this point it is not worth it. Hence the creation of this.

Features

Using xEdit to output all items, spells, shouts, and perks. Perks are very difficult to create using scripts from xEdit, Manual editing is always recommended. I have included Skyrim and Ordinator perk list premade if anyone would like to create their own for mods that I have yet to make you can upload it yourself or send it to me. If you don't want to make one your self, submit through this utilities GitHub page in issues using the milestone "Perk list Request."

Filter system to filter duplicate items unplayable ones etc. (See filter rules to create your own)

AV tab to set your Carry Weight, Stats, Level, and Skill Levels, as well as add gold and dragon souls. 

Using the list you can select what you want the game to add and build a profile you can load and update as many times as you want. As well as an overload system to add all items from another profile without

Instillation

First make sure this programs requirements are installed. being SSEEdit﻿, .Net Core runtime 3.1﻿, and mteFunctions ﻿from matortheeternal GitHub
Drop my 2 folders from this page the root folder of SSEEdit. Ensuring the Edit scripts from this go into SSEEdit's "Edit Scripts" folder and the other folder from my package can go anywhere but you will need to set the path to SSEEdit executable, but it will autodetect if its a child directory of SSEEdit.
Run the  SkyrimBatchBuilder.exe and make sure the path to SSEEdit is correct.

Usage

  Once installed correctly open make sure the path to SSEEdit is correct and in the menu strip click Generate => Item Lists. let SSEEdit run through the script. You will not need to do this again until you add a new mod that adds items.
  Then inside the Batch builder in the menu click Build => References. 
  Once the References Reader opens click Build => All Lists.  Once its finished you can close the reader. You will not need to do this again until you update the generate a new list.
  In the profile tab you need to set the profile name if you want to save the profile. you can also set the level, starting gold amount, carry weight, starting dragon souls, player stats and your each skill level
  Now in the main Profile Creation window click Load => References. Now you can go through the tabs and select what your character will need in terms of items.
  For perks do relatively the same steps. Except it will open the file explorer to select a list. Skyrim and Ordinator perks list I have already created the lists you will not need to do this for those 2 perk lists. (Submit all perk list requests GitHub page in issues using the milestone "Perk list Request.")
  Once you have selected everything you would like to have for your new game+, If you want to have this profile you can click Build => Profile / Rebuild to save your profile or update it, or Overload Profile to save only the items spells and perks.
  Once you are happy with your profile click Export => Profile or if you do not want to save it and only want what you have in the current session click Export => Current Session. Either of these will take you to the Export Profile window.
  In the Export Profile window, click Load Order => Update to update the load order or if you just built the references click Load Order => Current.
  Finally click Build Batch and select All if you want the full profile to be built, or Only Items if you want only the items.

Filters

Filters are only for Weapons, Armor, Books, Misc, and Shouts. Spells for the most part should never need to be filtered because its outputting every spell that is learnable via spell book.
Filters work based off of the source plugin from the item and the Editor of the record
1. Syntax "pluginName;EditorIDFilter;" Always add second semicolon. 
Any filter with anything after the second semicolon other then a new line will be ignored.
Make sure there is no space at the start or end of pluginName or EditorIDFilter.
See rule 3 for exception for spaces.
2. ".;Ench;" will filter all plugins and then any Editor ID with Ench in the name
Danger: never ever do ".;;" this will functionally filter every single item. There is a system to prevent this from happening 
but its an extra filter that will still be checked.
3. some entries have 2 or 3 record's with similar EditorIDs
Example dunMistwatchRing "Fjola's Wedding Band" [ARMO:000C0164] has an EditorID of dunMistwatchRing
and dunMistwatchRingSell "Fjola's Wedding Band" [ARMO:000D3BDB] has an EditorID of dunMistwatchRingSell.
Functionally there the same item but you will see 2 "Fjola's Wedding Band" so if you use the filter
"Skyrim.esm;dunMistwatchRing ;" it will remove the version Bethesda didn't want people to get being the
dunMistwatchRing "Fjola's Wedding Band" [ARMO:000C0164].

Extra Comments

I am only one person, I would appreciate anyone who knows or could point me in a better direction for outputting the lists.

I am working on a fallout 4 version but I do not know fallout 4's forms well enough yet.

The tools I used to develop this were Visual Studio and Visual studio Code
All issues, feature requests and perk list request please post to this utilities GitHub page at https://github.com/Michael-wigontherun/Skyrim_New_Game_Plus_esk_Batch_Builder﻿.
