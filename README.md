# Todo-App -Implementing Clean Architecture

I created a Todo App implementing Clean Architecture Principles.This project follows layered architecture providing seperation of concern.It is built using class library structure for better organization and maintainability.

## Project structure

I have organized this project into multiple projects each project has function of each specific layer mentioned in the clean architecture.

- - core logic is absracted into ToDoApp.core class Library:

### ToDoApp.Core

- Domain Folder:It contains core business logic(ITodoServices) and entities (ToDo.cs)
- DTO Folder: It contains Data transfer object for transferring data between layers which is TodoResponseDTO.cs

### Purpose

- Here use of interface is to decouple implementation from abstraction
- use of entities to represent business logic.
