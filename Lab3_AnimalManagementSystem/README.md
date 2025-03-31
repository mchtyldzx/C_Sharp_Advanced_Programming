# Animal Management System

## About This Project
This is my third project for Advanced Programming class. I created a console application to manage different types of animals (herbivores and carnivores). The project demonstrates how to use abstraction through abstract classes and interfaces in C#. It allows users to add animals, feed them, and display their information.

## What I Made
I created different types of animals:

### Main Animal Class
- `Animal` (this is the parent class)
  - Has basic info like name, age, and weight
  - Has a method for displaying animal information

### Different Types of Animals
1. `Sheep`
   - Implements the `IHerbivore` interface
   - Can find and eat plants

2. `Wolf`
   - Implements the `ICarnivore` interface
   - Can find and eat meat

3. `Pig`
   - Implements both `IHerbivore` and `ICarnivore` interfaces
   - Can find and eat both plants and meat

### Animal Manager
- Keeps track of all animals
- Can add animals to the list
- Can feed all herbivores and carnivores
- Can display all animals, herbivores, and carnivores
- Checks for errors when adding animals

## What This Program Do
1. Add different types of animals
2. Feed all herbivores and carnivores
3. See a list of all animals
4. Display all herbivores
5. Display all carnivores
6. Simulate feeding individual animals