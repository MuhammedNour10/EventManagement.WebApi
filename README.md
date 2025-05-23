📅 EventManagement Web API

EventManagement is a robust and scalable ASP.NET Core Web API application designed to manage and streamline event-related operations such as event creation, registration, user management, and scheduling.

🚀 Features

🔐 Authentication & Authorization using ASP.NET Identity
📅 Event CRUD (Create, Read, Update, Delete)
🧑‍🤝‍🧑 User Registration & Management
📝 Attendee Registration
📊 Dashboard API for Insights
🌐 RESTful API Design
🔍 Filtering & Searching Events
📦 Entity Framework Core Integration
🛠️ Tech Stack

Backend: ASP.NET Core 8 Web API
ORM: Entity Framework Core
Authentication: ASP.NET Identity / JWT
Database: SQL Server / SQLite (configure as needed)
Documentation: Swagger / Swashbuckle
Dependency Injection: Built-in .NET DI container
IDE: Visual Studio / VS Code
⚙️ Getting Started

Prerequisites
.NET 8 SDK
SQL Server or SQLite
Visual Studio or Visual Studio Code


Setup
1-Clone the repository

git clone https://github.com/MuhammedNour10/EventManagement.WebApi.git
cd EventManagement.WebApi 

2-Configure database connection
Update appsettings.json with your DB connection string. 

3-Run migrations 
dotnet ef database update

4-Run the application
dotnet run


🔐 Authentication

This API uses JWT Bearer Tokens for authentication. Use the /api/auth/login endpoint to retrieve a token and include it in the Authorization header of your requests:
Authorization: Bearer <your-token>


🧪 API Testing

Use Postman or Swagger UI for testing endpoints. Ensure you include your JWT token for protected routes. 

🤝 Contributing

Pull requests are welcome! For major changes, please open an issue first to discuss what you would like to change.

