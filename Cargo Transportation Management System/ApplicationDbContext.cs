using Cargo_Transportation_Management_System.CargoTransportationManagementSystem.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace Cargo_Transportation_Management_System.CargoTransportationManagementSystem.Data
{
    using Models;

    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Driver> Drivers { get; set; } = null;
        public DbSet<Vehicle> Vehicles { get; set; } = null;
        public DbSet<Cargo> Cargos { get; set; } = null;
        public DbSet<Shipments> Shipments { get; set; } = null;

        private static string GetDbPath()
        {
            var folder = Directory.GetCurrentDirectory();
            var path = Path.Combine(folder, "cargo.db");
            return path;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = GetDbPath();
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Driver>().HasKey(d => d.Id);
            modelBuilder.Entity<Vehicle>().HasKey(v => v.Id);
            modelBuilder.Entity<Cargo>().HasKey(c => c.Id);
            modelBuilder.Entity<Shipments>().HasKey(s => s.Id);

            modelBuilder.Entity<Shipments>()
                .HasOne(s => s.Driver)
                .WithMany()
                .HasForeignKey(s => s.DriverId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Shipments>()
                .HasOne(s => s.Vehicle)
                .WithMany()
                .HasForeignKey(s => s.VehicleId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Cargo>()
                .HasOne(c => c.Shipment)
                .WithMany(s => s.Cargos)
                .HasForeignKey(c => c.ShipmentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
