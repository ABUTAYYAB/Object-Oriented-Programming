using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.BL
{
    internal class Cylinder : Circle
    {
        protected double Height;
        public Cylinder() 
        {
            this.Height = 1.0;
        }
        public Cylinder(double radius):base(radius)
        {
        }
        public Cylinder(double radius, double Height) : base(radius)
        {
            this.Height = Height;
        }
        public Cylinder(double radius, double Height,string Color) : base(radius,Color)
        {
            this.Height = Height;
        }
        public double GetHeight()
        {
            return this.Height;
        }
        public void SetHeight(int height)
        {
            this.Height = height;
        }
        public double GetVolume()
        {
            return this.Radius*this.Radius*this.Height*3.1416;
        }


    }
}
