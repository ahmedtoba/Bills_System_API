using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bills_System_API.Models
{
    [Index(nameof(Name), IsUnique = true, Name = "UniqueName")]
    public class Client
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name ="Number")]
        public int Id { get; set; }
        [Required(ErrorMessage ="Item name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Phone number is required")]
        [RegularExpression(@"^(\d{14})$", ErrorMessage ="Phone number must be 14 digits")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage ="Address is required")]
        public string Address { get; set; }
        public virtual List<Invoice> Invoices { get; set; }
        public virtual List<TotalBill> TotalBills { get; set; }




    }
}
