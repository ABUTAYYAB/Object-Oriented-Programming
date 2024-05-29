using System;

namespace ChallengeNo2.BL
{
    internal class Product
    {
        public Product()
        {
        }
        public Product(string id, string name, float price, String Category, string BrandName, string Country)
        {
            this.id = id;   
            this.name = name;
            this.price = price;
            this.Category = Category;
            this.BrandName = BrandName;
            this.Country = Country;

        }
        public string id;
        public string name;
        public float price;
        public String Category;
        public string BrandName;
        public string Country;

        public string show()
        {
            string sen = "Name:" + this.name + "\nPrice: " + this.price + "\nBrand: " + this.BrandName;
            return sen;
        }
    }
}
