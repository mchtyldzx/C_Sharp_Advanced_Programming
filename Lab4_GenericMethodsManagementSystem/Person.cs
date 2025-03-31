using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Person : IEnumerable<Car>, IComparable<Person>
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Age { get; set; }
    private List<Car> Cars { get; set; }

    public Person()
    {
        Cars = new List<Car>();
    }

    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Cars = new List<Car>();
    }

    public void AddCar(Car car)
    {
        Cars.Add(car);
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}, Age: {Age}, Cars: {string.Join(", ", Cars)}";
    }

    public IEnumerator<Car> GetEnumerator()
    {
        return Cars.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public int CompareTo(Person? other)
    {
        if (other == null) return 1;
        decimal thisTotalValue = Cars.Sum(c => c.Price);
        decimal otherTotalValue = other.Cars.Sum(c => c.Price);
        return thisTotalValue.CompareTo(otherTotalValue);
    }
}