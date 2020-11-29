using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class VehicleCategory : BaseModel
    {
        public string Name { get; set; }
        public int RatePerKM { get; set; }
        public int RatePerMinute { get; set; }
        public bool IsActive { get; set; }
    }
}
