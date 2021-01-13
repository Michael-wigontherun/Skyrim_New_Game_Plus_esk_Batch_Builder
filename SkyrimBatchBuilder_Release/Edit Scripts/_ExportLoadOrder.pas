unit _ExportLoadOrder;

interface
  implementation
  uses xEditAPI, mteFunctions, _wotrFunctions, Classes, SysUtils, StrUtils, Windows;

var 
    slLoadOrder : TStringList;
    previousPlugin : string;
  
function Initialize: integer;
begin
    slLoadOrder := TStringList.Create;
    previousPlugin := '';
end;


function Process(e: IInterface): integer;
begin
    if Name(GetFile(e)) <> previousPlugin then
    begin
        slLoadOrder.Add(Name(GetFile(e)));
        previousPlugin := Name(GetFile(e));
    end;
end;

function Finalize: integer;
var folderDirectory : TStringList;
begin
  folderDirectory := TStringList.Create;
  folderDirectory.add('BatchBuilder');
  folderDirectory.add('BatchBuilder\xEditOutput');
  createOutputFolder(folderDirectory);
    if Assigned(slLoadOrder) then begin
        if  (slLoadOrder.Count > 0) then begin
            slLoadOrder.SaveToFile(ProgramPath+'BatchBuilder\xEditOutput\loadorder.csv');
        end;
        slLoadOrder.Free;
    end;
end;
end.