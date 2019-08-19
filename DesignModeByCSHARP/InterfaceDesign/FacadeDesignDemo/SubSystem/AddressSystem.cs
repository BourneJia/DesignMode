using System.Threading.Tasks;
using System.IO;
using System;

public struct Address : ISubSystem{
    public string AddressDescription {set;get;}
    public string City {set;get;}
    public string State {set;get;}
    public bool Valid {set;get;}

    const string FileName = "Address.txt";

    public Address(string _AddressDescription, string _City, string _State, bool _Valid){
        AddressDescription = _AddressDescription;
        City = _City;
        State = _State;
        Valid = _Valid;
    }

    public async Task<bool> IsValidAsync(){
        var isValid = false;
        if(Valid){
            isValid = true;
            await File.WriteAllTextAsync($@"{FileName}","地址有效");    
        }
        else
        {
            await File.WriteAllTextAsync($@"{FileName}","地址无效");    
        }
        return isValid;
    }

    public async Task<bool> SaveAsync(){
        var isWrite = false;
        var saveContext = $"地址详情：{AddressDescription}，城市：{City}, 状态：{State}";

        try{
            await File.WriteAllTextAsync($@"Data\{FileName}",saveContext);
            isWrite = true;
        }
        catch(Exception e)
        {
            await File.WriteAllTextAsync($@"Data\{FileName}",e.Message);            
        }
        return isWrite;
    } 

}