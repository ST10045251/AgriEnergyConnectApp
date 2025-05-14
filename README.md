# AgriEnergyConnectApp

AgriEnergyConnectApp is a prototype web application built using ASP.NET Core MVC. 
It connects farmers and employees to manage agricultural products efficiently and securely. 
The system features role-based access, product management, and user authentication.

---

## Project Structure

- `Models/` – Contains models like `Farmer`, `Product`, and `ApplicationUser`
- `Controllers/` – Handles business logic for views and database interactions
- `Views/` – UI pages grouped by controller
- `Data/` – ApplicationDbContext and database initialization
- `wwwroot/` – Static files like CSS, JS, and images

---

## Prerequisites

- [.NET 8 SDK]
- [Visual Studio 2022+] or VS Code
- SQL Server or SQLite
- Git (optional)

---

## Setup Instructions

1. **Clone the Repository**

   ```bash
   git clone https://github.com/ST10045251/AgriEnergyConnectApp.git
   cd AgriEnergyConnectApp

2. **Restore NuGet Packages**
   - dotnet restore

4. **Apply Migrations & Seed Database**
  - dotnet ef database update

5. **Run the Application**
  - dotnet run

# Navigate to: https://localhost:5001

## Build Instructions
To build the project manually:

Run:
dotnet clean
dotnet build

## System Functionalities & User Roles
### User Authentication
Secure login & registration via ASP.NET Identity.
Role-based access for:
- Farmers: Can add/edit/delete products.
- Employees: Can view farmer data and update statuses.

### Core Features
Add and manage farmer profiles
Upload and manage agricultural products
Secure access with authorization
Role-specific navigation and dashboards

## Development Notes
Identity scaffolded with dotnet aspnet-codegenerator identity
Styling uses basic CSS
_LoginPartial.cshtml was replaced with custom login buttons



