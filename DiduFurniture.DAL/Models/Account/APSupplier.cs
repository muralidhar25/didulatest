using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DiduFurniture.DAL.Models.Account
{
    public class APSupplier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InvoiceId { get; set; }
        [Required]
        public string Supplier { get; set; }
        [Required]
        public string InvoiceNo { get; set; }
        [Required]
        public DateTime InvoiceDate { get; set; }
        [Required]
        public decimal InvoiceAmount { get; set; }
        [Required]
        public int PONumber { get; set; }
        [Required]
        public decimal AmountPaid1 { get; set; }
        [Required]
        public DateTime DateOfPayment1 { get; set; }
        [Required]
        public string Account { get; set; }
        [Required]
        public string PaymentReceipt1 { get; set; }
        [Required]
        public string AmountOutstanding { get; set; }
        [Required]
        public decimal AmountPaid2 { get; set; }
        [Required]
        public DateTime DateOfPayment2 { get; set; }
        [Required]
        public string Aged { get; set; }
        [Required]
        public string Account2 { get; set; }
        [Required]
        public string PaymentReceipt2 { get; set; }

    }
}
