using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiduFurniture.BLL.Repository.interfaces;
using DiduFurniture.DAL;
using DiduFurniture.DAL.Models;
using DiduFurniture.DAL.Models.Quotations;

namespace DiduFurniture.BLL.Repository
{
    public class CustomerDetail : ICustomers
    {
        private DiduContext _context;
        private IQuotation _quotation;
        public CustomerDetail(DiduContext _diduContext, IQuotation quotation)
        {
            _context = _diduContext;
            _quotation = quotation;
        }
        public Customer SaveCustomer(Customer customer, string quotationNumber)
        {

            if (customer!=null)
            {        
                _context.Customers.Add(customer);
                _context.SaveChanges();
                _context.Quotation.Add(new Quotation { CustomerId = customer.CustomerId, DateCreated = DateTime.Now.Date, DueDate= DateTime.Now.AddDays(60), QuotationNumber = quotationNumber });
                _context.SaveChanges();
            }
            return customer;

        }
    }
}
