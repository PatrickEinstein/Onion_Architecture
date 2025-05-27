# 🧵 Onion Architecture .NET 8 API Boilerplate

This project provides a clean, scalable **Onion Architecture** template for building ASP.NET Core Web APIs using **.NET 8**. It encourages separation of concerns, testability, and flexibility across layers.

---

## 📁 Project Structure

```
MySolution/
├── Auth.Api            → Presentation layer (entry point)
├── Auth.Core     → Business logic (services, use-cases)
├── Auth.Data          → Entities and Repositories (pure logic)
├── Auth.Infrastructure  → Database Configuration and Service access
├── Auth.sln             → Solution file
```

---

## ⚙️ Technologies

* ✅ ASP.NET Core 8
* ✅ Entity Framework Core
* ✅ PostgreSQL (or any RDBMS)
* ✅ Swagger/OpenAPI
* ✅ Dependency Injection (DI)
* ✅ AutoMapper
* ✅ Clean and testable architecture

---

## 🚀 Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/PatrickEinstein/Onion_Architecture.git onion-architecture-api
cd onion-architecture-api
```

### 2. Navigate to the API Project

```bash
cd Auth.Api
```

### 3. Update Connection String

Edit `appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Port=5432;Database=mydb;Username=postgres;Password=password"
}
```

> 💡 You can also use environment variables or user secrets.

---

### 4. Run Database Migrations

```bash
dotnet ef database update --project ../Auth.Infrastructure
```

---

### 5. Run the Application

```bash
dotnet run
```

---

### 6. Access Swagger

Visit:

```
https://localhost:/7124/index.html → if running locally with HTTPS
```

Swagger UI will list all your endpoints and allow testing.

---

## 🔌 Project Responsibilities

### ✅ `Auth.Api`

* Configures middleware (Swagger, HTTPS, routing, etc.)
* Maps controller endpoints
* Injects Application & Infrastructure layers

### ✅ `Auth.Core`

* Business rules
* Interfaces for services
* DTOs / ViewModels

### ✅ `Auth.Data`

* Entity definitions
* Pure interfaces
* Enums, constants, core logic

### ✅ `Auth.Infrastructure`

* EF Core DbContext
* Repositories
* External services (e.g., Email, Payment)


---

## 📌 Credits

Inspired by clean architecture patterns and Onion Architecture principles from:

* [Robert C. Martin](https://blog.cleancoder.com/)
* [Jason Taylor's Clean Architecture](https://github.com/jasontaylordev/CleanArchitecture)

---

## 📜 License

MIT License
