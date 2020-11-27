using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Models
{
    public class Driver : BaseModel
    {

        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public virtual ApplicationUser User { get; set; }
        public string DriversLicenceFilename { get; set; }
        public string IdFileName { get; set; }
        public string ClearanceCertificateFileName { get; set; }
        public string ProofOfResidenceFileName { get; set; }
        public virtual ICollection<Trip> Trips { get; set; }
        public Guid? VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public bool IsOnline { get; set; }
    }
}
