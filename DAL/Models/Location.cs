using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Location : BaseModel
    {
        public long Latitude { get; set; }
        public long Longitude { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Province { get; set; }
        public ICollection<VehicleLocation> VehicleLocations { get; set; }

    }
}
