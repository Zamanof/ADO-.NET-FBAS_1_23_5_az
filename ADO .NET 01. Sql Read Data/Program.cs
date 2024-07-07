using System.Data.SqlClient;


string connectionString = @"Server=STHQ012C-01;User ID=admin;Password=admin;Database=AdoTest";
SqlDataReader reader = null;
SqlCommand cmd = null;
#region Read Data
//using (SqlConnection connection = new SqlConnection(connectionString))
//{
//    cmd = new(@"SELECT * FROM Authors", connection);
//    connection.Open();
//    reader = cmd.ExecuteReader();

//    while (reader.Read())
//    {
//        Console.WriteLine($"{reader[0]}. {reader[1]} {reader[2]}");
//    }
//}

//using (SqlConnection connection = new SqlConnection(connectionString))
//{
//    cmd = new(@"SELECT * FROM Authors", connection);
//    connection.Open();
//    reader = cmd.ExecuteReader();

//    while (reader.Read())
//    {
//        Console.WriteLine($"{reader["Id"]}. {reader["FirstName"]} {reader["LastName"]}");
//    }
//}


connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=Library;Integrated Security=SSPI;";
//using (SqlConnection connection = new SqlConnection(connectionString))
//{
//    cmd = new(@"SELECT * FROM Authors", connection);
//    connection.Open();
//    reader = cmd.ExecuteReader();

//    while (reader.Read())
//    {
//        Console.WriteLine($"{reader["Id"]}. {reader["FirstName"]} {reader["LastName"]}");
//    }
//}


using (SqlConnection connection = new(connectionString))
{
    SqlDataReader dataReader = null;
    SqlCommand command = new(@"SELECT * FROM Authors", connection);
    connection.Open();
    reader = command.ExecuteReader();

    bool line = true;

    while (reader.Read())
    {
        if (line)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                Console.Write($"{reader.GetName(i)}\t\t");
            }
            Console.WriteLine();
            for (int i = 0; i < reader.FieldCount; i++)
            {
                Console.Write($"{reader[i]}\t\t");
            }
            line = false;
        }
        else
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                Console.Write($"{reader[i]}\t\t");
            }
        }
        Console.WriteLine();

    }

}

#endregion
