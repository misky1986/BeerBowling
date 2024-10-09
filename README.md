# BeerBowling
The following app is a playground for trying out Clean Architecture and Mediator CQRS pattern.

## Prerequise
.NET 8 SDK: The framework for building and running the application.

## Architecture

### Clean Architecture
This project follows Clean Architecture principles, promoting separation of concerns and maintainability.

|-- src
|   |-- Application
|   |   |-- Commands
|   |   |-- Queries
|   |   |-- Validation
|   |-- Domain
|   |-- Infrastructure
|   |-- API
|   |   |-- Controllers

#### Application:
Contains the business logic of the application. Commands for write operations and Queries for read operations.
Has a dependency to the `Domain` project.

#### Domain: 
Represents the core business logic, including entities, value objects, and domain services. 
Has no dependencies to other projects in the slution.

#### Infrastructure:
Includes implementations for data access, external services, and any other infrastructure concerns.
Has a dependency to the `Application` project.

#### API:
The entry point for the application, typically a Web API.
Has a dependency to the `Application` and `Infrastructure` project.

### Patterns
The CQRS (Command Query Responsibility Segregation) pattern combined with the Mediator pattern is a powerful architectural approach in C#. Here’s a brief overview:

#### CQRS Pattern
CQRS separates the read and write operations of an application into different models:

Commands: Handle write operations (Create, Update, Delete).
Queries: Handle read operations (Retrieve).
This separation allows for better scalability and performance tuning, as read and write operations can be optimized independently.

#### Mediator Pattern
The Mediator pattern helps reduce the complexity of communication between objects or classes by centralizing the interactions. In C#, the MediatR library is commonly used to implement this pattern. It acts as a mediator that receives requests (commands or queries) and delegates them to the appropriate handlers.

## Test

Test project utilizes `NSubstitute` as a mocking framework.
Furthermore in cases where a end-2-end test is needed the `Testcontainers` nuget package is utilized.