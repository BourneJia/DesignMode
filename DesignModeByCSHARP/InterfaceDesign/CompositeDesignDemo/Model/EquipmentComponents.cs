using System.Collections.Generic;

public class EquipmentComponets : IEquipment
{
    private List<IEquipment> equipmentSingles = new List<IEquipment>();

    public void Attack()
    {
        foreach (var equipmentSingle in equipmentSingles)
        {
            equipmentSingle.Attack();
        }
    }

    public void Defend()
    {
        foreach (var equipmentSingle in equipmentSingles)
        {
            equipmentSingle.Defend();
        }
    }

    public void Display()
    {
        foreach (var equipmentSingle in equipmentSingles)
        {
            equipmentSingle.Display();
        }
    }

    public void Add(IEquipment _EquipmentSingle)
    {
        equipmentSingles.Add(_EquipmentSingle);
    }

    public void Remove(IEquipment _EquipmentSingle)
    {
        equipmentSingles.Remove(_EquipmentSingle);
    }
}