namespace Bills_System_API.Models
{
    public class TotalBill
    {
        public int Id { get; set; }
        public double Total { get; set; }
        public double Paid { get; set; }
        public double ValueDiscount { get; set; }
        public double PrecentageDiscount { get; set; }
        public double Net { get; set; }
        public Client Client { get; set; }
    }
}
