using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDataAccessLayer;

namespace ClassLibrary1
{
    public class clsBooks
    {
        public static DataTable FetchBooks()
        {
            return BooksData.FetchBooks();
        }

        public static int AddBook()
        {
            return BooksData.AddBook("test", "HKFFI", "2022-10-10", "war", "+18", 4);
        }
    }
}
