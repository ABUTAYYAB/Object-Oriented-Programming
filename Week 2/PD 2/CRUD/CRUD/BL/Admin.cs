using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    internal class Admin
    {
        public Admin(string name, string id, string password) 
        {
            this.name = name;
            this.id = id;
            this.password = password;

        }
        public string name;
        public string id;
        public string password;

    }
}
