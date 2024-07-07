#region ADO
// ADO - ActiveX Data Object for .NET

// MS SQL Server, OLE DB, ODBC, Oracle

// Ado Classes for DB
// DbConnection (SqlConnection, ...)
// DbCommand
// DbDataReader
// DbDataAdapter

// Ado datatypes for DB
// DataTable
// DataSet
// ...

// Connected mode
// Disconnected mode
#endregion

#region ConnectionStrings
// Data Source=STHQ012C-01;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False
// Data Source=STHQ012C-01;User ID=admin;Password=admin;Initial Catalog=AdoTest
// Server=STHQ012C-01;User ID=admin;Password=admin;Database=AdoTest
// Data Source=STHQ012C-01;Integrated Security=SSPI;Initial Catalog=AdoTest
#endregion

using System.Data.SqlClient;

SqlConnection sqlConnection = null;
string connectionString = @"Server=STHQ012C-01;User ID=admin;Password=admin;Database=AdoTest";
//sqlConnection = new SqlConnection(connectionString);

string insertQuery = @"INSERT INTO Authors(FirstName, LastName)
                        VALUES('Joseph', 'Albahari')";

//SqlCommand command = new SqlCommand(insertQuery, sqlConnection);
SqlCommand command = new SqlCommand();
//command.Connection = sqlConnection;
//command.CommandText = insertQuery;

//try
//{
//    sqlConnection.Open();
//    command.ExecuteNonQuery();
//}
//finally
//{
//    if (sqlConnection != null) sqlConnection.Close();
//}

using (sqlConnection = new SqlConnection(connectionString))
{
    sqlConnection.Open();
    string? FirstName = Console.ReadLine();
    string? LastName = Console.ReadLine();
    insertQuery =  $@"INSERT INTO Authors(FirstName, LastName)
                        VALUES('{FirstName}', '{LastName}')";
    command.Connection = sqlConnection;
    command.CommandText = insertQuery;
    command.ExecuteNonQuery();
}