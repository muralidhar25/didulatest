using DiduFurniture.DAL.Models;
using DiduFurniture.DAL.Models.Quotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiduFurniture.BLL.Repository
{
    public interface ICustomers
    {
        Customer SaveCustomer(Customer customer, string quotationNumber);
    }
}
