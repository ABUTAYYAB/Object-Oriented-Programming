using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.BL
{
    internal class Circle
    {
        protected double Radius;
        protected string Color;
        public Circle(double radius, string color)
        {
            Radius = radius;
            Color = color;
        }
        public Circle()
        {
            Radius = 1.0;
            Color = "red";
        }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double  GetRadius()
        {
            return Radius;
        }
        public void SetRadius(double radius)
        {
            this.Radius = radius;
        }
        public string GetColor()
        {
            return Color;
        }
        public void SetColor(string color)
        {
            this.Color = color;
        }
        public double GetArea()
        {
            return Radius*Radius*3.1416;
        }
        public string Tostring()
        {
            string result;
            result = $"Circle[radius={this.Radius},color={this.Color}]";
            return result ;
        }
    }
}
