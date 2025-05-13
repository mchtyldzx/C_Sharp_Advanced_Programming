using System;

public abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }

    public Animal(string name, int age, double weight)
    {
        Name = name;
        Age = age;
        Weight = weight;
    }

    public override string ToString()
    {
        return $"{Name}, Age: {Age}, Weight: {Weight} kg";
    }
}

public interface IHerbivore
{
    void FindFood();
    void EatPlant();
}

public interface ICarnivore
{
    void FindFood();
    void EatMeat();
}
