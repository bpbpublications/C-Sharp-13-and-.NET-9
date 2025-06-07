using System;
using System.Data.SqlClient;

public class Program
{
    public static void Main()
    {
        string connectionString = "Data Source=localhost;Initial Catalog=FarmingDB;Integrated Security=True";
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            // Query 1: Fetch all Farms that grow more than 3 types of Vegetables
            string query1 = @"SELECT f.Name FROM Farms f
WHERE (SELECT COUNT(*) FROM Vegetables v WHERE v.FarmId = f.Id) > 3";
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            Console.WriteLine("Farms with multiple types of Vegetables:");
            while (reader1.Read())
            {
                Console.WriteLine(reader1["Name"].ToString());
            }

            reader1.Close();
            // Query 2: Fetch all Farms that are growing Carrots
            string query2 = @"SELECT f.Name FROM Farms f
INNER JOIN Vegetables v ON f.Id = v.FarmId
WHERE v.Name = ’Carrot’";
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            Console.WriteLine("\nFarms growing Carrots:");
            while (reader2.Read())
            {
                Console.WriteLine(reader2["Name"].ToString());
            }

            reader2.Close();
            // Query 3: Fetch the total quantity of all Crops grown in all Farms
            string query3 = @"SELECT SUM(c.Quantity) FROM Crops c";
            SqlCommand cmd3 = new SqlCommand(query3, conn);
            int totalCropQuantity = (int)cmd3.ExecuteScalar();
            Console.WriteLine($"\nTotal quantity of all Crops: {totalCropQuantity}");
        }
    }
}