# Cargo Transportation Management - Starter (WinForms + EF Core + SQLite)

This is a starter Cargo Transportation Management System implemented as a Windows Forms application using .NET 6 and Entity Framework Core with SQLite.

Quickstart (Visual Studio 2022)
1. Create a new solution folder and add the projects/files from this repo structure.
2. Open the solution in Visual Studio 2022.
3. Restore NuGet packages.
   - Required packages (already referenced in project files):
     - Microsoft.EntityFrameworkCore
     - Microsoft.EntityFrameworkCore.Sqlite
     - (optional) Microsoft.EntityFrameworkCore.Tools for migrations
4. Build and run the WinForms project (startup project: CargoTransportManagement).
5. Press "Seed Data" to create example drivers, vehicles, cargos, and shipments. Press "Refresh" to load shipments.

Quickstart (dotnet CLI)
1. Place projects in folders as shown.
2. At solution root:
   - `dotnet restore`
   - `dotnet build`
   - `dotnet run --project CargoTransportManagement/CargoTransportManagement.csproj`

Notes
- The app uses an embedded SQLite file named `cargo.db` in the same folder as the running app by default.
- For production or more advanced development:
  - Switch to SQL Server or another RDBMS and update the DbContext connection string.
  - Add EF Core migrations:
    - `dotnet add package Microsoft.EntityFrameworkCore.Design`
    - `dotnet tool install --global dotnet-ef` (if not installed)
    - `dotnet ef migrations add InitialCreate --project CargoTransportManagement.Data`
    - `dotnet ef database update --project CargoTransportManagement.Data`
  - Extend the UI to allow full CRUD operations.
  - Add validation, user authentication, role-based access, logging, and reporting.

Project structure (provided files)
- CargoTransportManagement/ (WinForms app)
  - CargoTransportManagement.csproj
  - Program.cs
  - MainForm.cs
  - MainForm.Designer.cs
- CargoTransportManagement.Data/ (data models + EF Core)
  - CargoTransportManagement.Data.csproj
  - ApplicationDbContext.cs
  - Models/Driver.cs
  - Models/Vehicle.cs
  - Models/Cargo.cs
  - Models/Shipment.cs

License
- Use and adapt as you like.
