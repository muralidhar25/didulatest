using DiduFurniture.DAL.Models;
using DiduFurniture.DAL.Models.Sales_Order;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiduFurniture.BLL.Repository.interfaces
{
   public interface ISalesOrder
    {
        Object CreateSalesOrderNo();
        void SaveSalesCustomer(Customer customer);
        Object CreateSalesOrder(string OrderNo,int customerId );
        int GetCurrentCustomerId();
        object DrpDwnStoreLocation();
        Object SaveSalesItem(SalesItem salesItem, string salesNumber);
        Object GetSalesItemInfo(string sONumber);
        object SaveSalesItemPrice(int siId, decimal price, int quantity);
        bool DeleteSalesOrder(int SoId);
        object GetSalesOrderList();
        object GetSalesOrderById(int SoId);

        //void Customerdetail(CustomerDetail customerDetail);
        //void AddSalesOrderItem(SalesItem salesItem);
    }
}
