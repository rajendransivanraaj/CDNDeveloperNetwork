# CDNDeveloperNetwork


This is a RESTful API project for managing users in a developer network.

## Introduction

CDNDeveloperNetwork is a project aimed at facilitating user management within a developer network. It provides endpoints to retrieve, create, update, and delete user information.

## Technologies Used

- ASP.NET Core
- Entity Framework Core
- SQL Server
- HTML/CSS
- JavaScript

## Project Structure

- `Controllers/`: Contains the API controllers.
- `Data/`: Includes the database context and migrations.
- `Migrations/`: Database migration files.
- `Models/`: Defines the data models.
- `Pages/`: Contains Razor pages.
- `wwwroot/`: Static web assets.
- `appsettings.json`: Configuration settings.
- `Program.cs` and `Startup.cs`: Entry points and configuration for the ASP.NET Core application.

## How to Use

1. Clone this repository.
2. Update the connection string in `appsettings.json` with your SQL Server details.
3. Run `dotnet ef database update` to apply the database migrations.
4. Run the project using `dotnet run`.

## Endpoints

### GET /api/user

Retrieves a list of all users.

Response:
```json
["user1", "user2", "user3"]

POST /api/user
Creates a new user.

Request Body:

{
  "username": "newuser",
  "email": "newuser@example.com",
  "phoneNumber": "123-456-7890",
  "skillsets": "C#, ASP.NET Core",
  "hobby": "Coding"
}
Response:

{
  "id": 4,
  "username": "newuser",
  "email": "newuser@example.com",
  "phoneNumber": "123-456-7890",
  "skillsets": "C#, ASP.NET Core",
  "hobby": "Coding"
}


PUT /api/user/{id}
Updates an existing user.

Request Body:


{
  "id": 1,
  "username": "updateduser",
  "email": "updateduser@example.com",
  "phoneNumber": "987-654-3210",
  "skillsets": ".NET, ASP.NET Core",
  "hobby": "Reading"
}


DELETE /api/user/{id}
Deletes a user with the specified ID.

Contributing
Contributions are welcome! Please follow the contribution guidelines.
