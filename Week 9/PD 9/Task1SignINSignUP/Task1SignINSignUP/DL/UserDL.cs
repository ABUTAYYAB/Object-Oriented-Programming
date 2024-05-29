using System.Collections.Generic;
using System.IO;
using System.Threading;
using Task1SignINSignUP.BL;
namespace Task1SignINSignUP.DL
{
    internal class UserDL
    {
        private static List<User> userlist = new List<User>();

        public static void AddUserIntoList(User user)
        {
            userlist.Add(user);
        }
        public static string signIN(User user)
        {
            foreach (User u in userlist)
            {
                if (u.GetUsername() == user.GetUsername() && u.GetPassword() == user.GetPassword())
                {
                    return u.GetRole();
                }
            }
            return "error";
        }
        static public bool updateDetails(string user, string pss, string role)
        {
            foreach (User u in userlist)
            {
                if (u.GetUsername() == user)
                {
                    u.SetRole(role);
                    u.SetPassword(pss);
                    return true;
                }
            }
            return false;

        }

        public static string parseData(string record, int field)
        {
            int comma = 1;
            string item = string.Empty;
            for (int x = 0; x < record.Length; x++)
            {
                if ((record[x] == ','))
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item += record[x];

                }
            }
            return item;
        }
        public static bool readDataFromFile(string path)
        {
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);
                string record;
                while ((record = sr.ReadLine()) != null)
                {
                    string userName = parseData(record, 1);
                    string userPassword = parseData(record, 2);
                    string userRole = parseData(record, 3);
                    User user = new User(userName, userPassword, userRole);
                    AddUserIntoList(user);
                }
                sr.Close();
                return true;
            }
            return false;
        }
        public static void storeUserIntoFile(User user, string path)
        {
            StreamWriter streamWriter = new StreamWriter(path, true);
            streamWriter.WriteLine(user.GetUsername() + "," + user.GetPassword() + "," + user.GetRole());
            streamWriter.Flush();
            streamWriter.Close();
        }
    }
}
