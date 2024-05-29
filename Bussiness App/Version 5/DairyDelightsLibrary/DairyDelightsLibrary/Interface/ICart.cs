using DairyDelightsLibrary.BL;

namespace DairyDelightsLibrary.Interface
{
    public interface ICart
    {

        Cart GetCartFromUserName(string UserName);
        bool AddProductInCart(string UserName, Product product);
        bool RemoveProductFromCart(string UserName, string ProductName);
        double GetProductQuantiytPresentInCart(string UserName, string ProductName);
        bool UpdateQuantityInCart(string UserName, string ProductName, double Quantity);
        bool RemoveCart(string UserName);

    }
}
