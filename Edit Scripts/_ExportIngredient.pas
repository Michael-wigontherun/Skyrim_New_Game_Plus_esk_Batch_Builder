unit _ExportIngredient;

interface
  implementation
  uses xEditAPI, mteFunctions, _wotrFunctions, Classes, SysUtils, StrUtils, Windows;

var slIngredient : TStringList;
  
function Initialize: integer;
begin
  slIngredient := TStringList.Create;
  slIngredient.Add('EspName;FormID;EDID;Name;Type');
end;


function Process(e: IInterface): integer;
begin
  if Signature(e) = 'INGR' then
  begin
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
end;

function Finalize: integer;
var folderDirectory : TStringList;
begin
  folderDirectory := TStringList.Create;
  folderDirectory.add('BatchBuilder');
  folderDirectory.add('BatchBuilder\xEditOutput');
  createOutputFolder(folderDirectory);
  if Assigned(slIngredient) then
  begin
    if  (slIngredient.Count > 1) then begin
        slIngredient.SaveToFile(ProgramPath+'BatchBuilder\xEditOutput\ingredients.csv');
    end;
    slIngredient.Free;
  end;
end;

end.