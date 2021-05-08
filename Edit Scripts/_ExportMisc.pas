unit _ExportMisc;

interface
  implementation
  uses xEditAPI, mteFunctions, _wotrFunctions, Classes, SysUtils, StrUtils, Windows;

var slMisc : TStringList;
  
function Initialize: integer;
begin
  slMisc := TStringList.Create;
  slMisc.Add('EspName;FormID;EDID;Name;Type');
end;

function Process(e: IInterface): integer;
begin
  if Signature(e) = 'MISC' then begin
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
  if Signature(e) = 'AMMO' then begin
    if GetElementEditValues(e, 'FULL - Name') = '' then Exit;
    if IsMaster(e) = false then Exit;
    slMisc.Add(Format('%s;%s;%s;%s;%s', [
        BaseName(GetFile(e)),
        GetStringFormID(e),
        GetElementEditValues(e, 'EDID - Editor ID'),
        GetElementEditValues(WinningOverride(e), 'FULL - Name'),
        'Ammo'
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
  if Assigned(slMisc) then begin
    if  (slMisc.Count > 1) then begin
        slMisc.SaveToFile(ProgramPath+'BatchBuilder\xEditOutput\Misc.csv');
    end;
    slMisc.Free;
  end;
end;

end.