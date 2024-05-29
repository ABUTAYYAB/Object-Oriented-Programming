using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3.BL
{
    internal class MUser
    {
        public MUser( string id, string password,string role)
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
