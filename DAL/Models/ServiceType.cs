using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class ServiceType : BaseModel
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
