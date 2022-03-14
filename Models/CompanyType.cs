using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bills_System_API.Models
{
    [Index(nameof(CompanyId), nameof(TypeId), IsUnique =true)]
    public class CompanyType
    {
        
        public int Id { get; set; }
        public string Notes { get; set; }

        [ForeignKey("Company")]
        [Range(minimum:1, maximum: int.MaxValue, ErrorMessage ="Company is required")]
        public int CompanyId { get; set; }
        [ForeignKey("Type")]
        public int TypeId { get; set; }
        public virtual Company Company { get; set; }
        public virtual Species Type { get; set; }

    }
}
