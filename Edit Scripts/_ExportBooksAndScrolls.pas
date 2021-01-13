unit _ExportBooksAndScrolls;

interface
  implementation
  uses xEditAPI, mteFunctions, _wotrFunctions, Classes, SysUtils, StrUtils, Windows;

var slBooks : TStringList;
  
function Initialize: integer;
begin
  slBooks := TStringList.Create;
  slBooks.Add('EspName;FormID;EDID;Name;Type');
end;

function Process(e: IInterface): integer;
begin
  if Signature(e) = 'BOOK' then begin  
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
  if Signature(e) = 'SCRL' then begin  
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
  if Assigned(slBooks) then begin
    if  (slBooks.Count > 1) then begin
        slBooks.SaveToFile(ProgramPath+'BatchBuilder\xEditOutput\Books.csv');
    end;
    slBooks.Free;
  end;
end;

end.