using DAL.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Trip : BaseModel
    {
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        public Guid DriverId { get; set; }
        public virtual  Driver Driver { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime Date { get; set; }
        public TripStatus Status { get; set; }
        public Location PickUpAddress { get; set; }
        public Location DropOffAddress { get; set; }
    }
}
