using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.BL
{
    internal class MountainBike : Bicycle
    {
        protected int SeatHeight;
        public MountainBike(int height,int cadence,int speed,int gear) :base(cadence,gear, speed)
        {
        }
        public void SetSeatHeight(int height)
        {
            this.SeatHeight = height;
        }
    }
}
