# Architectural Decisions

- **Why Monolith?**
  - Team size < 5 developers.
  - Need fast delivery and minimal DevOps overhead.
  - No strict scaling requirements per module.

- **Why Layered Architecture?**
  - Clear separation of concerns.
  - Testability of domain logic without infrastructure.

- **Tech Choices**
  - EF Core for ORM.
  - MediatR for decoupled application layer.
  - FluentValidation for input validation.
