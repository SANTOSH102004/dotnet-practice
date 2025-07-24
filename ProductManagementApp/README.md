# ProductManagementApp

A detailed ASP.NET Core MVC application for managing products, using Entity Framework Core and MySQL.

---

## Table of Contents
- [Features](#features)
- [Database Schema](#database-schema)
- [Project Structure](#project-structure)
- [Configuration](#configuration)
- [Getting Started](#getting-started)
- [User Interface](#user-interface)
- [Error Handling](#error-handling)
- [Development Notes](#development-notes)
- [License](#license)

---

## Features
- List all products
- Add new products
- Edit existing products
- Delete products (with confirmation)
- Simple, clean Bootstrap-based UI
- Error handling and validation

---

## Database Schema

The application uses Entity Framework Core with a MySQL database. The main entity is `Product`:

```
public class Product
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public double Price { get; set; }
}
```

**Migration:**
- Table: `Products`
  - `Id` (int, primary key, auto-increment)
  - `Name` (string, required)
  - `Price` (double)

---

## Project Structure
- `Controllers/` - MVC controllers (`ProductController`, `HomeController`)
- `Models/` - Entity models (`Product`, `ErrorViewModel`)
- `Data/` - Database context (`AppDbContext`)
- `Migrations/` - Entity Framework migrations
- `Views/` - Razor views for Home and Product (CRUD)
- `wwwroot/` - Static files (CSS, JS, images)
- `appsettings.json` - Main configuration (connection string, logging)
- `Properties/launchSettings.json` - Launch profiles and URLs

---

## Configuration

**Database Connection:**
- The connection string is in `appsettings.json`:
  ```json
  "ConnectionStrings": {
    "DefaultConnection": "server=localhost;port=3306;database=productdb;user=root;password=root"
  }
  ```
- Update this string to match your MySQL setup.

**Logging:**
- Logging levels are set in `appsettings.json` and `appsettings.Development.json`.

**Launch URLs:**
- HTTP: `http://localhost:5135`
- HTTPS: `https://localhost:7002`

---

## Getting Started

### Prerequisites
- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- [MySQL Server](https://dev.mysql.com/downloads/mysql/)

### Setup Steps
1. Clone the repository or copy the folder.
2. Navigate to the `ProductManagementApp` directory.
3. Restore dependencies:
   ```bash
   dotnet restore
   ```
4. Apply migrations and update the database:
   ```bash
   dotnet ef database update
   ```
5. Run the application:
   ```bash
   dotnet run
   ```
6. Open your browser and go to `https://localhost:7002` or `http://localhost:5135`.

---

## User Interface

### Navigation
- The app uses a Bootstrap-based layout with a navigation bar (Home, Privacy).
- Main product management is under `/Product`.

### Product List
- URL: `/Product/Index`
- Displays all products in a table with columns: ID, Name, Price, Actions (Edit/Delete)
- Button to add a new product

### Add Product
- URL: `/Product/Create`
- Form fields: Name (required), Price
- Validation for required fields

### Edit Product
- URL: `/Product/Edit/{id}`
- Form fields: Name, Price (pre-filled)
- Save changes to update the product

### Delete Product
- URL: `/Product/Delete/{id}`
- **Note:** The current Delete view is a form similar to Create/Edit, but should ideally confirm deletion. (You may want to improve this for production use.)

### Styling
- Uses Bootstrap for layout and styling
- Custom styles in `wwwroot/css/site.css`

---

## Error Handling
- Errors are handled by the `ErrorViewModel` and a shared error view.
- If an error occurs, a user-friendly error page is shown with a Request ID for debugging.
- In development mode, more detailed error information is available.

---

## Development Notes
- The app is scaffolded for easy extension (add more fields, validation, or entities as needed).
- All views use Razor syntax and ASP.NET Core tag helpers.
- The Home page is a simple welcome page; the Privacy page is a placeholder for your privacy policy.
- The project is configured for both HTTP and HTTPS local development.

---

## License
This project is for educational purposes. You may use, modify, and distribute it as you wish. 