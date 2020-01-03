using DiduFurniture.BLL.Repository.interfaces;
using DiduFurniture.DAL;
using DiduFurniture.DAL.Models.Quotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiduFurniture.BLL.Repository
{
    public class Quotations : IQuotation
    {
        private DiduContext _context;
        public Quotations(DiduContext _diduContext)
        {
            _context = _diduContext;
        }
        public string CreateQuotation()
        {
            var date = System.DateTime.Now.Date;
            var todayRecords = _context.Quotation.Where(m => m.DateCreated == date).Select(x => x.QuotationId).Count();
            var dateformat = System.DateTime.Now.ToString("yyyyddMM");
            var countData = todayRecords + 1;
            var countData1 = string.Format("{0:00}", countData);
            var PrefixId = string.Format("{0}-{1}{2}-{3}", "DDK", "QUO", dateformat, countData1);
            //  _context.Quotation.Add(new Quotation { QuotationNumber = PrefixId,DateCreated=date,DueDate=date.AddDays(60) });
            //    _context.SaveChanges();
            return PrefixId;
        }

        public Object SaveQuotationItem(QuotationItem quotationItem, string quotationNumber)
        {
            if (quotationItem != null)
            {
                var qID = _context.Quotation.Where(x => x.QuotationNumber == quotationNumber).Select(y => y.QuotationId).FirstOrDefault();
                quotationItem.QuotationId = qID;
                _context.QuotationItem.Add(quotationItem);
                _context.SaveChanges();
            }
            return quotationItem;
        }

        public Object GetQuotationItemInfo(string qNumber)
        {
            var data = _context.QuotationItem.Include(x => x.Quotation)
                .Include(x => x.ProductCategory)
                .Include(x => x.ProductSubCategories)
                .Include(x => x.Material)
                .Where(x => x.Quotation.QuotationNumber == qNumber);
                
            return data;
        }

        public Object SaveQuotationItemPrice(int qId, decimal price, int quantity)
        {
            var qItem = _context.QuotationItem.Where(x => x.QId == qId).FirstOrDefault();
            if (qItem == null)
            {
                return false;
            }
            else
            {
                qItem.Price = price;
                qItem.Quantity = quantity;
                _context.Update(qItem);
                _context.SaveChanges();
                return qItem;
            }
        }

        public Object GetAllQuotationsList()
        {
            var qList = _context.Quotation.Include(x=>x.Customer).ToList();
            if (qList == null)
            {
                return false;
            }
            else
            {
                return qList;
            }
        }

        public bool DeleteQuotation(int id)
        {
            var qitemId = _context.QuotationItem.Where(x => x.QuotationId == id).ToList();
            var quotationId = _context.Quotation.Where(x => x.QuotationId == id).FirstOrDefault();
            var customerdetail = _context.Customers.Where(x => x.CustomerId == quotationId.CustomerId).FirstOrDefault();

            // var data = _context.QuotationItem.Include(x => x.Quotation).Include(y => y.Quotation.Customer).ToList();

                try
                {

                _context.QuotationItem.RemoveRange(qitemId);
                _context.SaveChanges();
                _context.Customers.Remove(customerdetail);
                _context.SaveChanges();
                _context.Quotation.Remove(quotationId);
                _context.SaveChanges();             
                }
                catch(Exception e)
                {
                return false;
                }
            return true;


        }

        public Object GetQuotationSummary(string qNumber)
        {
            var id = _context.Quotation.Where(x => x.QuotationNumber == qNumber).FirstOrDefault();
            var data = _context.QuotationItem.Include(x => x.Quotation).Include(x => x.ProductSubCategories).Include(x => x.Material).Include(x => x.Quotation.Customer).Include(x => x.ProductCategory).Include(x => x.Quotation.Customer.storeLocation).Where(x => x.QuotationId == id.QuotationId).ToList();

            if (data == null)
            {
                return false;
            }
            else
            {
                return data;
            }
        }
        }
    }
