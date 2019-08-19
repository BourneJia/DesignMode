using System;
using System.Threading.Tasks;

public struct Client
{
    public async void FacadeWayAsync()
    {
        Console.WriteLine("进入FacadeWay方法...调用FacadeWay");
        string firstName = "张",lastName = "三丰",addressDescription = "武当",city = "十堰市",state = "中国",carditType = "掌门",cardExpDate="9999-99-99";
        int age = 100,cardNumber = 100;
        bool validAccout = true,validAddress = true,validCard = true;       
        
        CustomerFacade customerFacade = new CustomerFacade(firstName,lastName,age,validAccout,
                                                           addressDescription,city,state,validAddress,
                                                           carditType,cardNumber,cardExpDate,validCard);

        var isOk = await customerFacade.UnifiedWriteTxT();

        if(isOk)
        {
            Console.WriteLine("OK");
        }
        else
        {
            Console.WriteLine("OK");
        }

        Console.WriteLine("FacadeWay方法结束...");
    }

    public async void CommonWayAsync()
    {
        Console.WriteLine("进入CommonWay方法...直接调用SubWay");
        string firstName = "张",lastName = "三丰",addressDescription = "武当",city = "十堰市",state = "中国",carditType = "掌门",cardExpDate="9999-99-99";
        int age = 100,cardNumber = 100;
        bool validAccout = true,validAddress = true,validCard = true;

        ISubSystem ISubSystemAccout = new Accout(firstName,lastName,age,validAccout);
        ISubSystem ISubSystemAddress = new Address(addressDescription,city,state,validAddress); 
        ISubSystem ISubSystemCreditCard = new CreditCard(carditType,cardNumber,cardExpDate,validCard);

        if(
           (await ISubSystemAccout.SaveAsync()) && (await ISubSystemAddress.SaveAsync()) && 
           (await ISubSystemCreditCard.SaveAsync())
          )
        {
            Console.WriteLine("CommonWay写入成功");
        }
        else 
        {
            Console.WriteLine("CommonWay写入失败");
        }

    }
}