using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bills_System_API.Models
{
    [Index(nameof(Name), IsUnique =true, Name ="UniqueName")]
    public class Company
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Company name is required")]
        public string Name { get; set; }
        public string Notes { get; set; }
        public virtual List<CompanyType> CompanyTypes { get; set; }
    }
}
