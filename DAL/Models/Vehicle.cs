using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Models
{
    public class Vehicle : BaseModel
    {
        public VehicleType VehicleType { get; set; }
        public string DriverId { get; set; }
        [ForeignKey(nameof(DriverId))]
        public ApplicationUser Driver { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Variant { get; set; }
        public int Year { get; set; }
        public string RegistrationNo { get; set; }
        public string VIN { get; set; }
        public Guid VehicleCategoryId { get; set; }
        public VehicleCategory VehicleCategory { get; set; }
        public List<VehicleLocation> VehicleLocations { get; set; }
    }
}
