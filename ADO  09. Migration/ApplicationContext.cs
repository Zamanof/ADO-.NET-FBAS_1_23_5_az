using Microsoft.EntityFrameworkCore;

namespace ADO__09._Migration;

internal class ApplicationContext: DbContext
{
    public DbSet<Student> Students { get; set; }
    public ApplicationContext()
    {
        //Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=DataMigration;Integrated Security=SSPI;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>().Property(x => x.FirstName).IsRequired();
        modelBuilder.Entity<Student>().Property(x => x.LastName).IsRequired();
    }
}
