using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Net;

namespace LibraryDataAccessLayer
{
    public class BorrowData
    {
        //public static bool GetUserInfoByID(int ID, ref string Name, ref string Email, ref DateTime BirthDate,
        //ref string LibraryCardNumber, ref string image)
        //{
        //    bool isFound = false;

        //    SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

        //    string query = "SELECT * FROM Users WHERE UserId = @ID";

        //    SqlCommand command = new SqlCommand(query, connection);

        //    command.Parameters.AddWithValue("@ID", ID);

        //    try
        //    {
        //        connection.Open();
        //        SqlDataReader reader = command.ExecuteReader();

        //        if (reader.Read())
        //        {
        //            isFound = true;

        //            Name = (string)reader["Name"];
        //            Email = (string)reader["Email"];
        //            if (reader["BirthDate"] != DBNull.Value)
        //            {
        //                BirthDate = (DateTime)reader["BirthDate"];
        //            }
        //            else
        //            {
        //                BirthDate = DateTime.Today;
        //            }
        //            LibraryCardNumber = (string)reader["LibraryCardNumber"];

        //            if (reader["image"] != DBNull.Value)
        //            {
        //                image = (string)reader["image"];
        //            }
        //            else
        //            {
        //                image = "";
        //            }

        //        }
        //        else
        //        {
        //            isFound = false;
        //        }

        //        reader.Close();


        //    }
        //    catch (Exception ex)
        //    {
        //        isFound = false;
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }

        //    return isFound;
        //}

        public static bool IsAvailable(int BookID)
        {
            int copy = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                SELECT copyID from Books b inner join bookCopies bc on b.bookId = bc.bookID
                    where b.bookID = @BookID and bc.AvailabilityStatus = 1;
            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BookID", BookID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int copyId))
                {
                    copy = copyId;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (copy > 0);
        }

        public static bool UpdateUser(int UserID, string Name, string LibraryCardNumber, string Email, string image, DateTime BirthDate)
        {
            int updatedRows = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                UPDATE
                    Users
                SET
                    name = @name,
                    Email = @Email,
                    LibraryCardNumber = @LibraryCardNumber,
                    image = @image,
                    BirthDate = @BirthDate
                WHERE
                    UserID = @UserID
                ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@LibraryCardNumber", LibraryCardNumber);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@BirthDate", BirthDate);

            if (image != "" && image != null)
                command.Parameters.AddWithValue("@image", image);
            else
                command.Parameters.AddWithValue("@image", System.DBNull.Value);

            try
            {
                connection.Open();

                updatedRows = command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (updatedRows > 0);
        }

        public static bool AddBorrow(int UserID, int BookID, DateTime BorrowingDate, DateTime DueDate)
        {
            int newId = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                DECLARE @Copy INT;
                SELECT @Copy = copyID from Books b inner join bookCopies bc on b.bookId = bc.bookID
                    where b.bookID = @BookID and bc.AvailabilityStatus = 1;

                if @copy is not null
	                begin
		                insert into BorrowingRecords(UserID, CopyID, BorrowingDate, DueDate) values(@UserID, @Copy, @BorrowingDate, @DueDate);
		                update Books set AvailableCopies = AvailableCopies-1 where BookID = @BookID;
		                update BookCopies set AvailabilityStatus = 0 where CopyID = @Copy;
	                end

                SELECT SCOPE_IDENTITY();
            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@BookID", BookID);
            command.Parameters.AddWithValue("@BorrowingDate", BorrowingDate);
            command.Parameters.AddWithValue("@DueDate", DueDate);

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
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (newId > 0);
        }

        //public static DataTable FindUsersById(int value)
        //{
        //    DataTable dt = new DataTable();
        //    SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

        //    string query = "SELECT * FROM Users WHERE UserId = @value";

        //    SqlCommand command = new SqlCommand(query, connection);

        //    command.Parameters.AddWithValue("@value", value);


        //    try
        //    {
        //        connection.Open();

        //        SqlDataReader reader = command.ExecuteReader();

        //        if (reader.HasRows)

        //        {
        //            dt.Load(reader);
        //        }

        //        reader.Close();


        //    }

        //    catch (Exception ex)
        //    {
        //        // Console.WriteLine("Error: " + ex.Message);
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }

        //    return dt;
        //}

        public static DataTable FindUsersByName(string value)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users WHERE Name like '%' + @value + '%'";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@value", value);


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
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        //public static bool DeleteUser(int id)
        //{

        //    int result = 0;
        //    SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

        //    string query = "Delete FROM Users WHERE userID = @userID";

        //    SqlCommand command = new SqlCommand(query, connection);
        //    command.Parameters.AddWithValue("@userID", id);

        //    try
        //    {
        //        connection.Open();

        //        result = command.ExecuteNonQuery();

        //    }
        //    catch
        //    {
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }

        //    return (result > 0);

        //}

        public static DataTable GetAllBorrowing()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM BorrowingRecords br left join fines f on br.BorrowingRecordID = f.BorrowingRecordID";

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
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }
    }
}
