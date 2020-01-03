using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DiduFurniture.DAL.Models.Sales_Order
{
    public class SalesOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SoId { get; set; }
        public string SalOrdNumber { get; set; }
        public DateTime DueDate { get; set; }
        public string ShippedBy { get; set; }
        public string DeliveryNotes { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Discount { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Deposit { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Balance { get; set; }
        public string ConfirmedBy { get; set; }
        public string SalesPerson { get; set; }
        public string SalesOrderStatus { get; set; }
        public string Paymentstatus { get; set; }
        public string ProductionStatus { get; set; }
        public string ShipmentStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
