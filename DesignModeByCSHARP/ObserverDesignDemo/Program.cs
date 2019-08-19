using System;

namespace ObserverDesignDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            XSJGame xsjGame = new XSJJW3("剑网3", "指尖江湖发布");

            xsjGame.AddObserver(new Subscriber("玩家1"));
            xsjGame.AddObserver(new Subscriber("玩家2"));

            xsjGame.Update();

            Console.ReadLine();
        }
    }
}
