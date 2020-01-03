using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DiduFurniture.DAL.Models.Sales_Order
{
   public class SalesItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SiId { get; set; }
           
        public int CategoryId { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
        [Required]
        public int SubCategoryId { get; set; }
        public virtual ProductSubCategories ProductSubCategories { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Length { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Width { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Height { get; set; }
        public string Anyam { get; set; }
        public string Color { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public int MaterialId { get; set; }
        public virtual Material Material { get; set; }
        public int SoId { get; set; }
        public virtual SalesOrder SalesOrder { get; set; }

    }
}
