using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1
{
    internal class Ludo
    {
        public Ludo() { }
        public Ludo(string name, string color, int value) 
        { 
            this.name = name;
            this.color = color;
            this.value = value;
        }
        public string name, color;
        public int value;

    }
}
