# Folder Structure

## API Layer
`src/MonolithicApp.API/`
- **Controllers** → Handle HTTP requests and map them to application services.
- **Middlewares** → Logging, exception handling.
- **Swagger** → OpenAPI specification.

## Application Layer
`src/MonolithicApp.Application/`
- **Services** → Application-level operations.
- **Handlers** → CQRS commands/queries.
- **DTOs** → Data transfer between layers.

## Domain Layer
`src/MonolithicApp.Domain/`
- **Entities** → Core business models.
- **ValueObjects** → Immutable domain types.
- **Interfaces** → Contracts for repositories/services.

## Infrastructure Layer
`src/MonolithicApp.Infrastructure/`
- **Persistence** → EF Core DbContext.
- **Repositories** → Concrete implementations.
- **Migrations** → Database schema management.
