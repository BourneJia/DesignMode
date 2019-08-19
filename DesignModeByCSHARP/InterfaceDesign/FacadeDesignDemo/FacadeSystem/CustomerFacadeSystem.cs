using System;
using System.Threading.Tasks;

public struct CustomerFacade{
    public string FirstName {set;get;}
    public string LastName {set;get;}
    public int Age {set;get;}
    public bool ValidAccout {set;get;}
    public string AddressDescription {set;get;}
    public string City {set;get;}
    public string State {set;get;}
    public bool ValidAddress {set;get;}
    public string CreditType {get;set;}
    public int CardNumber {get;set;}
    public string CardExpDate {get;set;}
    public bool ValidCard {get;set;}

    public CustomerFacade(string _FirstName, string _LastName, int _Age, bool _ValidAccout,
                          string _AddressDescription, string _City, string _State, bool _ValidAddress,
                          string _CreditType, int _CardNumber, string _CardExpDate, bool _ValidCard)
    {
        FirstName = _FirstName;
        LastName = _LastName;
        Age = _Age;
        ValidAccout = _ValidAccout;
        AddressDescription = _AddressDescription;
        City = _City;
        State = _State;
        ValidAddress = _ValidAddress;
        CreditType = _CreditType;
        CardNumber = _CardNumber;
        CardExpDate = _CardExpDate;
        ValidCard = _ValidCard;
    }

    public async Task<bool> UnifiedCertification()
    {
        var isOk = false;
        ISubSystem ISubSystemAccout = new Accout(FirstName,LastName,Age,ValidAccout);
        ISubSystem ISubSystemAddress = new Address(AddressDescription,City,State,ValidAddress); 
        ISubSystem ISubSystemCreditCard = new CreditCard(CreditType,CardNumber,CardExpDate,ValidCard);

        if(
           (await ISubSystemAccout.IsValidAsync()) && (await ISubSystemAddress.IsValidAsync()) &&
           (await ISubSystemCreditCard.IsValidAsync())
          )
        {
            Console.WriteLine("认证成功");
            isOk = true;
        }
        else 
        {
            Console.WriteLine("认证失败");
        }
        return isOk;
    }

    public async Task<bool> UnifiedWriteTxT()
    {
        var isOk = false;
        ISubSystem ISubSystemAccout = new Accout(FirstName,LastName,Age,ValidAccout);
        ISubSystem ISubSystemAddress = new Address(AddressDescription,City,State,ValidAddress); 
        ISubSystem ISubSystemCreditCard = new CreditCard(CreditType,CardNumber,CardExpDate,ValidCard);

        if(
           (await ISubSystemAccout.SaveAsync()) && (await ISubSystemAddress.SaveAsync()) && 
           (await ISubSystemCreditCard.SaveAsync())
          )
        {
            Console.WriteLine("写入成功");
            isOk = true;
        }
        else 
        {
            Console.WriteLine("写入失败");
            isOk = false;
        }

        return isOk;
    }
}