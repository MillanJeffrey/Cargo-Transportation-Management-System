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
using Cargo_Transportation_Management_System.CargoTransportationManagementSystem.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Cargo_Transportation_Management_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            dgvshipment.AutoGenerateColumns = false;
            BuildGridColumn();
        }

        private void BuildGridColumn()
        {
            dgvShipments.Columns.Clear();
            dgvShipments.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Id", DataPropertyName = "Id", Width = 50 });
            dgvShipments.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Origin", DataPropertyName = "Origin", Width = 120 });
            dgvShipments.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Destination", DataPropertyName = "Destination", Width = 120 });
            dgvShipments.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Driver", DataPropertyName = "DriverName", Width = 120 });
            dgvShipments.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Vehicle", DataPropertyName = "VehiclePlate", Width = 120 });
            dgvShipments.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Departure", DataPropertyName = "DepartureDate", Width = 140 });
            dgvShipments.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Arrival", DataPropertyName = "ArrivalDate", Width = 140 });
        }

        private void button2_Click(object sender, EventArgs e)
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

                dgvShipments.DataSource = list;
            }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadShipments();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadShipments();
        }

        private void BuildGridColumn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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

                dgvShipments.DataSource = list;
            }
        }

        private void Form2_DpiChanged(object sender, DpiChangedEventArgs e)
        {

        }
    }
}
