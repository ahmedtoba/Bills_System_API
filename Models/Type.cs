using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bills_System_API.Models
{
    [Index(nameof(Name), IsUnique = true, Name = "UniqueName")]
    public class Species
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Type name is required")]
        public string Name { get; set; }
        public virtual List<CompanyType> CompanyTypes { get; set; }
    }
}
