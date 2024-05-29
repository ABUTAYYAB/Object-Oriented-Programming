using DairyDelightsLibrary.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyDelightsLibrary.Interface
{
    public interface IUser
    {
        bool SignUP(User user);
        bool RemoveUser(string UserName);
        string SignIN(string UserName, string Password);
        string FindRoleByUserName(string UserName);
        string FindPasswordByUserName(string UserName);
        bool CheckIfUserNameAlreadyExist(string UserName);
        bool ChangePassword(string Password);
        bool ChangePasswordByUserName(string Username, string Password);
        List<User> GetUsersList();
    }
}
