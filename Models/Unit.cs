using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bills_System_API.Models
{
    [Index(nameof(Name), IsUnique = true, Name = "UniqueName")]
    public class Unit
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Unit name is required")]
        public string Name { get; set; }
        public string Notes { get; set; }
        public virtual List<Item> Items { get; set; }
    }
}
