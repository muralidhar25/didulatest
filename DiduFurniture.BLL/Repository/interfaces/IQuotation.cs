using DiduFurniture.DAL.Models.Quotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiduFurniture.BLL.Repository.interfaces
{
    public interface IQuotation
    {
        string CreateQuotation();
        Object SaveQuotationItem(QuotationItem quotationItem, string quotationNumber);
        Object GetQuotationItemInfo(string qNumber);
        Object SaveQuotationItemPrice(int qId, decimal price, int quantity);
        Object GetAllQuotationsList();
        bool DeleteQuotation(int id);
        Object GetQuotationSummary(string qNumber);
    }
}
