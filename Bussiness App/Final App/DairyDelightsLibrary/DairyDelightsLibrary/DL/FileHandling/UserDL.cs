using DairyDelightsLibrary.BL;
using DairyDelightsLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Threading;

namespace DairyDelightsLibrary.DL.FileHandling
{
    public class UserDL : IUser
    {
        public static string ActiveUser;
        static UserDL Instance;
        public List<User> UsersList = new List<User>();
        private UserDL(string path)
        {
            Utility.Path.SetUserFilePath(path);
            UsersList = GetDataFromUserFile(path);
        }
        public static UserDL GetInstance(string path)
        {
            if (Instance == null)
            {
                Instance = new UserDL(path);
            }
            return Instance;
        }

        public string SignIN(string UserName, string Password)
        {
            foreach (User user in UsersList)
            {
                if (UserName == user.GetUserName() && Password == user.GetPassword())
                {
                    ActiveUser = UserName;
                    return user.GetRole();
                }
            }
            return "UserNotFound";
        }

        public bool SignUP(User user)
        {
            UsersList.Add(user);
            ActiveUser = user.GetUserName();
            StoreDetailsOfUser();
            return true;
        }

        public string GetActiveUser()
        {
            return ActiveUser;
        }

        public bool ChangePassword(string Password)
        {
            foreach (User user in UsersList)
            {
                if (ActiveUser == user.GetUserName())
                {
                    bool check = user.SetRole(Password);
                    StoreDetailsOfUser();
                    return check;
                }
            }
            return false;
        }

        public bool ChangePasswordByUserName(string Username, string Password)
        {
            foreach (User user in UsersList)
            {
                if (Username == user.GetUserName())
                {
                    bool check = user.SetRole(Password);
                    return check;
                }
            }
            return false;
        }

        public bool CheckIfUserNameAlreadyExist(string UserName)
        {
            if(UsersList == null)
            {
                return false;
            }
            foreach (User user in UsersList)
            {
                if (UserName == user.GetUserName())
                {
                    return true;
                }
            }
            return false;
        }

        public string FindPasswordByUserName(string UserName)
        {
            foreach (User user in UsersList)
            {
                if (UserName == user.GetUserName())
                {
                    return user.GetPassword();
                }
            }
            return "";
        }

        public string FindRoleByUserName(string UserName)
        {
            foreach (User user in UsersList)
            {
                if (UserName == user.GetUserName())
                {
                    return user.GetRole();
                }
            }
            return "";
        }

        public List<User> GetUsersList()
        {
            return this.UsersList;
        }

        public bool RemoveUser(string UserName)
        {
            foreach (User user in UsersList)
            {
                if (UserName == user.GetUserName())
                {
                    UsersList.Remove(user);
                    StoreDetailsOfUser();
                    return true;
                }
            }
            return false;
        }


        private string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == '%')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        private List<User> GetDataFromUserFile(string path)
        {
            List<User> users = new List<User>();
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string userName = parseData(record, 1);
                    string userPassword = parseData(record, 2);
                    string userRole = parseData(record, 3);

                    User user = new User(userName, userPassword, userRole);
                    users.Add(user);

                }
                fileVariable.Close();
            }
            return users;
        }
        private void StoreDetailsOfUser()
        {
            string path = Utility.Path.GetUserFilePath();

            StreamWriter file = new StreamWriter(path, append :false);

            for (int i = 0; i < UsersList.Count; i++)
            {
                User user1 = UsersList[i];
                file.WriteLine($"{user1.GetUserName()}%{user1.GetPassword()}%{user1.GetRole()}%");
            }
            file.Flush();
            file.Close();

        }


    }
}
