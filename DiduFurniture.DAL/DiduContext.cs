using DiduFurniture.DAL.Models;
using DiduFurniture.DAL.Models.Products;
using DiduFurniture.DAL.Models.Quotation;
using DiduFurniture.DAL.Models.Quotations;
using DiduFurniture.DAL.Models.Sales_Order;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiduFurniture.DAL
{
   public class DiduContext :DbContext
    {
        public DiduContext(DbContextOptions<DiduContext> options):base(options)
        { }

        public DbSet<Users> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Quotation> Quotation { get; set; }
        public DbSet<QuotationItem> QuotationItem { get; set; }
        public DbSet<StoreLocation> StoreLocation { get; set; }
        public DbSet<Material> Material { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<ProductSubCategories> ProductSubCategories { get; set; }
        public DbSet<ProductDetail> ProductDetail { get; set; }

        public DbSet<SubCategory> SubCategory { get; set; }

        public DbSet<MaterialWeaving> MaterialWeaving { get; set; }

        public DbSet<SubCategoryImages> SubCategoryImages { get; set; }
        public DbSet<SalesItem> salesItems { get; set; }
        public DbSet<SalesOrder> salesOrders { get; set; }







    }
}
