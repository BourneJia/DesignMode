using System;

namespace CompositeDesignDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //武器组合模式
            EquipmentAttack();

        }

       static void EquipmentAttack(){
            //单个武器出现
            IEquipment Swords = new EquipmentSingle("剑");
            IEquipment Knife = new EquipmentSingle("刀");
            IEquipment Arrow = new EquipmentSingle("箭");

            //进行武器组合打包使用
            IEquipment equipmentComponets = new EquipmentComponets();
            equipmentComponets.Add(Swords);
            equipmentComponets.Add(Knife);
            equipmentComponets.Add(Arrow);

            //组合武器攻击
            equipmentComponets.Attack();

            //单个武器攻击
            Swords.Attack();
        }
    }
}
