using DiduFurniture.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiduFurniture.BLL.Repository.interfaces
{
    public interface IProduct
    {
        Object GetProductCategory();
        Object GetProductSubCategory(int id);
        Object getProductDetails(int subcatId);
    }
}
