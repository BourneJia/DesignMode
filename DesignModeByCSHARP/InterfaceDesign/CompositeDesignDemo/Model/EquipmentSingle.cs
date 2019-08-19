using System;

public class EquipmentSingle : IEquipment
{
    public string name{get;set;}

    public EquipmentSingle(string _name)
    {
        name = _name;
    }

    public virtual void Attack()
    {
        Console.WriteLine("This is a Attack(normol)");
        Console.WriteLine(name + "Attack");
    }

    public virtual void Defend()
    {
        Console.WriteLine("This is a Defend(normol)");
        Console.WriteLine(name + "Defend");
    }

    public virtual void Add(IEquipment _EquipmentSingle){}
    public virtual void Remove(IEquipment _EquipmentSingle){}
    public virtual void Display()
    {
        Console.WriteLine("This is a Display(normol)");
        Console.WriteLine(name + "Display");
    }
}