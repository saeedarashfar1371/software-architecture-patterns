# Monolithic Architecture (.NET Example)

## Overview
This repository contains a **Monolithic Architecture** implementation using **.NET 8** following a **Layered Architecture** approach:

- **Presentation Layer** — API controllers, filters, middleware  
- **Application Layer** — CQRS, DTOs, business services  
- **Domain Layer** — Entities, Value Objects, business rules  
- **Infrastructure Layer** — EF Core, repositories, migrations  

A **Monolith** means the **entire application** is packaged and deployed as **a single executable/service**, sharing a single database and runtime.

---

## Features
- CRUD operations for **Products**, **Customers**, and **Orders**
- Centralized **Domain Model**
- **Entity Framework Core** for data access
- Global exception handling & logging
- DTO-based request/response mapping
- CQRS-style use cases via **MediatR**
- Unit tests for core domain logic
- **Swagger/OpenAPI** documentation

---

## Tech Stack
- **.NET 8** (C#)
- **Entity Framework Core**
- **SQL Server**
- **FluentValidation**
- **MediatR**
- **Swagger/OpenAPI**

---

## Project Structure
```plaintext
src/
├── MonolithicApp.API/            → Presentation layer (Controllers, Filters, Middleware)
├── MonolithicApp.Application/    → Application layer (CQRS, DTOs, Services)
├── MonolithicApp.Domain/         → Domain layer (Entities, Value Objects, Interfaces)
└── MonolithicApp.Infrastructure/ → Infrastructure layer (EF Core, Repositories, Migrations)
```

---

## Architecture Diagram
```plaintext
+-------------------+
|   Presentation    |  ← API, Controllers, Filters, Middleware
+-------------------+
          |
          v
+-------------------+
|   Application     |  ← CQRS Handlers, DTOs, Validation
+-------------------+
          |
          v
+-------------------+
|     Domain        |  ← Entities, Value Objects, Business Rules
+-------------------+
          |
          v
+-------------------+
|  Infrastructure   |  ← EF Core, Repositories, Database
+-------------------+
          |
          v
   SQL Server DB
```