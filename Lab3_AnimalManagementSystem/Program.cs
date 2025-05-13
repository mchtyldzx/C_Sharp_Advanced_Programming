using System;

class Program
{
    static void Main(string[] args)
    {
        ZooManager zoo = new ZooManager();

        // Add animals using different methods
        Console.WriteLine("Adding animals using different methods:");
        
        // Using AddAnimal
        zoo.AddAnimal(new Sheep("Batu", 3, 45.5));
        
        // Using AddHerbivore
        var pig = new Pig("Mubo", 2, 60.0);
        zoo.AddHerbivore(pig);
        
        // Using AddCarnivore
        var wolf = new Wolf("Emo", 5, 80.0);
        zoo.AddCarnivore(wolf);

        // Copy animals to diet lists
        Console.WriteLine("\nCopying animals to diet lists:");
        zoo.CopyAnimalsToDietLists();

        // Show all animals
        Console.WriteLine("\nAll Animals in the Zoo:");
        zoo.DisplayAnimals();

        // Show herbivores
        Console.WriteLine("\nHerbivores in the Zoo:");
        zoo.DisplayHerbivores();

        // Show carnivores
        Console.WriteLine("\nCarnivores in the Zoo:");
        zoo.DisplayCarnivores();

        // Feed herbivores
        Console.WriteLine("\nFeeding Herbivores:");
        zoo.FeedHerbivores();

        // Feed carnivores
        Console.WriteLine("\nFeeding Carnivores:");
        zoo.FeedCarnivores();

        // Feed single animals
        Console.WriteLine("\nFeeding Single Animals:");
        var sheep = zoo.FindAnimalByName("Batu") as IHerbivore;
        if (sheep != null)
        {
            Console.WriteLine("\nFeeding single herbivore:");
            ZooManager.FeedSingleHerbivore(sheep);
        }

        var foundWolf = zoo.FindAnimalByName("Emo") as ICarnivore;
        if (foundWolf != null)
        {
            Console.WriteLine("\nFeeding single carnivore:");
            ZooManager.FeedSingleCarnivore(foundWolf);
        }
    }
}
