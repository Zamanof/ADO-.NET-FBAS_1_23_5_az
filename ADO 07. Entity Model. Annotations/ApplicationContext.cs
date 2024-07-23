using Microsoft.EntityFrameworkCore;

namespace ADO_07._Entity_Model._Annotations
{
    internal class ApplicationContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }

        public ApplicationContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=EntityModelAnnotation;Integrated Security=SSPI;")
                .UseAllCheckConstraints();
        }
    }
}
