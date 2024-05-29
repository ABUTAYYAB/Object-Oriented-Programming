using DairyDelightsLibrary.BL;
using DairyDelightsLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyDelightsLibrary.DL.FileHandling
{
    public class ProductDL : IProduct
    {
        static ProductDL Instance;
        private ProductDL()
        { }
        public static IProduct GetInstance(string Connection)
        {
            if (Instance == null)
            {
                Instance = new ProductDL();
            }
            return Instance;
        }
        public bool Addproduct(Product product)
        {
            throw new NotImplementedException();
        }

        public bool AddReview(string name, string Review)
        {
            throw new NotImplementedException();
        }

        public bool ChangeDescriptionByName(string name, string Description)
        {
            throw new NotImplementedException();
        }

        public bool ChangeDiscountByName(string name, string discount)
        {
            throw new NotImplementedException();
        }

        public bool ChangePriceByName(string name, string Price)
        {
            throw new NotImplementedException();
        }

        public bool ChangeQuantityByName(string name, string Quantity)
        {
            throw new NotImplementedException();
        }

        public bool CheckIfProductAlreadyExist(string Name)
        {
            throw new NotImplementedException();
        }

        public double GetFinalPriceOfProductAvailable(string Name)
        {
            throw new NotImplementedException();
        }

        public Product GetProductObjectfromName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsList()
        {
            throw new NotImplementedException();
        }

        public double GetQuantityOfProductAvailable(string Name)
        {
            throw new NotImplementedException();
        }

        public bool Removeproduct(string Name)
        {
            throw new NotImplementedException();
        }
    }
}
