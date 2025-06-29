namespace ZooManagement.Models;

public abstract class Herbivore : Animal
{
    /// <summary>
    /// Kindness level from 0 to 10.
    /// If > 5, the animal can be placed in the petting zoo.
    /// </summary>
    public int Kindness { get; }

    protected Herbivore(string name, int food, int number, int kindness) 
        : base(name, food, number)
    {
        Kindness = kindness;
    }

    public override string ToString() => base.ToString() + $", kindness {Kindness}/10";
}