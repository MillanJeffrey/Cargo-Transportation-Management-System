using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cargo_Transportation_Management_System.CargoTransportationManagementSystem.Data.Models
{
    internal class Vehicle
    {
        
            public int Id { get; set; }
            public string PlateNumber { get; set; } = "";
            public int CapacityKg { get; set; }
            // Add type, status, lastMaintenance, etc.
        
    }
}
