using System;

namespace ProxyDesignDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 创建一个代理对象并发出请求
            Person proxy = new Proxy();
            proxy.BuyProduct();
            Console.Read();
        }
    }

    public abstract class Person
    {
        public abstract void BuyProduct();
    }

    public class RealBuyPerson : Person
    {
        public override void BuyProduct()
        {
            Console.WriteLine("帮我买iPhone11");
        }
    }

    public class Proxy:Person
    {
        RealBuyPerson realBuyPerson;

        public override void BuyProduct()
        {
            Console.WriteLine("通过代理访问真实对象");
            if(realBuyPerson == null)
            {
                realBuyPerson = new RealBuyPerson();
            }

            this.PreBuyProduct();
            realBuyPerson.BuyProduct();
            this.PostBuyProduct();
        }

        public void PreBuyProduct()
        {
            // 可能不知一个朋友叫这位朋友带东西，首先这位出国的朋友要对每一位朋友要带的东西列一个清单等
            Console.WriteLine("我怕弄糊涂了，需要列一张清单，张三：要带相机，李四：要带Iphone...........");
        }

        // 买完东西之后，代理角色需要针对每位朋友需要的对买来的东西进行分类
        public void PostBuyProduct()
        {
            Console.WriteLine("终于买完了，现在要对东西分一下，相机是张三的；Iphone是李四的..........");
        }
    }
}
