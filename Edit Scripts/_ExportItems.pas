unit _ExportItems;

interface
  implementation
  uses xEditAPI, mteFunctions, _wotrFunctions, Classes, SysUtils, StrUtils, Windows;

var 
  slWeap, slArmo, slShouts, slBooks, slMisc, slSpells, slLoadOrder, slIngredient, slFoodAndPotions : TStringList;
  previousPlugin : string;
  
function Initialize: integer;
begin
  slLoadOrder := TStringList.Create;
  previousPlugin := '';
  slWeap := TStringList.Create;
  slWeap.Add('EspName;FormID;EDID;Name;Type');
  slArmo := TStringList.Create;
  slArmo.Add('EspName;FormID;EDID;Name;Type');
  slSpells := TStringList.Create;
  slSpells.Add('EspName;FormID;EDID;Name;Type');
  slIngredient := TStringList.Create;
  slIngredient.Add('EspName;FormID;EDID;Name;Type');
  slFoodAndPotions := TStringList.Create;
  slFoodAndPotions.Add('EspName;FormID;EDID;Name;Type');
  slMisc := TStringList.Create;
  slMisc.Add('EspName;FormID;EDID;Name;Type');
  slShouts := TStringList.Create;
  slShouts.Add('EspName;FormID;EDID;type;Name');
  slBooks := TStringList.Create;
  slBooks.Add('EspName;FormID;EDID;Name;Type');
end;


function Process(e: IInterface): integer;
var
  spell : IInterface;
  container: IInterface;
  n : integer;
begin
  {load order}if Name(GetFile(e)) <> previousPlugin then begin
    slLoadOrder.Add(Name(GetFile(e)));
    previousPlugin := Name(GetFile(e));
  end;

  {weapons}if Signature(e) = 'WEAP' then begin
    if GetElementEditValues(e, 'FULL - Name') = '' then Exit;
    if GetElementEditValues(e, 'KSIZ') = '' then Exit;
    if StrToInt(GetElementEditValues(e, 'KSIZ')) < 1 then Exit; 
    if HasKeyword(e, 'Dummy [KYWD:000F3E6C]') then Exit;
    if IsMaster(e) = false then Exit;
    slWeap.Add(Format('%s;%s;%s;%s;%s', [
      BaseName(GetFile(e)),
      GetStringFormID(e),
      GetElementEditValues(e, 'EDID - Editor ID'),
      GetElementEditValues(WinningOverride(e), 'FULL - Name'),
      WeaponType(e)
    ]));
  end;

  {armor}if Signature(e) = 'ARMO' then begin
    if GetElementEditValues(e, 'FULL - Name') = '' then Exit;
    if GetElementEditValues(e, 'KSIZ') = '' then Exit;
    if StrToInt(GetElementEditValues(e, 'KSIZ')) < 1 then Exit; 
    if IsMaster(e) = false then Exit;
    slArmo.Add(Format('%s;%s;%s;%s;%s', [
      BaseName(GetFile(e)),
      GetStringFormID(e),
      GetElementEditValues(e, 'EDID - Editor ID'),
      GetElementEditValues(WinningOverride(e), 'FULL - Name'),
      ArmorType(e)
    ]));
  end;

	{spells}if Signature(e) = 'BOOK' then  begin
    if Name(ElementByIndex(ElementByPath(e, 'DATA\Flags'),0)) = 'Teaches Spell' then begin
      spell := LinksTo(ElementByPath(WinningOverride(e), 'DATA\Spell'));
      slSpells.Add(Format('%s;%s;%s;%s;%s', [
        BaseName(GetFile(e)),
        GetStringFormID(spell),
        GetElementEditValues(spell, 'EDID - Editor ID'),
        GetElementEditValues(spell, 'FULL - Name'),
        SpellType(spell)
      ]));
    end;
  end;

  {ingredient}if Signature(e) = 'INGR' then begin
    if GetElementEditValues(e, 'FULL - Name') = '' then Exit;
    if IsMaster(e) = false then Exit;
    slIngredient.Add(Format('%s;%s;%s;%s;%s', [
        BaseName(GetFile(e)),
        GetStringFormID(e),
        GetElementEditValues(e, 'EDID - Editor ID'),
        GetElementEditValues(WinningOverride(e), 'FULL - Name'),
        'Ingredient'
    ]));
  end;

  {Food&Potions}if Signature(e) = 'ALCH' then begin
    if GetElementEditValues(e, 'FULL - Name') = '' then Exit;
    if HasKeyword(e, 'Dummy [KYWD:000F3E6C]') then Exit;
    if IsMaster(e) = false then Exit;
    slFoodAndPotions.Add(Format('%s;%s;%s;%s;%s', [
        BaseName(GetFile(e)),
        GetStringFormID(e),
        GetElementEditValues(e, 'EDID - Editor ID'),
        GetElementEditValues(WinningOverride(e), 'FULL - Name'),
        EdibleType(WinningOverride(e))
    ]));
  end;

  {misc}if Signature(e) = 'MISC' then begin
    if GetElementEditValues(e, 'FULL - Name') = '' then Exit;
    if IsMaster(e) = false then Exit;
    slMisc.Add(Format('%s;%s;%s;%s;%s', [
        BaseName(GetFile(e)),
        GetStringFormID(e),
        GetElementEditValues(e, 'EDID - Editor ID'),
        GetElementEditValues(WinningOverride(e), 'FULL - Name'),
        'Misc Item'
    ]));
  end;

  {Shout}if Signature(e) = 'SHOU' then begin
    if GetElementEditValues(e, 'FULL - Name') = '' then Exit;
    if IsWinningOverride(e) = false then Exit;
    container := ElementByPath(e, 'Words of Power');
    for n := 0 to ElementCount(container) - 1 do
    begin
        if GetElementEditValues(ElementByIndex(container, n) ,'Word') <> 'NULL - Null Reference [00000000]' then 
        begin
            slShouts.Add(Format('%s;%s;%s;%s;%s', [
                BaseName(GetFile( LinksTo(ElementByPath(ElementByIndex(container, n) ,'Word')) )),
                GetStringFormID( LinksTo(ElementByPath(ElementByIndex(container, n) ,'Word')) ) ,
                GetElementEditValues(e, 'EDID - Editor ID'),
                GetElementEditValues(WinningOverride(e), 'FULL - Name'),
                GetElementEditValues( LinksTo(ElementByPath(ElementByIndex(container, n) ,'Word')), 'FULL - Name' )
            ]));
        end;
    end;
  end;
  {Books}if Signature(e) = 'BOOK' then begin  
    if GetElementEditValues(e, 'FULL - Name') = '' then Exit;
    if IsMaster(e) = false then Exit;
    slBooks.Add(Format('%s;%s;%s;%s;%s', [
        BaseName(GetFile(e)),
        GetStringFormID(e),
        GetElementEditValues(e, 'EDID - Editor ID'),
        GetElementEditValues(WinningOverride(e), 'FULL - Name'),
        'Book'
    ]));
  end;
  {Scrolls}if Signature(e) = 'SCRL' then begin  
    if GetElementEditValues(e, 'FULL - Name') = '' then Exit;
    if IsMaster(e) = false then Exit;
    slBooks.Add(Format('%s;%s;%s;%s;%s', [
        BaseName(GetFile(e)),
        GetStringFormID(e),
        GetElementEditValues(e, 'EDID - Editor ID'),
        GetElementEditValues(WinningOverride(e), 'FULL - Name'),
        'Scroll'
    ]));
  end;
