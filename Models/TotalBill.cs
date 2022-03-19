using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bills_System_API.Models
{
    public class TotalBill
    {
        public int Id { get; set; }
        public double Total { get; set; }
        public double Paid { get; set; }
        public double ValueDiscount { get; set; }
        public double PercentageDiscount { get; set; }
        public double Net { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}
