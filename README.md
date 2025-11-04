# .NET Core 8 Clean Architecture with CQRS Pattern

A demonstration project showcasing Clean Architecture principles combined with the CQRS (Command Query Responsibility Segregation) pattern using .NET Core 8.

## 🏗️ Architecture Overview

This project implements Clean Architecture with clear separation of concerns across multiple layers:

```
├── MyApp.Core/              # Domain Layer
├── MyApp.Application/       # Application Layer
├── MyApp.Infrastructure/    # Infrastructure Layer
└── MyApp/                   # Presentation Layer (API/Web)
```

## 📋 Project Structure

### MyApp.Core (Domain Layer)
- Contains enterprise business rules and domain entities
- Defines core domain models and business logic
- No dependencies on external libraries or frameworks
- Represents the heart of the application

### MyApp.Application (Application Layer)
- Implements CQRS pattern with Commands and Queries
- Contains application business rules and use cases
- Defines interfaces for infrastructure concerns
- Orchestrates the flow of data between layers
- Depends only on the Core layer

### MyApp.Infrastructure (Infrastructure Layer)
- Implements data persistence and external services
- Contains repository implementations
- Handles database context and migrations
- Implements interfaces defined in Application layer
- Manages external API integrations

### MyApp (Presentation Layer)
- ASP.NET Core Web API/Application
- Controllers and API endpoints
- Dependency injection configuration
- Middleware pipeline setup

## 🎯 Key Patterns & Principles

- **Clean Architecture**: Separation of concerns with dependency rule flowing inward
- **CQRS**: Separation of read and write operations for better scalability
- **Dependency Inversion**: High-level modules don't depend on low-level modules
- **Single Responsibility**: Each layer has a distinct responsibility
- **Domain-Driven Design**: Business logic encapsulated in domain layer

## 🚀 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Visual Studio 2022 or Visual Studio Code
- SQL Server (or your preferred database)

### Installation

1. Clone the repository
```bash
git clone https://github.com/Devikrishna545/.NET-Core8-Clean-Architecture--CQRS-Pattern-.git
```

2. Navigate to the project directory
```bash
cd .NET-Core8-Clean-Architecture--CQRS-Pattern-
```

3. Restore dependencies
```bash
dotnet restore
```

4. Update the connection string in `appsettings.json`

5. Run database migrations
```bash
dotnet ef database update
```

6. Run the application
```bash
dotnet run --project MyApp
```

## 🛠️ Technologies Used

- **.NET Core 8**: Latest version of the .NET platform
- **Entity Framework Core**: ORM for data access
- **MediatR**: Implementation of CQRS and Mediator patterns
- **AutoMapper**: Object-to-object mapping
- **FluentValidation**: Validation library for .NET

## 📦 NuGet Packages

Key packages used in this project:
- MediatR
- AutoMapper
- FluentValidation
- Entity Framework Core
- Swashbuckle (Swagger/OpenAPI)

## 🎓 Learning Resources

This project demonstrates:
- How to structure a .NET Core application using Clean Architecture
- Implementing CQRS pattern for separation of commands and queries
- Dependency injection and inversion of control
- Repository pattern for data access
- Unit of Work pattern
- Domain-driven design principles

## 📝 License

This project is licensed under the MIT License - see the [LICENSE.txt](LICENSE.txt) file for details.

## 🤝 Contributing

Contributions, issues, and feature requests are welcome! Feel free to check the issues page.

## 👨‍💻 Author

**Devikrishna545**
- GitHub: [@Devikrishna545](https://github.com/Devikrishna545)

## ⭐ Show your support

Give a ⭐️ if this project helped you learn Clean Architecture and CQRS!

---

**Happy Coding!** 🚀
