using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using DiduFurniture.DAL.Models.Products;
using DiduFurniture.DAL.Models.Quotations;
namespace DiduFurniture.DAL.Models
{
   public class ProductDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductDetailId { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Length { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Width { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Height { get; set; }
        public string Anyam { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        [Required]       
        public int Quantity { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string ProductImage { get; set; }
        [Required]
        public int SubCategoryId { get; set; }
        public virtual ProductSubCategories ProductSubCategories { get; set; }
        [Required]
        [ForeignKey("Material")]
        public int MaterialId { get; set; }
        public virtual Material Material { get; set; }
        [Required]
        [ForeignKey("MaterialWeaving")]
        public int WeavingId { get; set; }
        public virtual MaterialWeaving MaterialWeaving { get; set; }


    }
}
