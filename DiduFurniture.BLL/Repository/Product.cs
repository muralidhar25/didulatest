using DiduFurniture.BLL.Repository.interfaces;
using DiduFurniture.DAL;
using DiduFurniture.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace DiduFurniture.BLL.Repository
{
   public  class Product : IProduct
    {
        private DiduContext _context;
        public Product(DiduContext _diduContext)
        {
            _context = _diduContext;
        }
        public Object GetProductCategory()
        {
            //    var productdata = _context.ProductDetail.Include(x => x.ProductSubCategories).Include(x => x.MaterialWeaving).Include(x => x.Material).Join(_context.SubCategory, x => x.SubCategoryId, y => y.SubCategoryId, (z, v) => new
            //    {
            //        z,
            //        v.CategoryId
            //    })
            //    .Join(_context.ProductCategory, x => x.CategoryId, y => y.CategoryId, (z, v) => new
            //    {
            //        z,
            //        v
            //    }).ToList();

            var productdata = _context.ProductCategory.ToList();
            var firstProduct= _context.ProductSubCategories.Where(x=>
            _context.SubCategory.Where(y=>y.CategoryId == productdata.FirstOrDefault()
            .CategoryId)
            .Select(y=>y.SubCategoryId).Contains(x.SubCategoryId));
            var data = new
            {
                productdata,
                firstProduct
            };
            return data;
        }
        public Object GetProductSubCategory(int id)
        { 
            var subcat = _context.ProductSubCategories.Where(x => _context.SubCategory.Where(y => y.CategoryId == id).Select(y => y.SubCategoryId).Contains(x.SubCategoryId));

            return subcat;
        }

        public object getProductDetails(int subcatId)
        {
            var material = _context.Material.ToList();
            var weaving = _context.MaterialWeaving.ToList();
            var proDetails = _context.ProductDetail.Where(x => x.SubCategoryId == subcatId).FirstOrDefault();
            var data = new
            {
                proDetails,
                material,
                weaving
            };
            return data;
        }



    }
}
