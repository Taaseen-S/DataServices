using System.Data;
using System.Data.SqlClient;

public class DatabaseAccess
{
    public static void GetClients()
    {
        using (SqlConnection conn = new SqlConnection("your_connection_string"))
        {
            SqlCommand cmd = new SqlCommand("GetClients", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"{reader["FirstName"]} {reader["LastName"]}");
            }

            conn.Close();
        }
    }
}
