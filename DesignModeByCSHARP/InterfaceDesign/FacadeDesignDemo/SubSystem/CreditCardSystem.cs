using System;
using System.IO;
using System.Threading.Tasks;

public struct CreditCard : ISubSystem{
    public string CreditType {get;set;}
    public int CardNumber {get;set;}
    public string CardExpDate {get;set;}
    public bool Valid {get;set;}

    const string FileName = "Credit.txt";

    public CreditCard(string _CreditType, int _CardNumber, string _CardExpDate, bool _Valid){
        CreditType = _CreditType;
        CardNumber = _CardNumber;
        CardExpDate = _CardExpDate;
        Valid = _Valid;
    }

    public async Task<bool> IsValidAsync(){
        var isValid = false;
        if(Valid){
            isValid = true;
            await File.WriteAllTextAsync($@"{FileName}","卡片有效");    
        }
        else
        {
            await File.WriteAllTextAsync($@"{FileName}","卡片无效");    
        }
        return isValid;
    }

    public async Task<bool> SaveAsync(){
        var isWrite = false;
        var saveContext = $"卡片类型：{CreditType}, 卡片数目：{CardNumber}, 卡片日期：{CardExpDate},";

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