using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.BL
{
    internal class Bicycle
    {
        protected int Cadence,Gear,Speed;
        public Bicycle()
        {

        }
        public Bicycle(int cadence, int gear, int speed)
        {
            Cadence = cadence;
            Gear = gear;
            Speed = speed;
        }
        public void SetCadence(int cadence) 
        {
            this.Cadence = cadence;
        }
        public void SetGear(int gear) 
        {
            this.Gear = gear;  
        }
        public void SpeedUp(int speed) 
        {
            this.Speed += speed;
        }
        public void ApplyBrake(int speed)
        {
            this.Speed -= speed;
        }
    }
}
