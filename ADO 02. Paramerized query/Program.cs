using System.Data.SqlClient;

using (SqlConnection connection = new(@"Server = (localdb)\MSSQLLocalDB; Integrated Security = SSPI; Database = Library"))
{
    connection.Open();
    string id = Console.ReadLine();
    string firstName = Console.ReadLine();
    //SqlCommand cmd = new SqlCommand(@$"SELECT * FROM Authors WHERE Id={id}", connection);
    //SqlDataReader reader = cmd.ExecuteReader();
    //do
    //{
    //    while (reader.Read())
    //    {
    //        for (int i = 0; i < reader.FieldCount; i++)
    //        {
    //            Console.Write($"{reader[i]}\t");
    //        }
    //        Console.WriteLine();
    //    }

    //} while (reader.NextResult());


    //SqlParameter parameter = new SqlParameter();
    //parameter.ParameterName = "@param1";
    //parameter.SqlDbType = System.Data.SqlDbType.Int;
    //parameter.Value = id;
    string query = "SELECT * FROM Authors WHERE Id > @param1 AND FirstName NOT LIKE @param2";
    SqlCommand cmd = new SqlCommand(query, connection);
    //cmd.Parameters.Add(parameter);
    cmd.Parameters.Add("@param1", System.Data.SqlDbType.Int).Value = id;
    cmd.Parameters.Add("@param2", System.Data.SqlDbType.NVarChar).Value = firstName;
    SqlDataReader reader = cmd.ExecuteReader();
    do
    {
        while (reader.Read())
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                Console.Write($"{reader[i]}\t");
            }
            Console.WriteLine();
        }
    } while (reader.NextResult());



}
