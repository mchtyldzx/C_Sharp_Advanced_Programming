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
        if (animal is ICarnivore carnivore)
        {
            Carnivores.Add(carnivore);
        }
    }

    public void AddHerbivore(IHerbivore herbivore)
    {
        if (herbivore is Animal animal)
        {
            Animals.Add(animal);
            Herbivores.Add(herbivore);
        }
    }

    public void AddCarnivore(ICarnivore carnivore)
    {
        if (carnivore is Animal animal)
        {
            Animals.Add(animal);
            Carnivores.Add(carnivore);
        }
    }

    public void CopyAnimalsToDietLists()
    {
        foreach (var animal in Animals)
        {
            if (animal is IHerbivore herbivore && !Herbivores.Contains(herbivore))
            {
                Herbivores.Add(herbivore);
            }
            if (animal is ICarnivore carnivore && !Carnivores.Contains(carnivore))
            {
                Carnivores.Add(carnivore);
            }
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

    public static void FeedSingleHerbivore(IHerbivore herbivore)
    {
        herbivore.FindFood();
        herbivore.EatPlant();
    }

    public static void FeedSingleCarnivore(ICarnivore carnivore)
    {
        carnivore.FindFood();
        carnivore.EatMeat();
    }

    public void DisplayAnimals()
    {
        foreach (var animal in Animals)
        {
            Console.WriteLine(animal);
        }
    }

    public void DisplayHerbivores()
    {
        foreach (var herbivore in Herbivores)
        {
            if (herbivore is Animal animal)
            {
                Console.WriteLine(animal);
            }
        }
    }

    public void DisplayCarnivores()
    {
        foreach (var carnivore in Carnivores)
        {
            if (carnivore is Animal animal)
            {
                Console.WriteLine(animal);
            }
        }
    }

    public Animal? FindAnimalByName(string name)
    {
        return Animals.Find(a => a.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }
}
