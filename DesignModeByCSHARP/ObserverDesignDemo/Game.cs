using System;

public class XSJGame
{
    public Subscriber Subscriber {get;set;}

    public String Symbol {get;set;}

    public string Info {get;set;}

    public void Update()
    {
        if(Subscriber != null)
        {
            Subscriber.ReceiveAndPrintData(this);
        }
    }
}

public class Subscriber
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