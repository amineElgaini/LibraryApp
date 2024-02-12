using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDataAccessLayer;

namespace LibraryBusinessLayer
{
    public class clsUsers
    {
        public int userId { get; }
        public string name {get; set;}
        public string ContactInformation { get; set;}
        public string LibraryCardNumber { get; set;}
        
        public clsUsers()
        {
            userId = -1;
            name = "";
            ContactInformation = "";
            LibraryCardNumber = "";
        }

        public static DataTable GetAllUsers()
        {
            return UsersData.GetAllUsers();
        }

        public void save ()
        {
            if (this.userId == -1)
            {

            } else
            {

            }
        }
    }
}
