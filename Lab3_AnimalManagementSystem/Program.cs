using System;

class Program
{
    static void Main(string[] args)
    {
        ZooManager zoo = new ZooManager();

        // Add animals
        zoo.AddAnimal(new Sheep("Batu", 3, 45.5));
        zoo.AddAnimal(new Pig("Mubo", 2, 60.0));
        zoo.AddAnimal(new Wolf("Emo", 5, 80.0));

        // Show all animals
        Console.WriteLine("All Animals in the Zoo:");
        zoo.DisplayAnimals();

        // Feed herbivores
        Console.WriteLine("\nFeeding Herbivores:");
        zoo.FeedHerbivores();

        // Feed carnivores
        Console.WriteLine("\nFeeding Carnivores:");
        zoo.FeedCarnivores();
    }
}
