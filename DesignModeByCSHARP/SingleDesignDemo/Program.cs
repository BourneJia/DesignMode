using System;

namespace SingleDesignDemo
{
    class Program
    {
        private static SingleDemo singleDemo1,singleDemo2;
        static void Main(string[] args)
        {
            singleDemo1 = SingleDemo.getInstance(1);
            singleDemo2 = SingleDemo.getInstance(2);

            Console.WriteLine(singleDemo1.dice());
            Console.WriteLine(singleDemo2.dice());
            //Console.WriteLine("Hello World!");
        }
    }
}
