using ADO_04._Database_First_01;

using LibraryContext db = new LibraryContext();

db.Authors.ToList().ForEach(Console.WriteLine);
