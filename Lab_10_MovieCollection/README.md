# Movie Collection

## About

Movie Collection is a web application that allows users to manage their personal movie collections digitally. The application uses Entity Framework Core for database operations and integrates with SQL Server LocalDB.

## Features

- Movie listing and details
- Add, edit, and delete movies
- Data persistence with SQL Server
- Initial data seeding
- Rating system for movies

## Project Structure

The project follows the standard MVC architecture:
- **Models**: Data entities (`Movie`, `MovieContext`)
- **Views**: User interface (`.cshtml` files)
- **Controllers**: Business logic (`MoviesController`, `HomeController`)

## Database Schema

The application uses a Movie model with properties such as Id, Title, ReleaseDate, Genre, Price, and Rating.

To ensure the database has initial data, the SeedData class checks if any movie entries exist and, if not; automatically inserts a predefined set of movies during application startup.

## Technologies Used

- ASP.NET Core
- Entity Framework Core
- SQL Server LocalDB
- Bootstrap
- HTML/CSS

## Setup

1. Clone the repository
1. Navigate to the project directory
3. Install dependencies: `dotnet restore`
4. Create database: `dotnet ef database update`
5. Run the application: `dotnet run`
6. Visit: `http://localhost:5001`
