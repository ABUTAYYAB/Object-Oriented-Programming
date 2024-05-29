using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    internal class Car
    {
        protected string Model;
        protected string Color;
        protected double Price;
        public Car() { }
        public Car(string model, string color, double price)
        {
            this.Model = model;
            this.Color = color;
            this.Price = price;
        }
        public string getColor()
        {
            return this.Color;
        }
        public void setColor(string color)
        {
            Color = color;
        }
        public void setModel(string model)
        {
            Model = model;
        }
        public string getModel()
        {
            return this.Model;
        }
        public void setPrice(double price)
        {
            Price = price;
        }
        public double getPrice()
        {
            return this.Price;
        }
    }
}
