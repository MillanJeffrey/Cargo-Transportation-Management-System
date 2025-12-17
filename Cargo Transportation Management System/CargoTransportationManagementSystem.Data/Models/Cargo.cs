using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cargo_Transportation_Management_System.CargoTransportationManagementSystem.Data.Models.Shipments;

namespace Cargo_Transportation_Management_System.CargoTransportationManagementSystem.Data.Models
{
    internal class Cargo
    {

        public int Id { get; set; }
        public string Description { get; set; } = "";
        public int WeightKg { get; set; }

        // Foreign key to shipment
        public int ShipmentId { get; set; }
        public Shipments Shipment { get; set; }

    }
}