end;

function Finalize: integer;
var folderDirectory : TStringList;
begin
  folderDirectory := TStringList.Create;
  folderDirectory.add('BatchBuilder');
  folderDirectory.add('BatchBuilder\xEditOutput');
  createOutputFolder(folderDirectory);
  {load order}if Assigned(slLoadOrder) then begin
    if  (slLoadOrder.Count > 0) then begin
        slLoadOrder.SaveToFile(ProgramPath+'BatchBuilder\xEditOutput\loadorder.csv');
    end;
    slLoadOrder.Free;
  end;
  {weapons}if Assigned(slWeap) then begin
    if  (slWeap.Count > 1) then begin
      slWeap.SaveToFile(ProgramPath+'BatchBuilder\xEditOutput\Weapons.csv');
    end;
    slWeap.Free;
  end;
  {armor}if Assigned(slArmo) then begin
    if (slArmo.Count > 1) then begin
        slArmo.SaveToFile(ProgramPath+'BatchBuilder\xEditOutput\Armor.csv');
    end;
    slArmo.Free;
  end;
  {spells}if Assigned(slSpells) then begin
    if (slSpells.Count > 1) then begin
        slSpells.SaveToFile(ProgramPath+'BatchBuilder\xEditOutput\Spells.csv');
    end;
    slSpells.Free;
  end;
  {ingredient}if Assigned(slIngredient) then begin
    if  (slIngredient.Count > 1) then begin
        slIngredient.SaveToFile(ProgramPath+'BatchBuilder\xEditOutput\ingredients.csv');
    end;
    slIngredient.Free;
  end;
  {Food&Potions}if Assigned(slFoodAndPotions) then begin
    if  (slFoodAndPotions.Count > 1) then begin
        slFoodAndPotions.SaveToFile(ProgramPath+'BatchBuilder\xEditOutput\foodandpotions.csv');
    end;
    slFoodAndPotions.Free;
  end;
  {misc}if Assigned(slMisc) then begin
    if  (slMisc.Count > 1) then begin
        slMisc.SaveToFile(ProgramPath+'BatchBuilder\xEditOutput\Misc.csv');
    end;
    slMisc.Free;
  end;
  {Shout}if Assigned(slShouts) then begin
    if  (slShouts.Count > 1) then begin
        slShouts.SaveToFile(ProgramPath+'BatchBuilder\xEditOutput\Shouts.csv');
    end;
    slShouts.Free;
  end;
  {Books&Scrolls}if Assigned(slBooks) then begin
    if  (slBooks.Count > 1) then begin
        slBooks.SaveToFile(ProgramPath+'BatchBuilder\xEditOutput\Books.csv');
    end;
    slBooks.Free;
  end;
 


 end;
end.