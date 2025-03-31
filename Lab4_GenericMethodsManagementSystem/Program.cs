using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Test 1: Swap method
        int a = 5, b = 10;
        Console.WriteLine($"Before swap: a={a}, b={b}");
        GenericMethods.Swap(ref a, ref b);
        Console.WriteLine($"After swap: a={a}, b={b}");

        // Test 2: Display and reset method
        string str = "Hello";
        int num = 42;
        GenericMethods.DisplayAndReset(ref str, ref num); // ref ekledim

        // Test 3: Create instance method
        var newPerson = GenericMethods.CreateInstance<Person>();
        Console.WriteLine($"Created person: {newPerson}");

        // Test 4: Compare method
        int max = GenericMethods.GetMax(5, 10);
        Console.WriteLine($"Max value: {max}");

        // Test 5: Sort params method
        var sortedList = GenericMethods.SortParams(5, 2, 8, 1, 9);
        Console.WriteLine($"Sorted list: {string.Join(", ", sortedList)}");

        // Test 6: Create dictionary method
        var dict = GenericMethods.CreateDictionary(1, "One");
        Console.WriteLine("Created dictionary:");
        GenericMethods.DisplayDictionary(dict);

        // Test 7: Return collection based on count
        var collection1 = GenericMethods.ReturnCollection(1, 2);
        var collection2 = GenericMethods.ReturnCollection(1, 2, 3);
        Console.WriteLine($"Collection1 type: {collection1.GetType().Name}");
        Console.WriteLine($"Collection2 type: {collection2.GetType().Name}");

        // Test Person class
        var person1 = new Person("Mucahit", "Yildiz", 23);
        person1.AddCar(new Car("Toyota", 25000));
        person1.AddCar(new Car("Honda", 20000));

        var person2 = new Person("Jane", "Margolis", 25);
        person2.AddCar(new Car("BMW", 45000));

        Console.WriteLine("\nPerson1's cars:");
        foreach (var car in person1)
        {
            Console.WriteLine(car);
        }

        var people = new List<Person> { person1, person2 };
        people.Sort();
        Console.WriteLine("\nSorted people by total car value:");
        foreach (var person in people)
        {
            Console.WriteLine(person);
        }

        // Test Quadruple class
        var quadruples = new List<Quadruple<int, string, double, bool>>
        {
            new Quadruple<int, string, double, bool>(3, "Three", 3.14, true),
            new Quadruple<int, string, double, bool>(1, "One", 1.41, false),
            new Quadruple<int, string, double, bool>(2, "Two", 2.71, true)
        };

        quadruples.Sort();
        Console.WriteLine("\nSorted quadruples by ID:");
        foreach (var quad in quadruples)
        {
            Console.WriteLine(quad);
        }
    }
}