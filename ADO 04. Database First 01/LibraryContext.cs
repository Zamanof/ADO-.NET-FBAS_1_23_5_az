using Microsoft.EntityFrameworkCore;

namespace ADO_04._Database_First_01;

internal class LibraryContext: DbContext
{
    public DbSet<Author> Authors { get; set; }
    public LibraryContext()
    {
        
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server = (localdb)\MSSQLLocalDB;Integrated Security = SSPI; Database = Library;");

    }
}
