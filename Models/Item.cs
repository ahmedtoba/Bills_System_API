using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bills_System_API.Models
{
    [Index(nameof(Name), IsUnique = true, Name = "UniqueName")]
    public class Item
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Item name is required")]
        public string Name { get; set; }
        public string Notes { get; set; }
        [Range(minimum:0, maximum:double.MaxValue, ErrorMessage ="Selling price must be greater than or equal 0")]
        [Remote(action:"SellingPrice", controller:"Validation", AdditionalFields = "BuyingPrice", 
                ErrorMessage ="Selling price must be greater than buying price")]
        public double SellingPrice { get; set; }
        [Range(minimum: 0, maximum: double.MaxValue, ErrorMessage = "Buying price must be greater than or equal 0")]
        public double BuyingPrice { get; set; }
        [Range(minimum: 1, maximum: int.MaxValue, ErrorMessage = "Quantity must be greater than zero")]
        [Required(ErrorMessage ="Quanitity is required")]
        public int InitialQuantity { get; set; }
        public int RemainingQuantity { get; set; }
        [ForeignKey("Company")]
        public int CompanyId { get; set; }
        [ForeignKey("Type")]
        public int TypeId { get; set; }
        [ForeignKey("Unit")]
        public int UnitId { get; set; }
        public virtual Company Company { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual Species Type { get; set; }
        public virtual List<Invoice> Invoice { get; set; }
    }
}
