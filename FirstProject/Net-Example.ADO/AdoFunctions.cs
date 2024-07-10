using Microsoft.Data.SqlClient;

namespace Net_Example.ADO;

public class AdoFunctions
{
    public void SimpleImplementation()
    {
        string connectionString = "Server=.;initial catalog=SampleDB;User Id=sa;Password=1qaz@WSX";
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

    public void ConnectionsProperty()
    {
        string connectionString = "Server=.;initial catalog=SampleDB;User Id=sa;Password=1qaz@WSX";

        SqlConnection sqlConnection = new(connectionString);

        Console.WriteLine(sqlConnection.Database);
        Console.WriteLine(sqlConnection.DataSource);
        Console.WriteLine(sqlConnection.CommandTimeout);
        Console.WriteLine(sqlConnection.ConnectionTimeout);

        sqlConnection.Close();
    }

    /// <summary>
    /// Instead of using String connectionString, you should use SqlConnectionStringBuilder
    /// </summary>
    public void ConnectionBuilder()
    {
        SqlConnectionStringBuilder connectionBuilder = new SqlConnectionStringBuilder();

        connectionBuilder.InitialCatalog = "SampleDB";
        connectionBuilder.DataSource = ".";
        connectionBuilder.Password = "1qaz@WSX";
        connectionBuilder.UserID = "sa";
        connectionBuilder.Encrypt = false;
        connectionBuilder.ConnectTimeout = 100;
        connectionBuilder.CommandTimeout = 200;


        SqlConnection sqlConnection = new(connectionBuilder.ConnectionString);

        Console.WriteLine(sqlConnection.Database);
        Console.WriteLine(sqlConnection.DataSource);
        Console.WriteLine(sqlConnection.CommandTimeout);
        Console.WriteLine(sqlConnection.ConnectionTimeout);

        sqlConnection.Close();
    }
}
