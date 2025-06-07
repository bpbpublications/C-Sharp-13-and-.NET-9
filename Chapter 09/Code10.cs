using System.Data.SqlClient;

public class Program
{
    public static void Main()
    {
        string connectionString = "Data Source=localhost;Initial Catalog=FarmingDB;Integrated Security=True";
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string dropBeansTable = "DROP TABLE Beans;";
            string dropRicesTable = "DROP TABLE Rices;";
            using (SqlCommand command = new SqlCommand(dropBeansTable, conn))
            {
                command.ExecuteNonQuery();
            }

            using (SqlCommand command = new SqlCommand(dropRicesTable, conn))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}