using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace LibraryDataAccessLayer
{
    public class LoginData
    {
        public static int Login(string userName, string password)
        {
            int id = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT AdminID FROM Admin inner join users on users.userID = admin.userId WHERE userName = @username and password = @password";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@userName", userName);
            command.Parameters.AddWithValue("@password", password);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    id = insertedID;
                }

            }
            catch (Exception ex)
            {
                return id;
            }
            finally
            {
                connection.Close();
            }

            return id;
        }
    }
}
