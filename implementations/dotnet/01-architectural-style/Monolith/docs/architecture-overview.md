
---

```markdown
# Architecture Overview

The MonolithicApp follows a **4-layer architecture**:

1. **Presentation Layer (API)**
   - ASP.NET Core Web API controllers
   - Global error handling, filters, middleware
   - Swagger documentation

2. **Application Layer**
   - Command & Query handlers using **MediatR**
   - DTO mapping using **AutoMapper**
   - Validation with **FluentValidation**

3. **Domain Layer**
   - Core business rules, entities, and value objects
   - Domain events for internal state changes

4. **Infrastructure Layer**
   - Database context and EF Core migrations
   - Repository implementations
   - External service integrations

---

## Diagram
![Monolith Architecture Diagram](diagrams/monolith-architecture.drawio)
