using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DiduFurniture.DAL.Models.Quotation
{
   public class StoreLocation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StoreLocationId { get; set; }
        
        public string StoreName { get; set; }
      
        public string StoreAddress { get; set; }
       
        public string ZipCode { get; set; }
    }
}
