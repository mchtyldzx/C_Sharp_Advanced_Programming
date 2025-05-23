# Recipe Manager

## About

**Recipe Manager** is a web application that allows users to manage recipes, categories, and ingredients. It is built using ASP.NET Core MVC with Entity Framework Core following a code-first approach.

## Features

- CRUD for Recipes, Categories, and Ingredients
- Search, sort, and paginate recipes
- Add/remove recipes to/from favorites
- View recipes by category
- Statistics: number of recipes per category

## Project Structure

- **Models**: `Category`, `Recipe`, `Ingredient`
- **Views**: Razor views for CRUD and navigation
- **Controllers**: Handle app logic (e.g. `RecipesController`)
- **Helpers**: `PaginatedList<T>` for paging
- **ViewModels**: e.g. for statistics summary

## Database Schema

- One `Category` has many `Recipes`
- One `Recipe` has many `Ingredients`
- Each `Recipe` has a boolean `IsFavorite`

```csharp
public class Recipe
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public ICollection<Ingredient> Ingredients { get; set; }
    public bool IsFavorite { get; set; }
}
```

## Technologies Used

- ASP.NET Core MVC (.NET 8)
- Entity Framework Core
- SQL Server LocalDB
- Bootstrap
- HTML/CSS, C#

## Setup

1. Clone this repository
2. Navigate to the project directory
3. Restore dependencies:
    ```bash
    dotnet restore
    ```
4. Apply migrations and create database:
    ```bash
    dotnet ef database update
    ```
5. Run the project:
    ```bash
    dotnet run
    ```
6. Open your browser and navigate to:
    [http://localhost:5113](http://localhost:5113)