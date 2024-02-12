using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataAccessLayer
{
    public class UsersData
    {
        public static bool UpdateUser(int UserID, string Name, string LibraryCardNumber, string ContactInformation, string Image)
        {
            int updatedRows = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                UPDATE
                    Users
                SET
                    name = @name,
                    ContactInformation = @ContactInformation,
                    LibraryCardNumber = @LibraryCardNumber,
                    image = @Image,
                WHERE
                    UserID = @UserID
                ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@ContactInformation", ContactInformation);
            command.Parameters.AddWithValue("@LibraryCardNumber", LibraryCardNumber);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Image", Image);

            try
            {
                connection.Open();

                updatedRows = command.ExecuteNonQuery();
            } catch
            {
                return false;
            } finally
            {
                connection.Close();
            }

            return (updatedRows > 0);
        }

        public static bool AddUser(int UserID, string Name, string LibraryCardNumber, string ContactInformation, string Image)
        {
            int updatedRows = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                INSERT INTO
                    Users
                VALUES(
                    null,
                    @name,
                    @ContactInformation,
                    @LibraryCardNumber,
                    @Iamge,
                );
                   
                ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@ContactInformation", ContactInformation);
            command.Parameters.AddWithValue("@LibraryCardNumber", LibraryCardNumber);
            command.Parameters.AddWithValue("@Name", Name);
            if (Image != "" && Image != null)
                command.Parameters.AddWithValue("@image", Image);
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

        public static DataTable GetAllUsers() {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users";

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
