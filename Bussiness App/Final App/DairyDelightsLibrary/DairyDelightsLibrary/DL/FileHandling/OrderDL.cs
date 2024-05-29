using DairyDelightsLibrary.BL;
using DairyDelightsLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyDelightsLibrary.DL.FileHandling
{
    public class OrderDL : IOrder
    {
        static OrderDL Instance;
        private OrderDL()
        {

        }
        public static OrderDL GetInstance(string Connection)
        {
            if (Instance == null)
            {
                Instance = new OrderDL();
            }
            return Instance;
        }
        public bool AddOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public List<Order> GetDeliveredOrders()
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrderListbyUserName(string username)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductDetailsByOrderId(string orderId)
        {
            throw new NotImplementedException();
        }

        public double GetSales()
        {
            throw new NotImplementedException();
        }

        public List<Order> GetUndeliveredOrders()
        {
            throw new NotImplementedException();
        }

        public bool IsOrderIDAlreadyExisted(string orderID)
        {
            throw new NotImplementedException();
        }

        public bool SetOrderDelivered(string orderID)
        {
            throw new NotImplementedException();
        }
    }
}
