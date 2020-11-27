using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Discount : BaseModel
    {
        public DateTime ExpiryDate { get; set; }
        public string Code { get; set; }
        public bool IsActive { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        public int Amount { get; set; }
        public DiscountType DiscountType { get; set; }

    }

    public enum DiscountType
    {
        Currency,
        Percentage
    }
}
