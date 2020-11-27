using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class VehicleLocation : BaseModel
    {
        public Guid VehicleId { get; set; }
        public Guid LocationId { get; set; }
        public virtual Location Location { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public DateTime Date { get; set; }
    }
}
