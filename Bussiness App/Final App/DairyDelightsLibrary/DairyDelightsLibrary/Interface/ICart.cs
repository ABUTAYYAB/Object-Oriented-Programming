using DairyDelightsLibrary.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyDelightsLibrary.Interface
{
    public interface ICart 
    {
        List<Product> GetProductsListFromCart(String UserName);
        bool AddProductInCart(string UserName, Product product);
        bool RemoveProductFromCart(string UserName, string ProductName);
        double GetProductQuantiytPresentInCart(string UserName, string ProductName);
        bool UpdateQuantityInCart(string UserName, string ProductName, double Quantity);
        bool IsProductAlreadyExistInCart(string UserName, string productName);
        bool RemoveProductFromCartForAdmin(string ProductName);
        bool DeleteCart(string UserName);

    }
}
