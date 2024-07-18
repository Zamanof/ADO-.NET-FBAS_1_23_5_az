using ADO_05._LINQ_for_Entities;
using Microsoft.EntityFrameworkCore;
// LINQ for Entities


using LibraryContext db =  new LibraryContext();

//var authors = (from author in db.Authors
//              where author.Id > 5
//              select author).ToList();
//authors.ForEach(Console.WriteLine);

#region Where
//db.Authors.Where(a=>a.Id > 5).ToList().ForEach(Console.WriteLine);
#endregion

#region EF.Functions.Like()
//db.Authors.Where(a => a.LastName.EndsWith("ov") && !a.LastName.StartsWith("M")).ToList()
//    .ForEach(Console.WriteLine);

//db.Authors.Where(a=> EF.Functions.Like(a.LastName, "[^M]%ov")).ToList()
//    .ForEach(Console.WriteLine);
#endregion

#region Find, First, FirstOrDefault, Single, SingleOrDefault
//var author = db.Authors.Find(4);
//Console.WriteLine(author);

//author = db.Authors.FirstOrDefault(a=> a.FirstName=="Alexey");
//if (author != null) Console.WriteLine(author);
//else Console.WriteLine("Author not found");

//author = db.Authors.SingleOrDefault(a=> a.FirstName == "Alexey");
//if (author != null) Console.WriteLine(author);
//else Console.WriteLine("Author not found");

#endregion

#region Any, All
//Console.WriteLine(db.Authors.All(a=>a.FirstName.Length > 3));
//Console.WriteLine(db.Authors.Any(a=>a.FirstName == "Nadir"));
#endregion

#region Select
//var authors = db.Authors.Select(a=> new
//{
//    Id = a.Id,
//    FullName = a.LastName + " " + a.FirstName
//}).ToList();
//foreach (var auth in authors)
//{
//    Console.WriteLine($"{auth.Id}. {auth.FullName}");
//}

//var authorsWithBooks = db.Authors.Select(a => new
//{
//    FullName = a.LastName + " " + a.FirstName,
//    Books = a.Books
//}).ToList();

//foreach (var author in authorsWithBooks)
//{
//    Console.WriteLine(author.FullName);
//    Console.WriteLine();
//    foreach (var book in author.Books)
//    {
//        Console.WriteLine($"        {book}");
//    }
//}
#endregion

#region OrderBy, OrderByDescending, ThenBy, ThenByDescending
//var authors = db.Authors.OrderBy(a=>a.FirstName)
//    .ThenByDescending(a => a.LastName).ToList();
///*
//    SELECT Id, FirstName, LastName
//    FROM Authors
//    ORDER BY FirstName, LastName DESC
//*/

//authors.ForEach(Console.WriteLine);
#endregion

#region Join
//var books = db.Books.Join(db.Authors, b=>b.IdAuthor, a=>a.Id, 
//    (b, a) => new {
//        Name = b.Name,
//        Author = $"{a.FirstName} {a.LastName}"
//    }).ToList();
//books.ForEach(b=> Console.WriteLine($@"Book Name: {b.Name}
//Author: {b.Author}
//"));

/*
    SELECT B.[Name], A.FirstName + N' ' + A.LastName AS Author
    FROM Books AS B
    JOIN Authors AS A
    ON B.Id_Author = A.Id 
 */

#endregion

