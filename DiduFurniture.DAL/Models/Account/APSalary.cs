using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DiduFurniture.DAL.Models.Account
{
    public class APSalary
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int APSalaryId { get; set; }
        [Required]
        public string NIK { get; set; }
        [Required]
        public string EmployeName { get; set; }
        [Required]
        public decimal Salary { get; set; }
        [Required]
        public decimal Bonus { get; set; }
        [Required]
        public string TakeHomePay { get; set; }
        [Required]
        public string BankName { get; set; }
        [Required]
        public string BankAccount { get; set; }
        [Required]
        public decimal AmountPaid { get; set; }
        [Required]
        public string PaymentReceipt { get; set; }
    }
}
