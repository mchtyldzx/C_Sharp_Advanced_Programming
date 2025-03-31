using System;
using System.Collections.Generic;

public class ZooManager
{
    public List<Animal> Animals { get; private set; } = new List<Animal>();
    public List<IHerbivore> Herbivores { get; private set; } = new List<IHerbivore>();
    public List<ICarnivore> Carnivores { get; private set; } = new List<ICarnivore>();

    public void AddAnimal(Animal animal)
    {
        Animals.Add(animal);
        if (animal is IHerbivore herbivore)
        {
            Herbivores.Add(herbivore);
        }
        else if (animal is ICarnivore carnivore)
        {
            Carnivores.Add(carnivore);
        }
    }

    public void FeedHerbivores()
    {
        foreach (var herbivore in Herbivores)
        {
            herbivore.FindFood();
            herbivore.EatPlant();
        }
    }

    public void FeedCarnivores()
    {
        foreach (var carnivore in Carnivores)
        {
            carnivore.FindFood();
            carnivore.EatMeat();
        }
    }

    public void DisplayAnimals()
    {
        foreach (var animal in Animals)
        {
            Console.WriteLine(animal);
        }
    }
}