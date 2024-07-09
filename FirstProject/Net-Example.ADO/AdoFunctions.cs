using Microsoft.Data.SqlClient;

namespace Net_Example.ADO;

public class AdoFunctions
{
    public void SimpleImplementation()
    {
        string connectionString = "Server=.;initial catalog=SampleDB;User Id=sa;Password=1qaz@WSX ";
        SqlConnection connection = new(connectionString);
        SqlCommand command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM Categories";

        connection.Open();
        var reader = command.ExecuteReader();
        while (reader.Read())
        {
            Console.WriteLine($"Id : {reader["Id"]} | Name : {reader["Name"]}");
        }
        connection.Close();
        Console.ReadKey();
    }
}
