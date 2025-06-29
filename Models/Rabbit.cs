namespace ZooManagement.Models;

public class Rabbit : Herbivore
{
    public Rabbit(int number, int kindness = 6) 
        : base("Rabbit", 1, number, kindness) { }
}