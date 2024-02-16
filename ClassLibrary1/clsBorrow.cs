using LibraryBusinessLayer;
using LibraryDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class clsBorrow
    {
        public static bool Borrow(int UserID, int BookID, DateTime BorrowingDate, DateTime DueDate)
        {
            return BorrowData.AddBorrow(UserID, BookID, BorrowingDate, DueDate);
        }

        public static DataTable FetchBorrowing()
        {
            return BorrowData.GetAllBorrowing();
        }

        public static bool IsAvailable(int BookId)
        {
            return BorrowData.IsAvailable(BookId);
        }

        public static bool Pay(int BorrowingID)
        {
            return BorrowData.Pay(BorrowingID);
        }

        public static bool Return(int BorrowingID)
        {
            return BorrowData.Return(BorrowingID);
        }
    }
}
