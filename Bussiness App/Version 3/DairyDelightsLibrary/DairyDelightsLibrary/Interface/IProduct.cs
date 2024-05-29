using DairyDelightsLibrary.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyDelightsLibrary.Interface
{
    public interface IProduct
    {
        List<Product> GetProductsList();
        bool Addproduct(Product product);
        bool Removeproduct(string Name);
        bool CheckIfProductAlreadyExist(string Name);
        bool ChangePriceByName(string name, string Price);
        bool ChangeDescriptionByName(string name, string Description);
        bool ChangeQuantityByName(string name, string Quantity);
        bool ChangeDiscountByName(string name, string discount);

    }
}
