using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairydelightsDLL.BL
{
    public class User
    {
        protected string UserName, Password, Role;   //attribute of the User
        public User()
        { }
        public User(User u)
        {
            UserName = u.GetUserName();
            Password = u.GetPassword();
            Role = u.GetRole();
        }

        public User(string UserName, string Password, string Role)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.Role = Role;
        }

        public string GetRole()
        {
            return this.Role;
        }
        public bool SetRole(string Role)
        {
            this.Role = Role;
            return true;
        }
        public string GetUserName()
        {
            return this.UserName;
        }
        public bool SetUserName(string UserName)
        {
            this.UserName = UserName;
            return true;
        }
        public string GetPassword()
        {
            return this.Password;
        }
        public bool SetPassword(string Password)
        {
            this.Password = Password;
            return true;
        }
    }
}
