using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Models
{
    public class Offer : BaseModel
    {
        public double Amount { get; set; }
        public bool IsAccepted { get; set; }
        public Guid TripId { get; set; }

    }
}
