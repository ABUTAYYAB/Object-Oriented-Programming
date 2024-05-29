using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    internal class Author
    {
        private string Name;

        public Author(string name)
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
