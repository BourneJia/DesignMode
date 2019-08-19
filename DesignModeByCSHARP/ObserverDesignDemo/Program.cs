using System;

namespace ObserverDesignDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Subscriber scriber = new Subscriber("GameFun");
            XSJGame xsjGame = new XSJGame();

            xsjGame.Subscriber = scriber;
            xsjGame.Symbol = "XSJ GAME";
            xsjGame.Info = "Have a new game published ....";

            xsjGame.Update();

            Console.ReadLine();
        }
    }
}
