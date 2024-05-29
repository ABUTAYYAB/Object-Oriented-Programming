using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DairyDelightsLibrary.BL;
using DairyDelightsLibrary.Interface;
using DairyDelightsLibrary.DL.DataBase;
using DairyDelightsLibrary.Validation;

namespace WindowsFormProject
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UI.SignUP());
        }
        static string Connection = "Data Source=MALIK;Initial Catalog=Final_Project;Integrated Security=True;";
        public static IUser GetUserInstance() 
        {
            IUser user = UserDL.GetInstance(Connection);
            return user;
        }
        public static IWorker GetWorkerInstance()
        {
            IWorker worker = WorkerDL.GetInstance();
            return worker;
        }
        public static iDeliveryBoy GetDeliveryBoyInstance()
        {
            iDeliveryBoy boy = DeliveryBoyDL.GetInstance();
            return boy;
        }
        public static IProduct GetProductInstance() 
        {
            IProduct product = ProductDL.GetInstance();
            return product;
        }


    }
}
