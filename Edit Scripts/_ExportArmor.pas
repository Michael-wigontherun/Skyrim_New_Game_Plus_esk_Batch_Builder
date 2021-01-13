unit _ExportArmor;

interface
  implementation
  uses xEditAPI, mteFunctions, _wotrFunctions, Classes, SysUtils, StrUtils, Windows;

var slArmo : TStringList;
  
function Initialize: integer;
begin
  slArmo := TStringList.Create;
  slArmo.Add('EspName;FormID;EDID;Name;Type');
end;

function Process(e: IInterface): integer;
begin
  if Signature(e) <> 'ARMO' then Exit;
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

function Finalize: integer;
var folderDirectory : TStringList;
begin
  folderDirectory := TStringList.Create;
  folderDirectory.add('BatchBuilder');
  folderDirectory.add('BatchBuilder\xEditOutput');
  createOutputFolder(folderDirectory);
  if not Assigned(slArmo) then
    Exit;
  if (slArmo.Count > 1) then begin
      slArmo.SaveToFile(ProgramPath+'BatchBuilder\xEditOutput\Armor.csv');
  end;

  slArmo.Free;
  
 end;

end.