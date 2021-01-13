unit _ExportShouts;

interface
  implementation
  uses xEditAPI, mteFunctions, _wotrFunctions, Classes, SysUtils, StrUtils, Windows;

var slShouts : TStringList;
  
function Initialize: integer;
begin
  slShouts := TStringList.Create;
  slShouts.Add('EspName;FormID;EDID;type;Name');
end;

function Process(e: IInterface): integer;
var
  container: IInterface;
  n : integer;
begin
  if Signature(e) = 'SHOU' then begin
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
end;


function Finalize: integer;
var folderDirectory : TStringList;
begin
  folderDirectory := TStringList.Create;
  folderDirectory.add('BatchBuilder');
  folderDirectory.add('BatchBuilder\xEditOutput');
  createOutputFolder(folderDirectory);
  if Assigned(slShouts) then begin
    if  (slShouts.Count > 1) then begin
        slShouts.SaveToFile(ProgramPath+'BatchBuilder\xEditOutput\Shouts.csv');
    end;
    slShouts.Free;
  end;
end;

end.