
public class Wolf : Animal, ICarnivore
{
    public Wolf(string name, int age, double weight) : base(name, age, weight) { }

    public void FindFood()
    {
        Console.WriteLine($"{Name} is looking for prey.");
    }

    public void EatMeat()
    {
        Console.WriteLine($"{Name} has eaten some meat.");
    }
}