using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    internal class GLI : Car
    {
        private string EngineNumber;
        private float FuelAgerage;
        public GLI(float FuelAgerage, string EngineNumber, string model, string color, double price) : base(model, color, price)
        {
            this.FuelAgerage = FuelAgerage;
            this.EngineNumber = EngineNumber;
        }
        public float GetFuelAgerage()
        {
            return FuelAgerage;
        }
        public void SetFuelAgerage(float fuel)
        {
            FuelAgerage = fuel;
        }
        public string GetEngineNumber()
        {
            return EngineNumber;
        }
        public void SetEngineNumber(string engineno)
        {
            EngineNumber = engineno;
        }
        public float FuelCalculate(int distance)
        {
            return this.FuelAgerage * distance;
        }
    }
}
