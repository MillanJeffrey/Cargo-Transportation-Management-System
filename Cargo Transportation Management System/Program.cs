using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cargo_Transportation_Management_System.CargoTransportationManagementSystem;
using Cargo_Transportation_Management_System.CargoTransportationManagementSystem.Data;

namespace Cargo_Transportation_Management_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var db = new ApplicationDbContext())
            {
                db.Database.EnsureCreated();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
