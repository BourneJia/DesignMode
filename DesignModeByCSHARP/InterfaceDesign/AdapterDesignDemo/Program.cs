using System;

namespace AdapterDesignDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //XML适配器 XMLA To XMLB (XMLB实现XMLA需要的接口方法，但是方法名不同，需要适配器修改)
            XMLAdapter _XMLAdapter = new XMLAdapter();
            _XMLAdapter.XMLRead();

            //电压适配器 需要适配器修改220电压为110电压
            DianYa220 _DianYa220 = new DianYa220();
            DianYaAdapter _DianYaAdapter = new DianYaAdapter(_DianYa220);
            _DianYaAdapter.DianYa220ToDianYa110();

            //类适配器以及对象适配器
            ClientDemo _ClientDemo = new ClientDemo();
            _ClientDemo.TestClassAdapter();//类适配器
            _ClientDemo.TestObjectAdapter();//对象适配器
        }
    }
}