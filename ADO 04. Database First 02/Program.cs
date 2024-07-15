using ADO_04._Database_First_02;

using LibraryContext db = new LibraryContext();

var books = db.Books.ToList();

foreach (var book in books)
{
    Console.WriteLine($"{book.Id} - {book.Name} - {book.Pages}");
}
