using System;

namespace BridgeDesignDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Brush bigBrush = new BigBrush();

            bigBrush.SetColor(new Red());

            bigBrush.Paint();

            Console.ReadLine();
        }
    }

}
