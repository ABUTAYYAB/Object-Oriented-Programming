using DairydelightsDLL.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DairydelightsDLL.DL.FileHandling
{
    public class UserFH
    {

        public static List<User> users  =  new List<User>();
        public static string Path = "usercredentials.txt";

        public static string GetPath()
        {
            return Path;
        }

        public static List<User> AccessDetailsOfUser(string path)
        {
            List<User> UserList = new List<User>();

            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);

                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();

                    string Username = SeperatedText(line, 1);
                    string password = SeperatedText(line, 2);
                    string role = SeperatedText(line, 3);

                    User user = new User(Username, password, role);
                    UserList.Add(user);

                }
                

                file.Close();
            }

            return UserList;
        }
        public static string SeperatedText(string line, int num)
        {
            int count = 1;
            string word = "";

            for (int i = 0; i < line.Length; i++)
            {
                char ch = line[i];

                if (ch == '|')
                {
                    count++;
                }
                else if (count == num)
                {
                    word += ch;
                }
            }

            return word;

        }
        public static bool StoreDetailsOfUser(string path)
        {
            bool check = false;
            StreamWriter file = new StreamWriter(path, append: false);

            for (int i = 0; i < users.Count; i++)
            {
                User user1 = users[i];
                file.WriteLine($"{user1.GetUserName()}|{user1.GetPassword()}|{user1.GetRole()}|");
            }
            file.Flush();
            file.Close();
            check = true;

            return check;
        }

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

        public static string signIN(string UserName, string password)
        {
            string result = null;

            for (int i = 0; i < users.Count; i++)
            {
                if (UserName == users[i].GetUserName() && password == users[i].GetPassword())
                {
                    result = users[i].GetRole();
                    return result;
                }
            }

            return result;
        }
        public static bool SignUP(User u)
        {

            bool result;
            result = true;
            // result = AddUserIntoList(u);
            users.Add(u);
            return result;
        }

    }
}
