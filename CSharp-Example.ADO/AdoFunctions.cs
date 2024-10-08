﻿using System.Transactions;
using Microsoft.Data.SqlClient;

namespace CSharp_Example.ADO;

public class AdoFunctions
{
    private readonly SqlConnection _connection;

    public AdoFunctions()
    {
        SqlConnectionStringBuilder connectionBuilder = new SqlConnectionStringBuilder()
        {
            InitialCatalog = "SampleDB",
            DataSource = ".",
            Password = "1qaz@WSX",
            UserID = "sa",
            Encrypt = false,
            ConnectTimeout = 100,
            CommandTimeout = 200
        };

        _connection = new SqlConnection(connectionBuilder.ConnectionString);
    }

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

    public void CreateCommand()
    {
        SqlCommand command = new SqlCommand()
        {
            Connection = _connection,
            CommandType = System.Data.CommandType.Text,
            CommandText = "Select * from Categories"
        };

        _connection.Open();

        var reader = command.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"Id : {reader["Id"]} | Name : {reader["Name"]}");
        }

        _connection.Close();
    }

    /// <summary>
    /// This approach can be extremely effciently and the data won't store in the main storage,however
    /// untile your data are being read, the connection will be opened
    /// </summary>
    public void CreateDataReader()
    {
        SqlCommand command = new SqlCommand()
        {
            Connection = _connection,
            CommandType = System.Data.CommandType.Text,
            CommandText = "Select * from Categories"
        };

        _connection.Open();

        var reader = command.ExecuteReader();

        while (reader.Read())
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                Console.WriteLine($"{reader.GetName(i)} : {reader.GetValue(i)}");
            }
        }

        _connection.Close();
    }

    public void CreateMultipleDataReader()
    {
        SqlCommand sqlCommand = new SqlCommand()
        {
            Connection = _connection,
            CommandType = System.Data.CommandType.StoredProcedure,
            CommandText = "ProcedureName"
        };

        _connection.Open();

        var reader = sqlCommand.ExecuteReader();

        do
        {
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.WriteLine($"{reader.GetName(i)} : {reader.GetValue(i)}");
                }
            }

            Console.WriteLine("_________________________________________");

        } while (reader.NextResult());

        _connection.Close();
    }

    public void InsertBySqlParameter(string firstName, string lastName)
    {
        SqlParameter firstNameParam = new SqlParameter
        {
            ParameterName = "@firstName",
            DbType = System.Data.DbType.String,
            Direction = System.Data.ParameterDirection.Input,
            Value = firstName
        };

        SqlParameter lastNameParam = new SqlParameter
        {
            ParameterName = "@lastName",
            DbType = System.Data.DbType.String,
            Direction = System.Data.ParameterDirection.Input,
            Value = lastName
        };

        SqlCommand sqlCommand = new SqlCommand()
        {
            Connection = _connection,
            CommandType = System.Data.CommandType.Text,
            CommandText = "Insert Into Products(FirstName,LastName) values (@firstName,@lastName)"
        };

        sqlCommand.Parameters.Add(firstNameParam);
        sqlCommand.Parameters.Add(lastNameParam);

        _connection.Open();

        var result = sqlCommand.ExecuteNonQuery();

        Console.WriteLine($"{result} row Affected ");
    }

    public void CreateTransaction(string firstName, string lastName)
    {
        SqlTransaction transaction = null;
        
        SqlCommand sqlCommand = new SqlCommand()
        {
            Connection = _connection,
            CommandType = System.Data.CommandType.Text,
            CommandText = $"Insert Into Products(Id,FirstName,LastName) values ('{firstName}','{lastName}')"
        };

        _connection.Open();

        try
        {
            transaction = _connection.BeginTransaction();
            var result = sqlCommand.ExecuteNonQuery();

            transaction.Commit();

            Console.WriteLine($"{result} row Affected ");
        }
        catch (Exception ex)
        {
            Console.Write(ex.Message);
            transaction.Rollback();
        }

    }
}
