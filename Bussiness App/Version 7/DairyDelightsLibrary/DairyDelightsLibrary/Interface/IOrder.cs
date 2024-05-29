using DairyDelightsLibrary.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyDelightsLibrary.Interface
{
    public interface IOrder
    {
        bool AddOrder(Order order);
        bool IsOrderIDAlreadyExisted(string orderID);
        bool SetOrderDelivered(string orderID);
        List<Order> GetAllOrders();
        List<Order> GetOrderListbyUserName(string username);
        List<Order> GetUndeliveredOrders();
        List<Order> GetDeliveredOrders();
        double GetSales();
        List<Product> GetProductDetailsByOrderId(string orderId);

    }
}
