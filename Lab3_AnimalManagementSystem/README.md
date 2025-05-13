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
- Keeps track of all animals in separate lists:
  - Main animals list
  - Herbivores list
  - Carnivores list
- Multiple ways to add animals:
  - `AddAnimal()`: Add any type of animal
  - `AddHerbivore()`: Add specifically herbivorous animals
  - `AddCarnivore()`: Add specifically carnivorous animals
- Can copy animals between lists using `CopyAnimalsToDietLists()`
- Feeding capabilities:
  - Feed all herbivores at once
  - Feed all carnivores at once
  - Feed individual herbivores
  - Feed individual carnivores
- Display functions:
  - Show all animals
  - Show only herbivores
  - Show only carnivores
- Can find animals by name using `FindAnimalByName()`

## What This Program Does
1. Add different types of animals using various methods
2. Copy animals between different diet lists
3. Feed all herbivores and carnivores
4. Feed individual animals
5. See a list of all animals
6. Display all herbivores
7. Display all carnivores
8. Find specific animals by name
9. Simulate feeding individual animals
