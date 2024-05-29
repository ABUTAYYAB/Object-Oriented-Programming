using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3tiermodel.BL
{
    internal class Product
    {
        public Product(string name, double price, double quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public string name;
        public double price, quantity;

        public void UpdateQuantity(double no)
        {
            this.quantity += no;
        }
        public void UpdatePrice(double no)
        {
            this.quantity = no;
        }
        public bool BuyItem(double quan)
        {
            bool result = false;
            if (quan <= this.quantity)
            {
                this.quantity -= quan;
                result = true;
            }
            return result;
        }
        public string ViewName()
        {
            return this.name;
        }
        public double ViewPrice()
        {
            return this.price;
        }
        public double ViewQuantity()
        {
            return this.quantity;
        }
    }
}
