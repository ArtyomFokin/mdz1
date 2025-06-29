using ZooManagement.Models;

namespace ZooManagement.Services;

public class Zoo
{
    private readonly List<Animal> _animals = new();
    private readonly List<Thing> _things = new();

    public void AcceptAnimal(Animal animal, VetClinic clinic)
    {
        if (clinic.CheckHealth(animal))
        {
            _animals.Add(animal);
            Console.WriteLine($"Animal accepted: {animal}");
        }
        else
        {
            Console.WriteLine($"Animal rejected by clinic: {animal.Name}");
        }
    }

    public void AddThing(Thing thing)
    {
        _things.Add(thing);
        Console.WriteLine($"Thing added: {thing}");
    }

    public int TotalFoodPerDay() => _animals.Sum(a => a.Food);

    public IEnumerable<Herbivore> ContactZooAnimals() =>
        _animals.OfType<Herbivore>().Where(h => h.Kindness > 5);

    public void PrintInventory()
    {
        Console.WriteLine("\n=== Inventory Items ===");
        foreach (var item in _things.Cast<object>().Concat(_animals))
        {
            Console.WriteLine(item);
        }
    }
}