using DairyDelightsLibrary.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyDelightsLibrary.Interface
{
     interface ICart
    {
        bool AddCart(Cart cart);
        bool RemoveCart(string Name);
        bool AddProductInCart(string UserName, Product product);

    }
}
