namespace ZooManagement.Models;

public class Monkey : Herbivore
{
    public Monkey(int number, int kindness = 7) 
        : base("Monkey", 3, number, kindness) { }
}