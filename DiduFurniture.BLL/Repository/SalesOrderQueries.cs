using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using DiduFurniture.DAL;
using DiduFurniture.DAL.Models;
using DiduFurniture.DAL.Models.Sales_Order;
using Microsoft.EntityFrameworkCore;

namespace DiduFurniture.BLL.Repository.interfaces
{
    public class SalesOrderQueries : ISalesOrder
    {
        private DiduContext _context;
        public SalesOrderQueries(DiduContext context)
        {
            _context = context;
        }    

        public Object CreateSalesOrderNo()
        {
            var date = System.DateTime.Now;
            var todayRecords = _context.salesOrders.Where(m => m.CreatedDate == date).Select(x => x.SoId).Count();
            var dateformat = System.DateTime.Now.ToString("yyyyddMM");
            var countData = todayRecords + 1;
            var countData1 = string.Format("{0:000}", countData);
            var PrefixId = string.Format("{0}-{1}{2}-{3}", "DDA", "SO", dateformat, countData1);

            return PrefixId;
        }
        public Object CreateSalesOrder(string OrderNo, int customerId)
        {
            var date = System.DateTime.Now;
            var duedate = date.AddDays(60);
            SalesOrder salesOrdert = new SalesOrder()
            {
                CreatedDate = date,
                SalOrdNumber = OrderNo,
                DueDate = date.AddDays(60),
                CustomerId = customerId
            };
            _context.salesOrders.Add(salesOrdert);
            _context.SaveChanges();
            return _context.salesOrders.LastOrDefault();
        }


        public object DrpDwnStoreLocation()
        {
            var sl_list = _context.StoreLocation.Select(m => new { m.StoreLocationId, m.StoreName });
            //var SL_list = _context.StoreLocation.Select(c => new SelectListItem
            //{
            //    Value = c.StoreLocationId.ToString(),
            //    Text = c.StoreName
            //}).ToList();
            return sl_list;
        }

        //public void Customerdetail(CustomerDetail customerDetail)
        //{
        //    throw new NotImplementedException();
        //}

        public void SaveSalesCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }
        public int GetCurrentCustomerId()
        {
            var rec = _context.Customers.LastOrDefault();
            var i = rec.CustomerId;
            return i;

        }

       
        public object GetSalesItemInfo(string sONumber)
        {
            var data = _context.salesItems.Include(x => x.SalesOrder)
                .Include(x => x.ProductCategory)
                .Include(x => x.ProductSubCategories)
                .Include(x => x.Material)
                .Where(x => x.SalesOrder.SalOrdNumber == sONumber);
            return data;
        }
        public Object SaveSalesItem(SalesItem salesItem, string salesNumber)
        {
            if (salesNumber != null)
            {
                var sID = _context.salesOrders.Where(x => x.SalOrdNumber == salesNumber).Select(y => y.SoId).FirstOrDefault();
                salesItem.SiId = sID;
                _context.salesItems.Add(salesItem);
                _context.SaveChanges();
            }
            return salesItem;
        }
        public object SaveSalesItemPrice(int siId, decimal price, int quantity)
        {
            var salItem = _context.salesItems.Where(m => m.SiId == siId).FirstOrDefault();
            if (salItem == null)
            {
                return false;
            }
            else
            {
                salItem.Price = price;
                salItem.Quantity = quantity;
                _context.Update(salItem);
                _context.SaveChanges();
                return salItem;
            }
        }
        public bool DeleteSalesOrder(int sOId)
        {
            var salesOrder = _context.salesOrders.Where(m => m.SoId == sOId).FirstOrDefault();
            var cusDetail = _context.Customers.Where(m => m.CustomerId == salesOrder.CustomerId).FirstOrDefault();
            var salItemDetail = _context.salesItems.Where(m => m.SoId == salesOrder.SoId).ToList();
            try
            {
                _context.salesItems.RemoveRange(salItemDetail);
                _context.SaveChanges();
                _context.Customers.Remove(cusDetail);
                _context.SaveChanges();
                _context.Remove(salesOrder);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
                throw e;
            }
            return true;
        }
        public object GetSalesOrderList()
        {
            var SalesOrder = _context.salesOrders.Include(x => x.Customer).ToList();
            if (SalesOrder == null)
            {
                return false;
            }
            else
            {
                return SalesOrder;
            }
        }
       
        public object GetSalesOrderById(int SoId)
        {
            var salOrdr = _context.salesOrders.Include(m => m.Customer)
                .Where(m => m.SoId == SoId).FirstOrDefault();
            var salItems = _context.salesItems.Include(m => m.Material)
                .Include(m => m.ProductCategory)
                .Include(m => m.ProductSubCategories)
                .Where(m => m.SoId == salOrdr.SoId).ToList();
            var data = new
            {
                salOrdr,
                salItems
            };
            return data;
        }
    }
}

