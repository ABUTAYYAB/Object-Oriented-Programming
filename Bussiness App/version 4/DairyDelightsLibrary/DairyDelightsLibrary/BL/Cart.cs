using System.Collections.Generic;

namespace DairyDelightsLibrary.BL
{
    public class Cart
    {
        private string Customer;
        private List<Product> Products;
        private double TotalPriceBeforeDiscount;
        private double TotalPriceAfterDiscount;

        public Cart() { }
        public Cart(Cart cart)
        {
            this.Customer = cart.GetCustomerName();
            this.Products = cart.GetProducts();
        }
        public Cart(string name)
        {
            this.Customer = name;
            this.Products = new List<Product>();
            this.TotalPriceBeforeDiscount = 0;
            this.TotalPriceAfterDiscount = 0;
        }
        public Cart(string name,List<Product> products, double TotalPriceBeforeDiscount, double TotalPriceAfterDiscount)
        {
            this.Customer = name;
            this.Products = products;
            this.TotalPriceBeforeDiscount = TotalPriceBeforeDiscount;
            this.TotalPriceAfterDiscount = TotalPriceAfterDiscount;
        }
        public string GetCustomerName()
        {
            return this.Customer;
        }
        public bool SetCustomer(string customer)
        {
            this.Customer = customer;
            return true;
        }
        public bool AddProductInList(Product product)
        {
            this.Products.Add(product);
            return true;
        }
        public List<Product> GetProducts()
        {
            return this.Products;
        }
        public string GetProductsInString()
        {
            string Result = "";
            for (int i = 0; i < Products.Count; i++)
            {
                Result = Result + Products[i].GetName() + "|" + Products[i].GetQuantity() + "|" + Products[i].GetPrice()+ "|" + Products[i].GetFinalPrice() + "%";
            }
            return Result;
        }
        public bool SetProducts(List<Product> products)
        {
            this.Products = products;
            return true;
        }

        public double GetTotalPriceBeforeDiscount()
        {
            double Result = 0;
            foreach (Product product in this.Products)
            {
                Result += product.GetPrice();
            }
            this.TotalPriceBeforeDiscount = Result;
            return Result;
        }
        public bool SetTotalPriceBeforeDiscount(double TotalPriceBeforeDiscount)
        {
            this.TotalPriceBeforeDiscount = TotalPriceBeforeDiscount;
            return true;
        }
        public double GetTotalPriceAfterDiscount()
        {
            double Result = 0;
            foreach (Product product in this.Products)
            {
                Result += product.GetFinalPrice();
            }
            this.TotalPriceAfterDiscount = Result;
            return Result;
        }
        public bool SetTotalPriceAfterDiscount(double TotalPriceAfterDiscount)
        {
            this.TotalPriceAfterDiscount = TotalPriceAfterDiscount;
            return true;
        }
    }
}
