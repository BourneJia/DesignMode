public interface IEquipment
{
    void Attack();
    void Defend();
    void Add(IEquipment _EquipmentSingle);
    void Remove(IEquipment _EquipmentSingle);
    void Display();
}