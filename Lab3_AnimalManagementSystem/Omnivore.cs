public class Pig : Animal, IHerbivore, ICarnivore
{
    public Pig(string name, int age, double weight) : base(name, age, weight) { }

    public void FindFood()
    {
        Console.WriteLine($"{Name} is looking for food.");
    }

    public void EatPlant()
    {
        Console.WriteLine($"{Name} has eaten some vegetables.");
    }

    public void EatMeat()
    {
        Console.WriteLine($"{Name} has eaten some meat.");
    }
}