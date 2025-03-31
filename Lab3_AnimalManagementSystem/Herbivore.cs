public class Sheep : Animal, IHerbivore
{
    public Sheep(string name, int age, double weight) : base(name, age, weight) { }

    public void FindFood()
    {
        Console.WriteLine($"{Name} is looking for grass.");
    }

    public void EatPlant()
    {
        Console.WriteLine($"{Name} has eaten some grass.");
    }
}