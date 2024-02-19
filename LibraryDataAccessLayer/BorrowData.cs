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

        public static bool IsBookIsReturned(int BorrowingId)
        {
            bool isReturned = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                SELECT top 1 found=1 from BorrowingRecords where ActualReturnDate is not null AND BorrowingRecordID=@BorrowingId;
            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BorrowingId", BorrowingId);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int value))
                {
                    isReturned = (value == 1);
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

            return isReturned;
        }

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

        public static bool Pay(int BorrowingID)
        {
            int result = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                
	            UPDATE fines SET PaymentStatus = 1 where BorrowingRecordID = @BorrowingID and PaymentStatus = 0
            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BorrowingID", BorrowingID);

            try
            {
                connection.Open();
                result = command.ExecuteNonQuery();

            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (result > 0);
        }

        public static bool Return(int BorrowingID)
        {
            int result = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                declare @found INT;
                select @found=1 from BorrowingRecords where BorrowingRecordID = @BorrowingID and ActualReturnDate is null;
                if @found = 1 begin
	                UPDATE BorrowingRecords SET ActualReturnDate = GETDATE() where BorrowingRecordID = @BorrowingID;
	
	                DECLARE @CopyID INT, @UserID INT, @NumberOfLateDays INT, @FineAmount INT;
	
	                select @CopyID = CopyID, @UserID = UserID, @NumberOfLateDays = DATEDIFF(day, DueDate, GETDATE()),
	                @FineAmount = (DATEDIFF(day, BorrowingDate, ActualReturnDate) * (SELECT DefaultFinePerDay FROM Settings))
	                from BorrowingRecords Br where BorrowingRecordID = @BorrowingID;

                    if @FineAmount < 0
                    begin
                        set @FineAmount = 0;
                    end
	
	                INSERT INTO Fines(UserID, BorrowingRecordID, NumberOfLateDays, FineAmount, PaymentStatus)
	                VALUES(@UserID, @BorrowingID, @NumberOfLateDays, @FineAmount, 0);
	
	                UPDATE BookCopies SET AvailabilityStatus = 1 WHERE CopyID = @CopyID;
	                UPDATE Books SET AvailableCopies = AvailableCopies+1 WHERE BookID = (SELECT BookID FROM BookCopies Bc WHERE Bc.CopyID = @CopyID);
                end
            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BorrowingID", BorrowingID);

            try
            {
                connection.Open();
                result = command.ExecuteNonQuery();

            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (result > 0);
        }
    }
}
