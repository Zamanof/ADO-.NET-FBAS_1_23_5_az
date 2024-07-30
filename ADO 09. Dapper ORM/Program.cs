// Dapper ORM

using ADO_09._Dapper_ORM;
using System.Data.SqlClient;

IAuthorRepository repo = new AuthorRepository(new SqlConnection(),
    @"Server=(localdb)\MSSQLLocalDB;Database=Library;Integrated Security=SSPI;");

//var author = repo.Add(new Author() { FirstName = "Neil", LastName = "Gaiman" });
//var author2 = repo.Add(new Author() { FirstName = "Zahid", LastName = "Xelil" });
//Console.WriteLine(author2);

//Console.WriteLine(repo.GetById(13));
//repo.Remove(18);
repo.Update(new Author { Id = 16, FirstName = "Nadir", LastName = "Zaman" });
repo.GetAll().ToList().ForEach(Console.WriteLine);
