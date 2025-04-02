# ProductStore - ASP.NET MVC Product Management System

![ASP.NET Core](https://img.shields.io/badge/.NET-9.0-blue)
![SQL Server](https://img.shields.io/badge/SQL_Server-2019+-blue)

A full-featured product management system implementing secure CRUD operations with authentication.

## Table of Contents
- [Features](#features)
- [Tech Stack](#tech-stack)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Database Schema](#database-schema)
- [Author](#author)

## Features ✨
- User Authentication 🔒
  - Secure login/registration using ASP.NET Core Identity
  - Role-based access control
  - Session management

- Product Management 📦
  - Create, Read, Update, Delete (CRUD) operations
  - Image upload with file validation (JPEG/PNG)

- Validation ✔️
  - Client-side form validation
  - Server-side model validation
  - Anti-forgery token protection

- UI/UX 💻
  - Responsive Bootstrap 5 design
  - Font Awesome icons
  - Modal confirmation dialogs

## Tech Stack 🛠
Frontend  
| ![Bootstrap](https://img.shields.io/badge/Bootstrap-5.0+-purple) | ![Razor](https://img.shields.io/badge/Razor-ASP.NET-blue) | ![Font Awesome](https://img.shields.io/badge/Font_Awesome-6.0+-orange) |
|------------------------------------------------------------------|-----------------------------------------------------------|-------------------------------------------------------------------------|

Backend  
| ![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-9.0-blue) | ![EF Core](https://img.shields.io/badge/EF_Core-9.0-red) | 
|---------------------------------------------------------------------|----------------------------------------------------------|

Database  
| ![SQL Server](https://img.shields.io/badge/SQL_Server-2019+-blue) |
|-------------------------------------------------------------------|

## Getting Started 🚀

### Prerequisites
- [.NET 9.0 SDK](https://dotnet.microsoft.com/download)
- [SQL Server 2019+](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Visual Studio 2022+](https://visualstudio.microsoft.com/) (Recommended)
- [Entity Framework Core Tools](https://docs.microsoft.com/en-us/ef/core/cli/)

### Installation
1. Clone the repository
      git clone https://github.com/ElaKulu2639/ProductStore.git
   cd ProductStore
2. Configure the database:
     -Create SQL Server database "ProductStoreDb"
     -Update connection string in appsettings.json:
   ```
   
        "ConnectionStrings": {
    "DefaultConnection": "YOUR_CONNECTION_STRING"
   }

3. Apply database migrations:
   
     Update-Database

4. Run the application

Database Schema 🗃

    
       erDiagram
    Users ||--o{ Products : creates
    Users {
        string Id PK
        string UserName
        string Email
        string PasswordHash
        datetime CreatedAt
    }
    Products {
        int Id PK
        string Name
        string Brand
        string Category
        decimal Price
        string ImageFileName
        datetime CreatedAt
        string UserId FK
    }

 Author 👨💻
Elias Aynekulu
Email-e9710092@gmail.com
GitHub-ElaKulu2639
