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
|   |-- Domain
|   |-- Infrastructure
|   |-- API

Application: Contains the business logic of the application. Commands for write operations and Queries for read operations.

Domain: Represents the core business logic, including entities, value objects, and domain services.

Infrastructure: Includes implementations for data access, external services, and any other infrastructure concerns.

API: The entry point for the application, typically a Web API.

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

## Dependencies
A list of primary dependencies and their roles in the project.

* MediatR: A library used for implementing the Mediator pattern.
* Entity Framework Core: An ORM for database access.
* FluentValidation: For validating application commands and queries.
* NSubstitute as mocking framework
