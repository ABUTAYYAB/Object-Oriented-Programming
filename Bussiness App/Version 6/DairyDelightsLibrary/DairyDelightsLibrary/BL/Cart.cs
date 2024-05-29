using System.Collections.Generic;

namespace DairyDelightsLibrary.BL
{
    public class Cart
    {
        private List<Product> Products;

        public Cart(Cart cart)
        {
            this.Products = cart.GetProducts();
        }
        public Cart(List<Product> Products)
        {
            this.Products = Products;
        }
        public Cart()
        {
            this.Products = new List<Product>();
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
                Result = Result + Products[i].GetName()+ "|" + Products[i].GetQuantity()+ "|" + Products[i].GetPrice() + "%";
            }
            return Result;
        }
        public bool SetProducts(List<Product> products)
        {
            this.Products = products;
            return true;
        }

        public double GetTotalPriceOfCart()
        {
            double Result = 0;
            foreach (Product product in this.Products)
            {
                Result += product.GetPrice() * product.GetQuantity();
            }
            return Result;
        }

    }
}
