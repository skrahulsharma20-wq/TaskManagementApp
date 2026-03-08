# Task Management Application

## Overview

This project is a **Task Management Application** developed using
**ASP.NET Core MVC (.NET 8)** and **Entity Framework Core (Code First
Approach)**.

The application allows users to:

-   Create Tasks
-   View Tasks
-   Update Tasks
-   Delete Tasks
-   Search Tasks

Each task includes important details such as title, description, due
date, status, remarks, creation date, and last updated information.

The project demonstrates:

-   MVC Architecture
-   CRUD Operations
-   Entity Framework Core
-   SQL Server Database Design
-   Search Functionality
-   Clean UI with Bootstrap
-   Proper project documentation

------------------------------------------------------------------------

# Database Design

## ER Diagram

TaskItem Entity

Id (PK)\
Title\
Description\
DueDate\
Status\
Remarks\
CreatedOn\
LastUpdatedOn\
CreatedById\
CreatedByName\
LastUpdatedById\
LastUpdatedByName

------------------------------------------------------------------------

## Data Dictionary

  Column Name         Data Type           Description
  ------------------- ------------------- -----------------------
  Id                  int (Primary Key)   Unique identifier
  Title               nvarchar(200)       Task title
  Description         nvarchar(max)       Task details
  DueDate             datetime2           Task deadline
  Status              nvarchar(50)        Task status
  Remarks             nvarchar(max)       Additional remarks
  CreatedOn           datetime2           Creation timestamp
  LastUpdatedOn       datetime2           Last update timestamp
  CreatedById         int                 Creator ID
  CreatedByName       nvarchar(100)       Creator name
  LastUpdatedById     int                 Last updater ID
  LastUpdatedByName   nvarchar(100)       Last updater name

------------------------------------------------------------------------

## Indexes Used

Indexes are used to improve performance:

-   Index on **Title**
-   Index on **DueDate**

These indexes help improve search and sorting operations.

------------------------------------------------------------------------

## Database First Approach

This project uses **Entity Framework Core Database First** approach.

### Why Database First?

-   Faster development


-   Suitable for agile development

------------------------------------------------------------------------

# Application Structure

   TaskManagementApp
│
├── Controllers
│     TasksController.cs
│
├── Models
│     TaskItem.cs
│
├── Data
│     AppDbContext.cs
│
├── Views
│     Tasks
│        Index.cshtml
│        Create.cshtml
│        Edit.cshtml
│
│
└── Program.cs
├── README.md
├── script.sql

The project follows the **MVC (Model View Controller)** architecture.

------------------------------------------------------------------------

# Frontend Structure

The frontend is built using:

-   ASP.NET Core Razor Views
-   Bootstrap 5
-   HTML5

### Why this frontend?

-   Simple and lightweight
-   Easy to maintain
-   Suitable for CRUD applications
-   Fast development

This application uses a **web-based interface** rather than a mobile
application.

------------------------------------------------------------------------

# Build and Installation

## Environment Requirements

-   .NET 8 SDK
-   SQL Server 2014
-   Visual Studio 2022

## NuGet Packages

-   Microsoft.EntityFrameworkCore.SqlServer
-   Microsoft.EntityFrameworkCore.Tools
-   Microsoft.EntityFrameworkCore.Design

------------------------------------------------------------------------

## Steps to Build Project

1.  Clone repository

```{=html}
<!-- -->
```
    git clone <repository-url>

2.  Open project in **Visual Studio**

3.  Restore NuGet packages



4.  Build the project

------------------------------------------------------------------------

## Run the Application

Run the project using:

    dotnet run

or press **F5** in Visual Studio.

Then open:

    https://localhost:<port>/Tasks

------------------------------------------------------------------------

# Features

-   Task Creation
-   Task Editing
-   Task Deletion
-   Task Search
-   Professional UI using Bootstrap
-   Entity Framework Core integration
-   Clean MVC Architecture

------------------------------------------------------------------------



------------------------------------------------------------------------

# Author

Developed as part of a technical assignment using ASP.NET Core MVC.
