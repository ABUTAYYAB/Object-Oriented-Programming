using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App3tiermodel.BL;

namespace App3tiermodel.DL
{
    internal class UserDL
    {
        public static List<User> users = new List<User>();

        public static bool AddUserIntoList(User u)
        {
            bool result = true;
            users.Add(u);
            return result;
        }
        public static bool RemoveUserFromList(User u)
        {
            bool result = true;
            users.Remove(u);
            return result;
        }

        public static string signIN(string id,string password)
        {
            string result = null;

            for (int i = 0; i < users.Count; i++)
            {
                if (id == users[i].id && password == users[i].password)
                {
                    result = users[i].role;
                    return result;
                }
            }

            return result;
        }
        public static bool SignUP(User u)
        {
            
            bool result;
            result = false;
            result = AddUserIntoList(u);
            return result;
        }
    }
}
