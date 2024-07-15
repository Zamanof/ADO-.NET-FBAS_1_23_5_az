using Microsoft.EntityFrameworkCore;


namespace ADO_04._EF_Core_start__DB_First;
internal class StudentContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    public StudentContext()
    {
        //Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server = (localdb)\MSSQLLocalDB;Integrated Security = SSPI; Database = Students;");
    }
}
