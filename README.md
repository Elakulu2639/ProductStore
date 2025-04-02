# ProductStore

 Overview

ProductStore is an ASP.NET Core MVC application designed for managing products in an online store  using ASP.NET Core MVC, SQL Server, and Entity Framework Core. 
It provides functionalities for creating, reading, updating, and deleting products, along with image upload capabilities. 
The application follows the MVC architectural pattern, ensuring a clean separation of concerns.

 Features

- User-Friendly Interface: Intuitive web interface for managing products.
- CRUD Operations: Create, read, update, and delete products easily.
- Image Upload: Upload product images with validation.
- Data Persistence: Uses Entity Framework Core for database interactions.
- Responsive Design: Mobile-friendly layout for accessibility.

 Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download/dotnet/7.0)(version 7.0 or later) 
- [SQL Server 2019+](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [SQL Server Management Studio (SSMS)](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms) (Optional)
- [Visual Studio 2022+](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

Installation

1. Clone the repository
   ```
   git clone https://github.com/ElaKulu2639/ProductStore.git
   cd ProductStore
2. Restore Dependencies:
   ```
   dotnet restore
3. Set Up the Database:

   Update the connection string in appsettings.json to point to your SQL Server instance.
   Run migrations to set up the database schema:
     ```
     dotnet ef database update
4. Run the application
   
   Usage

    Navigate to Products in the navigation menu

    Use the following actions:

      -New Product: Add a new product using the form

      -Edit: Modify existing product details

      -Delete: Remove a product from the system
   
Project Structure
 ProductStore/
│
├── Controllers/          # Contains the MVC controllers
│   └── ProductsController.cs
│
├── Models/               # Contains data models and DTOs
│   └── Product.cs
│   └── ProductDto.cs
│
├── Views/                # Contains Razor views
│   ├── Products/
│   │   ├── Index.cshtml
│   │   ├── Create.cshtml
│   │   └── Edit.cshtml
│   └── Shared/
│       └── _Layout.cshtml
│
├── wwwroot/              # Contains static files (CSS, JS, images)
│   ├── css/
│   ├── js/
│   └── products/         # Uploaded product images
│
├── Services/                 # Contains database context and migrations
│   └── ApplicationDbContext.cs
│
├── Migrations/           # Contains EF Core migration files
│      
├── Properties/           # Contains project properties
│   └── launchSettings.json
│
└── appsettings.json      # Configuration settings

Technologies Used

  -ASP.NET Core MVC 
  -Entity Framework Core 
  -SQL Server Database
  -Bootstrap (Frontend styling)
  
Contact

Name: Elias Aynekulu
Email: e9710092@gmail.com
GitHub: ElaKulu2639
