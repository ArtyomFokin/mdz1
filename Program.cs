using ZooManagement.Models;
using ZooManagement.Services;

var zoo = new Zoo();
var clinic = new VetClinic();

Console.WriteLine("Simple Zoo ERP (demo)\n");
bool running = true;
while (running)
{
    Console.WriteLine("\nSelect action:");
    Console.WriteLine("1) Add animal");
    Console.WriteLine("2) Add thing");
    Console.WriteLine("3) Show food summary");
    Console.WriteLine("4) Show contact‑zoo animals");
    Console.WriteLine("5) Show inventory");
    Console.WriteLine("0) Exit");
    Console.Write("Your choice: ");
    var choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            AddAnimal();
            break;
        case "2":
            AddThing();
            break;
        case "3":
            Console.WriteLine($"Total food required per day: {zoo.TotalFoodPerDay()} kg");
            break;
        case "4":
            var contact = zoo.ContactZooAnimals().ToList();
            Console.WriteLine(contact.Any()
                ? "Animals for contact zoo:\n" + string.Join('\n', contact)
                : "No animals eligible for contact zoo yet.");
            break;
        case "5":
            zoo.PrintInventory();
            break;
        case "0":
            running = false;
            break;
        default:
            Console.WriteLine("Unknown option.");
            break;
    }
}

void AddAnimal()
{
    Console.WriteLine("Choose animal type: 1‑Rabbit 2‑Monkey 3‑Tiger 4‑Wolf");
    var t = Console.ReadLine();
    Console.Write("Inventory number: ");
    int.TryParse(Console.ReadLine(), out var num);

    Animal? animal = t switch
    {
        "1" => new Rabbit(num),
        "2" => new Monkey(num),
        "3" => new Tiger(num),
        "4" => new Wolf(num),
        _ => null
    };

    if (animal is not null)
        zoo.AcceptAnimal(animal, clinic);
    else
        Console.WriteLine("Invalid animal type.");
}

void AddThing()
{
    Console.WriteLine("Choose thing type: 1‑Table 2‑Computer");
    var t = Console.ReadLine();
    Console.Write("Inventory number: ");
    int.TryParse(Console.ReadLine(), out var num);

    Thing? thing = t switch
    {
        "1" => new Table(num),
        "2" => new Computer(num),
        _ => null
    };

    if (thing is not null)
        zoo.AddThing(thing);
    else
        Console.WriteLine("Invalid thing type.");
}