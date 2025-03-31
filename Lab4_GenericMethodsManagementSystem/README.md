# Generic Methods and Object Management System

## About This Project
This is my fourth project for the Advanced Programming class. I created a console application that demonstrates the use of generic methods and object management in C#. The project includes various functionalities such as swapping values, creating instances, managing collections, and handling custom objects like cars and people.

## What I Made
I implemented several classes and methods to showcase the power of generics in C#:

### Generic Methods Class
- `GenericMethods`
  - Contains various generic methods for:
    - Swapping values of two parameters
    - Displaying and resetting values
    - Creating instances of specified types
    - Comparing values to find the maximum
    - Sorting a list of items
    - Creating and displaying dictionaries
    - Returning collections based on the number of parameters

### Car Class
- `Car`
  - Represents a car with properties like brand and price
  - Overrides the `ToString()` method to display car information

### Person Class
- `Person`
  - Represents a person with properties like first name, last name, age, and a list of cars
  - Implements `IEnumerable<Car>` to allow iteration over the list of cars
  - Implements `IComparable<Person>` to compare persons based on the total value of their cars

### Quadruple Class
- `Quadruple<T1, T2, T3, T4>`
  - A generic class that holds four variables of different types
  - Implements `IComparable<Quadruple<T1, T2, T3, T4>>` to allow sorting based on the first variable

## What This Program Does
1. Swaps values of two variables using a generic method.
2. Displays and resets values of different types.
3. Creates instances of specified types using a generic method.
4. Compares two values to find the maximum.
5. Sorts a list of items and displays the sorted result.
6. Creates a dictionary with specified key and value types and displays its contents.
7. Returns a collection (queue or stack) based on the number of parameters provided.
8. Manages a list of `Person` objects and their associated `Car` objects, allowing for sorting and displaying information.