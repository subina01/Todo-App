# Todo-App -Implementing Clean Architecture

I created a Todo App implementing Clean Architecture Principles.This project follows layered architecture providing seperation of concern.It is built using class library structure for better organization and maintainability.

## Project structure

I have organized this project into multiple projects each project has function of each specific layer mentioned in the clean architecture.

- - core logic is absracted into ToDoApp.core class Library:

### ToDoApp.Core

- Domain Folder:It contains core business logic(ITodoServices) and entities (ToDo.cs)
- DTO Folder: It contains Data transfer object for transferring data between layers which is TodoResponseDTO.cs. It contains dtos for request and response of the todo data specific to each method in the Todorepository.

### Purpose

- Here use of interface is to decouple implementation from abstraction
- use of entities to represent business logic.

### ToDo.Infrastructure

- Database Folder:It contains core Database logic(ApplicationDbContext) and Todorepository for accessing the data and sending it to the ITodoServices.

### Purpose

- The ApplicationDbContext is a class that serves as a bridge between your application and the database.
- Here use of TodoServices to implement the ToDointerface

### ToDoApp.UI

- Controller Folder : This folder contains the contoller for addingtask, updating task, deleting task, updating status, gettingtask by id and getting all task.
