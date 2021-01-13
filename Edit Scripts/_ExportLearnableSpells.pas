unit _ExportSpellTomes;

interface
  implementation
  uses xEditAPI, mteFunctions, _wotrFunctions, Classes, SysUtils, StrUtils, Windows;

var slSpells : TStringList;

function Initialize : integer;
begin
  slSpells := TStringList.Create;
  slSpells.Add('EspName;FormID;EDID;Name;Type');
end;

function Process(e : IInterface) : integer;
var
  spell : IInterface;
  
begin
	if Signature(e) <> 'BOOK' then  Exit;
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

function Finalize : integer;
var folderDirectory : TStringList;
begin
  folderDirectory := TStringList.Create;
  folderDirectory.add('BatchBuilder');
  folderDirectory.add('BatchBuilder\xEditOutput');
  createOutputFolder(folderDirectory);
	if not Assigned(slSpells) then
    Exit;
  if (slSpells.Count > 1) then begin
      slSpells.SaveToFile(ProgramPath+'BatchBuilder\xEditOutput\Spells.csv');
  end;
  slSpells.Free;
end;

end.
