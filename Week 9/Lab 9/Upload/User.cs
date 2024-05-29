using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Task1SignINSignUP.BL
{
    internal class User
    {
        private string UserName, Password, Role;

        public User(string userName, string password, string role)
        {
            this.UserName = userName;
            this.Password = password;
            this.Role = role;
        }
        public User(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;
            this.Role = "NA";
        }
        public string GetUsername()
        {
            return this.UserName;
        }
        public string GetPassword()
        {
            return this.Password;
        }
        public void SetPassword(string pss )
        {
             this.Password = pss;
        }
        public string GetRole()
        {
            return this.Role;
        }
        public void SetRole(string role)
        {
            this.Role =role ;
        }
        public bool IsAdmin()
        {
            if( this.Role == "admin" || this.Role == "Admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
