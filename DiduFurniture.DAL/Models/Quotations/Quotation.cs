using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DiduFurniture.DAL.Models.Quotations
{
   public class Quotation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuotationId { get; set; }

       
        public string QuotationNumber { get; set; }     

     
        public string QuotationStatus { get; set; }
        public string ConfirmedBy { get; set; }

        
        public string SalesPerson { get; set; }

        public string ShippedBy { get; set; }
       
        public DateTime DateCreated { get; set; }

       
        public DateTime DueDate { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Deposit { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Discount { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Balance { get; set; }
        public string DeliveryNotes { get; set; }
     
       
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
