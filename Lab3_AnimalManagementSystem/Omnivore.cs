public class Pig : Animal, IHerbivore, ICarnivore
{
    public Pig(string name, int age, double weight) : base(name, age, weight) { }

    void IHerbivore.FindFood()
    {
        Console.WriteLine($"{Name} is looking for vegetables.");
    }

    void ICarnivore.FindFood()
    {
        Console.WriteLine($"{Name} is looking for meat.");
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
