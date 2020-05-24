using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace U3_PS2_Cafeteria.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        
        [Display(Name = "Código")]
        [Required]
        public string ProductCode { get; set; }

        [Display(Name = "Producto")]
        [Required]
        public string ProductName { get; set; }

        [Display(Name = "Descripción")]
        [Required]
        public string ProductDescription { get; set; }

        [Display(Name = "Tipo")]
        [Required]
        public string ProductType { get; set; }

        [Display(Name = "Precio")]
        [Required]
        public decimal ProductPrice { get; set; }

        public byte[] ProductImage { get; set; }
    }
}