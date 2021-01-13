unit _ExportWeapons;

interface
  implementation
  uses xEditAPI, mteFunctions, _wotrFunctions, Classes, SysUtils, StrUtils, Windows;

var slWeap : TStringList;
  
function Initialize: integer;
begin
  slWeap := TStringList.Create;
  slWeap.Add('EspName;FormID;EDID;Name;Type');
end;


function Process(e: IInterface): integer;
begin
  if Signature(e) = 'WEAP' then 
  begin
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
end;

function Finalize: integer;
var folderDirectory : TStringList;
begin
  folderDirectory := TStringList.Create;
  folderDirectory.add('BatchBuilder');
  folderDirectory.add('BatchBuilder\xEditOutput');
  createOutputFolder(folderDirectory);
  if  Assigned(slWeap) then 
  begin
    if  (slWeap.Count > 1) then begin
      slWeap.SaveToFile(ProgramPath+'BatchBuilder\xEditOutput\weapons.csv');
    end;
    slWeap.Free;
  end;
 end;

end.