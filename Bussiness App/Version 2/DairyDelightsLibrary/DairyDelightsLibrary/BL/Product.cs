using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyDelightsLibrary.BL
{
    public class Product
    {
        string Name;
        double Price, Quantity, Discount;
        List<string> Reviews = new List<string>();

        public Product(string name, double price, double quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            
        }
        public string GetName()
        {
            return this.Name;
        }
        public bool SetName(string Name)
        {
            this.Name = Name;
            return true;
        }
        public double GetQuantity()
        {
            return this.Quantity;
        }
        public bool SetQuantity(double Quantity)
        {
            this.Quantity = Quantity;
            return true;
        }
        public bool BuyQuantity(double Quantity)
        {
            this.Quantity -= Quantity;
            return true;
        }
        public double GetPrice()
        {
            return this.Price;
        }
        public bool SetPrice(double Price)
        {
            this.Price = Price;
            return true;
        }
        public double GetDiscount()
        {
            return this.Discount;
        }
        public bool SetDiscount(double Discount)
        {
            this.Discount = Discount;
            return true;
        }
        public List<string> GetReviews()
        {
            return this.Reviews;
        }
        public bool SetReviews(List<string> Reviews)
        {
            this.Reviews = Reviews;
            return true;
        }

        public string GetReviewsInString()
        {
            string Reviews1 = "";
            for (int i = 0; i < Reviews.Count; i++)
            {
                Reviews1 = Reviews1 + Reviews[i] + "%";
            }

            return Reviews1;

        }
    }
}
