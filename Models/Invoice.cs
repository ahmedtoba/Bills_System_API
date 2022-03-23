using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bills_System_API.Models
{
    public class Invoice
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name ="Bill Number")]
        public int Id { get; set; }
        
        [Required(ErrorMessage ="Date is required")]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Quantity is required")]
        [Range(minimum:1, maximum: int.MaxValue, ErrorMessage ="Quantity must be greater than zero" )]
        [Remote(action:"Quantity", controller:"Validation", AdditionalFields ="ItemId", 
            ErrorMessage ="There is not enough quantity in stock")]
        public int Quantity { get; set; }
        [Required(ErrorMessage ="Selling Price is required")]
        public double SellingPrice { get; set; }
        [Required]
        public double Total { get; set; }
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        [ForeignKey("Item")]
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
    }
}
