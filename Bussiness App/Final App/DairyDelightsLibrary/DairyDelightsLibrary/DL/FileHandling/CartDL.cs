using DairyDelightsLibrary.BL;
using DairyDelightsLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyDelightsLibrary.DL.FileHandling
{
    public class CartDL : ICart
    {
        static CartDL Instance;
        private CartDL()
        {

        }
        public static CartDL GetInstance(string connection)
        {
            if (Instance == null)
            {
                Instance = new CartDL();
            }
            return Instance;
        }
        public bool AddProductInCart(string UserName, Product product)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCart(string UserName)
        {
            throw new NotImplementedException();
        }

        public double GetProductQuantiytPresentInCart(string UserName, string ProductName)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsListFromCart(string UserName)
        {
            throw new NotImplementedException();
        }

        public bool IsProductAlreadyExistInCart(string UserName, string productName)
        {
            throw new NotImplementedException();
        }

        public bool RemoveProductFromCart(string UserName, string ProductName)
        {
            throw new NotImplementedException();
        }

        public bool RemoveProductFromCartForAdmin(string ProductName)
        {
            throw new NotImplementedException();
        }

        public bool UpdateQuantityInCart(string UserName, string ProductName, double Quantity)
        {
            throw new NotImplementedException();
        }
    }
}
