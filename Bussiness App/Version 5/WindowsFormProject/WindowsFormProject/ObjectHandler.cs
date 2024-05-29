using DairyDelightsLibrary.DL.DataBase;
using DairyDelightsLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormProject
{
    public class ObjectHandler
    {
        static string Connection = "Data Source=MALIK;Initial Catalog=Final_Project;Integrated Security=True;";
        public static IUser GetUserInstance()
        {
            IUser user = UserDL.GetInstance(Connection);
            return user;
        }
        public static IWorker GetWorkerInstance()
        {
            IWorker worker = WorkerDL.GetInstance(Connection);
            return worker;
        }
        public static iDeliveryBoy GetDeliveryBoyInstance()
        {
            iDeliveryBoy boy = DeliveryBoyDL.GetInstance(Connection);
            return boy;
        }
        public static IProduct GetProductInstance()
        {
            IProduct product = ProductDL.GetInstance(Connection);
            return product;
        }
        public static ICustomer GetCustomerInstance()
        {
            ICustomer customer = CustomerDL.GetInstance(Connection);
            return customer;
        }
        public static ICart GetCartInstance()
        {
            ICart cart = CartDL.GetInstance(Connection);
            return cart;
        }
    }
}
