using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cargo_Transportation_Management_System.CargoTransportationManagementSystem.Data.Models
{
    internal class Shipments
    {
        public class Shipment
        {
            public int Id { get; set; }
            public string Origin { get; set; } = "";
            public string Destination { get; set; } = "";
            public DateTime DepartureDate { get; set; } = DateTime.UtcNow;
            public DateTime? ArrivalDate { get; set; }

            // Links
            public int? DriverId { get; set; }
            public Driver Driver { get; set; }

            public int? VehicleId { get; set; }
            public Vehicle Vehicle { get; set; }

            public List<Cargo> Cargos { get; set; } = new List<Cargo>();
        }
    }
}
