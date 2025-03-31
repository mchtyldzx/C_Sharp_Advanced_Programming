# Document Management System

## About This Project
This is my second project for Advanced Programming class. I made a simple library to manage different types of documents (books, magazines, volumes) and a console program to test it. The project shows how to use inheritance, polymorphism, and exception handling in C#.

## What I Made
I created different types of documents:

### Main Document Class
- `Document` (this is the parent class)
  - Has basic info like ISBN, title, year, pages
  - Has methods for printing and comparing documents

### Different Types of Documents
1. `Book`
   - Has author information
   - Checks if year is after printing invention (1440)

2. `Volume`
   - Shows which volume number it is
   - Checks if volume number is valid

3. `Magazine`
   - Has issue number
   - Shows how often it comes out (daily, weekly, monthly, yearly)

### Document Manager
- Keeps track of all documents
- Can find documents by ISBN
- Can search documents by title
- Can find magazines by how often they come out
- Checks for errors like:
  - Same ISBN twice
  - Books before printing was invented
  - Wrong volume numbers

## What This Program Do
1. Add different types of documents
2. See list of all documents
3. Find documents by ISBN
4. Search documents by title
5. Find magazines by how often they come out
6. Print documents (simulated)
7. See error messages when something goes wrong

## Technical Stuff I Used
- Object-Oriented Programming ideas:
  - Inheritance (parent-child classes)
  - Polymorphism (different ways to print)
  - Abstract classes and methods
  - Properties and methods
- Exception handling
- Console colors to make it look nice
- Lists to store documents

## What Is Needed To Run This
- .NET 6.0 (or newer)
- Visual Studio 2022 (Community Edition is fine)

Mücahit Yıldız