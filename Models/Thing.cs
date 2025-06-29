using ZooManagement.Models.Interfaces;

namespace ZooManagement.Models;

public abstract class Thing : IInventory
{
    public string Name { get; }
    public int Number { get; }

    protected Thing(string name, int number)
    {
        Name = name;
        Number = number;
    }

    public override string ToString() => $"{Name} (#{Number})";
}