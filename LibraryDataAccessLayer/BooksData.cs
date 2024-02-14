using System;
using System.Data;
using System.Data.SqlClient;

namespace LibraryDataAccessLayer
{
    public class BooksData
    {
        public static DataTable FetchBooks()
        {
            DataTable dt = new DataTable();


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Books";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static bool DeleteBook(int id)
        {

            int result = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"DELETE FROM BookCopies WHERE BookID = @BookID;
                DELETE FROM Books WHERE BookID = @BookID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookID", id);

            try
            {
                connection.Open();

                result = command.ExecuteNonQuery();

            }
            catch
            {
            }
            finally
            {
                connection.Close();
            }

            return (result > 0);

        }

        public static int AddBook(string Title, string ISBN, DateTime PublicationDate, string Genre, string AdditionalDetails, int Copies, string Image)
        {
            int newId = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"

INSERT INTO [dbo].[Books]
           ([Title]
           ,[ISBN]
           ,[PublicationDate]
           ,[Genre]
           ,[AdditionalDetails]
           ,[AvailableCopies]
           ,[copies]
           ,[Image]
)
     VALUES
           (@Title
           ,@ISBN
           ,@PublicationDate
           ,@Genre
           ,@AdditionalDetails
           ,@copies
           ,@copies
           ,@Image);

            SELECT SCOPE_IDENTITY();
            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@ISBN", ISBN);
            command.Parameters.AddWithValue("@PublicationDate", PublicationDate);
            command.Parameters.AddWithValue("@Genre", Genre);
            command.Parameters.AddWithValue("@AdditionalDetails", AdditionalDetails);
            command.Parameters.AddWithValue("@copies", Copies);
            command.Parameters.AddWithValue("@Image", Image);


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    newId = insertedID;
                }
            }
            catch
            {

            }
            finally { connection.Close(); }
            if (newId != -1)
                AddCopies(newId, Copies);

            return newId;
        }

        private static int AddCopies(int BookId, int Copies)
        {
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"

            INSERT INTO [dbo].[BookCopies]
            ([BookID]
            ,[AvailabilityStatus])
            VALUES
            (@BookID
            ,1)

            "
            ;

            for (int i = 1; i < Copies; i++)
            {
                query += ",(@BookID, 1)";
            }
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BookID", BookId);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return RowsAffected;

        }


    }
}
