using System;
using System.Xml.Serialization;
using Microsoft.Data.SqlClient;

class Program
{
    static void Main()
    {
        String ConnectionString=@"Data Source=DESKTOP-IC8IR0V\SQLEXPRESS;
        Initial Catalog=Adopractice;
        User ID=appuser;
        Password=App@1234;
        Encrypt=True;
        TrustServerCertificate=True;";
        using(SqlConnection connection=new SqlConnection(ConnectionString))
        {
            connection.Open();
            Console.WriteLine("Connection Successfull !");
            string insertQuery="Insert Into Employees (Name,Salary) VALUES (@Name,@Salary)";
            //Insert Part
            using (SqlCommand insertCommand=new SqlCommand(insertQuery, connection))
            {
                insertCommand.Parameters.AddWithValue("@Name","Ankit");
                insertCommand.Parameters.AddWithValue("@Salary",24515);
                int rowAffected=insertCommand.ExecuteNonQuery();
                Console.WriteLine($"Inserted {rowAffected} rows \n");
            }
        }
    }
}