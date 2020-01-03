using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DiduFurniture.DAL.Models.Account
{
    public class APElectricity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int APElectId { get; set; }
        [Required]
        public string Month { get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public decimal TotalKWh { get; set; }
        [Required]
        public decimal TotalCost { get; set; }
        [Required]
        public DateTime DateOfPayment { get; set; }
    }
}
