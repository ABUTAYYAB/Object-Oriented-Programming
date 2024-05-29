using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    internal class Song
    {

        private string Name;
        public Song(string name)
        {
            this.Name = name;
        }
        public string GetName()
        {
            return this.Name;
        }
        public void SetName(string name)
        {
            this.Name = name;
        }
    }
}
