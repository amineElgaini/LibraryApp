using LibraryDataAccessLayer;
using System;
using System.Data;

namespace ClassLibrary1
{
    public class clsBooks
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Genre { get; set; }
        public string AdditionalDetails { get; set; }
        public int Copies { get; set; }
        public string Image { get; set; }

        public clsBooks()
        {
            BookID = -1;
            Title = "";
            ISBN = "";
            PublicationDate = DateTime.Now;
            Genre = "";
            AdditionalDetails = "";
            Copies = 0;
            Image = "";
        }

        public static DataTable FetchBooks()
        {
            return BooksData.FetchBooks();
        }

        public static bool DeleteBook(int id)
        {
            return BooksData.DeleteBook(id);
        }

        public bool Save()
        {
            this.BookID = BooksData.AddBook(Title, ISBN, PublicationDate, Genre, AdditionalDetails, Copies, Image);
            return BookID > -1;
        }
    }
}
