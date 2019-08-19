using System;
using System.Collections.Generic;

//抽象订阅号西山居游戏
public abstract class XSJGame
{
    private List<IObserver> observers = new List<IObserver>();

    public String Symbol {get;set;}

    public string Info {get;set;}

    public XSJGame(string _Symbol,string _Info)
    {
        Symbol = _Symbol;
        Info = _Info;
    }

    public void AddObserver(IObserver _IObserver)
    {
        observers.Add(_IObserver);
    }

    public void RemoveObserver(IObserver _IObserver)
    {
        observers.Remove(_IObserver);
    }

    public void Update()
    {
        foreach (var observer in observers)
        {
            if(null != observer)
            {
                observer.ReceiveAndPrintData(this);
            }
        }
    }
}

//具体的订阅号剑网3
public class XSJJW3 : XSJGame 
{
    public XSJJW3(string _Symbol,string _Info) : base(_Symbol,_Info)
    {

    }
}

//订阅者接口
public interface IObserver
{
    void ReceiveAndPrintData(XSJGame xsjGame);
}

//具体订阅者
public class Subscriber : IObserver
{
    public string Name {get;set;}

    public Subscriber(string _Name)
    {
        Name = _Name;
    }

    public void ReceiveAndPrintData(XSJGame xsjGame)
    {
        Console.WriteLine($"Notified {Name} of {xsjGame.Symbol}'s, Info is: {xsjGame.Info}");
    }
}