using System;
using System.IO;
using System.Threading.Tasks;

public struct Accout : ISubSystem{
    public string FirstName {set;get;}
    public string LastName {set;get;}
    public int Age {set;get;}

    public bool Valid {set;get;}

    const string FileName = "AccoutFile.txt";

    public Accout(string _FirstName,string _LastName,int _Age,bool _Valid)
    {
        FirstName = _FirstName;
        LastName = _LastName;
        Age = _Age;
        Valid = _Valid;
    }

    public async Task<bool> IsValidAsync(){
        var isValid = false;
        if(Valid){
            isValid = true;
            await File.WriteAllTextAsync(@"Data\AccoutFile.txt","账户有效");    
        }
        else
        {
            await File.WriteAllTextAsync(@"Data\AccoutFile.txt","账户无效");    
        }
        return isValid;
    }

    public async Task<bool> SaveAsync(){
        var isWrite = false;
        var saveContext = $"{FirstName} {LastName}, 年龄：{Age}";

        try{
            await File.WriteAllTextAsync($@"{FileName}",saveContext);
            isWrite = true;
        }
        catch(Exception e)
        {
            await File.WriteAllTextAsync($@"{FileName}",e.Message);            
        }
        return isWrite;
    }
}