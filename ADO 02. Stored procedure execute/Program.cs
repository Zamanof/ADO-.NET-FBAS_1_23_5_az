using System.Data.SqlClient;

// Procedure Create
//using (SqlConnection connection = new(@"Server = (localdb)\MSSQLLocalDB; Integrated Security = SSPI; Database = Library"))
//{
//    connection.Open();
//    SqlCommand cmd = new SqlCommand(
//@"CREATE PROCEDURE getBookNumber
//@AuthorId int, @BookCount int OUTPUT
//AS
//BEGIN
//    SELECT @BookCount = COUNT(*)
//    FROM Books AS B JOIN Authors AS A ON B.Id_Author = A.Id
//    WHERE A.Id = @AuthorId
//END
//", connection);
//    cmd.ExecuteNonQuery();
//}

using (SqlConnection connection = new(@"Server = (localdb)\MSSQLLocalDB; Integrated Security = SSPI; Database = Library"))
{
    connection.Open();
    SqlCommand cmd = new SqlCommand("getBookNumber", connection);
    cmd.CommandType = System.Data.CommandType.StoredProcedure;
    cmd.Parameters.Add("@AuthorId", System.Data.SqlDbType.Int).Value = Console.ReadLine();
    SqlParameter output = new SqlParameter("@BookCount", System.Data.SqlDbType.Int);
    output.Direction = System.Data.ParameterDirection.Output;
    cmd.Parameters.Add(output);
    cmd.ExecuteNonQuery();
    Console.WriteLine(cmd.Parameters["@BookCount"].Value);
}