unit _ExportFoodAndPotions;

interface
  implementation
  uses xEditAPI, mteFunctions, _wotrFunctions, Classes, SysUtils, StrUtils, Windows;

var slFoodAndPotions : TStringList;
  
function Initialize: integer;
begin
  slFoodAndPotions := TStringList.Create;
  slFoodAndPotions.Add('EspName;FormID;EDID;Name;Type');
end;

function Process(e: IInterface): integer;
begin
  if Signature(e) = 'ALCH' then begin
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
end;


function Finalize: integer;
var folderDirectory : TStringList;
begin
  folderDirectory := TStringList.Create;
  folderDirectory.add('BatchBuilder');
  folderDirectory.add('BatchBuilder\xEditOutput');
  createOutputFolder(folderDirectory);
  if Assigned(slFoodAndPotions) then begin
    if  (slFoodAndPotions.Count > 1) then begin
        slFoodAndPotions.SaveToFile(ProgramPath+'BatchBuilder\xEditOutput\foodandpotions.csv');
    end;
    slFoodAndPotions.Free;
  end;
end;

end.