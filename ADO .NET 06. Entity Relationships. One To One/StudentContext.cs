using Microsoft.EntityFrameworkCore;

namespace ADO_.NET_06._Entity_Relationships._One_To_One;

internal class StudentContext: DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<StudentCard> StudentCards { get; set; }
    public StudentContext()
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=OneToOne;Integrated Security=SSPI;");
    }
}
