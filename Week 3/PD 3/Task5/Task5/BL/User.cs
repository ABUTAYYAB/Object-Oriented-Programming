using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.BL
{
    internal class User
    {
        public User(string id, string password, string role)
        {
            this.id = id;
            this.password = password;
            this.role = role;

        }
        public string id;
        public string password;
        public string role;
    }
}
