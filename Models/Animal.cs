using ZooManagement.Models.Interfaces;

namespace ZooManagement.Models;

public abstract class Animal : IAlive, IInventory
{
    public string Name { get; }
    public int Food { get; }
    public int Number { get; }

    protected Animal(string name, int food, int number)
    {
        Name = name;
        Food = food;
        Number = number;
    }

    public override string ToString() => $"{Name} (#{Number}) – {Food} kg/day";
}