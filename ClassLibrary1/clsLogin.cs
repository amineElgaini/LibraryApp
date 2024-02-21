using LibraryDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class clsLogin
    {
        public static int Login(string userName, string password)
        {
            return LoginData.Login(userName, password);

        }
    }
}
