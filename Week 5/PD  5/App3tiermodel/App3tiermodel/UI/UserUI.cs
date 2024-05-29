using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App3tiermodel.BL;

namespace App3tiermodel.UI
{
    internal class UserUI
    {
        public static User MakeUser()
        {
            User u = new User(MenuUI.EnterID(), MenuUI.EnterPassword(), MenuUI.EnterRole());
            return u;
        }
    }
}
