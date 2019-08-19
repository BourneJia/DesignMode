using System;

namespace FacadeDesignDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client;

            client.FacadeWayAsync();

            //client.CommonWayAsync();
            
            Console.ReadLine();//持续运行，防止进行线程退出
        }
    }
}
