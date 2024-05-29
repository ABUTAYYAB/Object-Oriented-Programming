using DairyDelightsLibrary.BL;
using DairyDelightsLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyDelightsLibrary.DL.FileHandling
{
    public class UserDL :IUser
    {
        public static string ActiveUser;
        static UserDL Instance;
        private UserDL(string path)
        {
            Utility.Path.SetUserFilePath(path);

        }
        public static UserDL GetInstance(string path)
        {
            if (Instance == null)
            {
                Instance = new UserDL(path);
            }
            return Instance;
        }

        public bool ChangePassword(string Password)
        {
            throw new NotImplementedException();
        }

        public bool ChangePasswordByUserName(string Username, string Password)
        {
            throw new NotImplementedException();
        }

        public bool CheckIfUserNameAlreadyExist(string UserName)
        {
            throw new NotImplementedException();
        }

        public string FindPasswordByUserName(string UserName)
        {
            throw new NotImplementedException();
        }

        public string FindRoleByUserName(string UserName)
        {
            throw new NotImplementedException();
        }

        public string GetActiveUser()
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsersList()
        {
            throw new NotImplementedException();
        }

        public bool RemoveUser(string UserName)
        {
            throw new NotImplementedException();
        }

        public string SignIN(string UserName, string Password)
        {
            throw new NotImplementedException();
        }

        public bool SignUP(User user)
        {
            throw new NotImplementedException();
        }
    }
}
