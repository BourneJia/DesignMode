using System;

public class DianYaAdapter
{
    private DianYa220 dianYa220;

    public DianYaAdapter(DianYa220 _DianYa220){
        dianYa220 = _DianYa220;
    }

    public void DianYa220ToDianYa110()
    {
        dianYa220.ConsoleDianYa220();
        Console.WriteLine("开始进行电压转换");
        DianYa110 _DianYa220 = new DianYa110();
        Console.WriteLine("220 -> 110");
        _DianYa220.ConsoleDianYa110();
    }
}