
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cargo_Transportation_Management_System.CargoTransportationManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using Cargo_Transportation_Management_System.CargoTransportationManagementSystem.Data.Models;

namespace Cargo_Transportation_Management_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            DataGridView.AutoGenerateColumns = false;



        }

        private void BuildGridColumns()
        {
            DataGridView.AutoGenerateColumns = false;
            DataGridView.Columns.Clear();

            DataGridView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Id", DataPropertyName = "Id", Width = 50 });
            DataGridView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Origin", DataPropertyName = "Origin", Width = 120 });
            DataGridView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Destination", DataPropertyName = "Destination", Width = 120 });
            DataGridView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Driver", DataPropertyName = "DriverName", Width = 120 });
            DataGridView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Vehicle", DataPropertyName = "VehiclePlate", Width = 120 });
            DataGridView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Departure", DataPropertyName = "DepartureDate", Width = 140 });
            DataGridView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Arrival", DataPropertyName = "ArrivalDate", Width = 140 });
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            var choice = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                // Restart the application so Program.Main will show the LoginForm again.
                // Application.Restart will attempt to relaunch the app; exit to ensure a clean shutdown.
                try
                {
                    Application.Restart();
                }
                catch
                {
                    // ignore restart exceptions
                }
                finally
                {
                    Environment.Exit(0);
                }
            }
        }

        private void btnSeed_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationDbContext())
            {
                if (db.Drivers.Any() || db.Vehicles.Any() || db.Shipments.Any())
                {
                    MessageBox.Show("Data already seeded.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Minimal seed
                var d1 = new Driver { Name = "Alice Johnson", LicenseNumber = "D-12345" };
                var d2 = new Driver { Name = "Bob Smith", LicenseNumber = "D-98765" };

                var v1 = new Vehicle { PlateNumber = "ABC-123", CapacityKg = 5000 };
                var v2 = new Vehicle { PlateNumber = "XYZ-987", CapacityKg = 12000 };

                db.Drivers.AddRange(d1, d2);
                db.Vehicles.AddRange(v1, v2);
                db.SaveChanges();

                var s1 = new Shipments
                {
                    Origin = "New York, NY",
                    Destination = "Boston, MA",
                    DepartureDate = DateTime.Now.AddDays(-1),
                    ArrivalDate = DateTime.Now.AddHours(10),
                    DriverId = d1.Id,
                    VehicleId = v1.Id
                };

                var s2 = new Shipments
                {
                    Origin = "Los Angeles, CA",
                    Destination = "San Francisco, CA",
                    DepartureDate = DateTime.Now,
                    DriverId = d2.Id,
                    VehicleId = v2.Id
                };

                db.Shipments.AddRange(s1, s2);

                db.Cargos.Add(new Cargo { Description = "Electronics", WeightKg = 1200, Shipment = s1 });
                db.Cargos.Add(new Cargo { Description = "Furniture", WeightKg = 3000, Shipment = s2 });

                db.SaveChanges();

                MessageBox.Show("Seeded sample data.", "Seed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadShipments();
        }
        private void LoadShipments()
        {
            using (var db = new ApplicationDbContext())
            {
                var list = db.Shipments
                    .Include(s => s.Driver)
                    .Include(s => s.Vehicle)
                    .Include(s => s.Cargos)
                    .AsNoTracking()
                    .Select(s => new
                    {
                        s.Id,
                        s.Origin,
                        s.Destination,
                        DriverName = s.Driver != null ? s.Driver.Name : "N/A",
                        VehiclePlate = s.Vehicle != null ? s.Vehicle.PlateNumber : "N/A",
                        DepartureDate = s.DepartureDate,
                        ArrivalDate = s.ArrivalDate,
                        TotalCargoWeightKg = s.Cargos.Sum(c => (double?)c.WeightKg) ?? 0
                    })
                    .ToList();

                DataGridView.DataSource = list;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadShipments();
        }

        private void dgvShipmentBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
