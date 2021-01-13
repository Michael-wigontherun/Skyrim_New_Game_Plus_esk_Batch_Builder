unit _ExportPerks;

interface
  implementation
  uses xEditAPI, mteFunctions, _wotrFunctions, Classes, SysUtils, StrUtils, Windows;

var slPerks : TStringList;
  
function Initialize: integer;
begin
  slPerks := TStringList.Create;
  slPerks.Add('PluginName;FormID;PerkName;Description;SkillType;SkillLevel');
end;


function Process(e: IInterface): integer;
begin
  if Signature(e) = 'PERK' then 
  begin
    slPerks.Add(Format('%s;%s;%s;%s;%s', [
        GetMasterFileName(e),
        GetStringFormID(e),
        GetElementEditValues(e, 'FULL - Name'),
        GetElementEditValues(e, 'DESC - Description'),
        GetSkillTypeAndSlillLevel(e)
    ]));
  end;
end;

function GetMasterFileName(e: IInterface):string;
begin
    Result := BaseName(GetFile(Master(e)));
    if BaseName(GetFile(Master(e))) = '' then Result := BaseName(GetFile(e));
end;

function GetSkillTypeAndSlillLevel(e: IInterface) : string;
var
  conditions: IInterface;
  n : integer;
begin
    Result := 'Not sure;999';
    conditions := ElementByPath(e, 'Conditions');
    for n := 0 to ElementCount(conditions) - 1 do
    begin
        if GetElementEditValues(ElementByIndex(conditions, n),'CTDA - CTDA\Function') = 'GetBaseActorValue' then
        begin
            Result := GetElementEditValues(ElementByIndex(conditions, n),'CTDA - CTDA\Actor Value')+';'+ GetElementEditValues(ElementByIndex(conditions, n),'CTDA - CTDA\Comparison Value - Float');
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
  if  Assigned(slPerks) then 
  begin
    if  (slPerks.Count > 1) then begin
      slPerks.SaveToFile(ProgramPath+'BatchBuilder\xEditOutput\PerksList.csv');
    end;
    slPerks.Free;
  end;
 end;

end.