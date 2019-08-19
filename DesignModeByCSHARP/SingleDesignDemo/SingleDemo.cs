using System;

namespace SingleDesignDemo
{
    public class SingleDemo
    {
        private static SingleDemo demo1 = new SingleDemo();
        private static SingleDemo demo2 = new SingleDemo();

        private SingleDemo()
        {

        }

        public static SingleDemo getInstance(int whichOne)
        {
            if ( whichOne == 1)
            {
                return demo1;
            }
            else
            {
                return demo2;
            }
        }

        public int dice()
        {
            DateTime d = new DateTime();

            Random r = new Random(d.Day);
            int value = r.Next();

            value = Math.Abs(value);
            value = value % 6;//取模

            value += 1;
            return value;
        }

    }
}