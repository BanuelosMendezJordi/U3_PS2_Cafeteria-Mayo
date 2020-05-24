using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace U3_PS2_Cafeteria.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Display(Name = "Codigo de Orden")]
        [Required]
        public string OrderCode { get; set; }

        [Display(Name = "Cliente")]
        [Required]
        public string ClientName { get; set; }

        [Required]
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        [Display(Name ="Cantidad")]
        [Required]
        public int OrderQuantity { get; set; }

        [Display(Name = "Total")]
        public decimal Total { get; set; }

        public string Status { get; set; }
    }
}