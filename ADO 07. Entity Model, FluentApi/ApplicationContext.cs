using Microsoft.EntityFrameworkCore;

namespace ADO_07._Entity_Model__FluentApi;

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
            .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=EntityModelFluentAPI;Integrated Security=SSPI;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Student
        modelBuilder
            .Entity<Student>()
            .Property(x => x.StudentNumber)
            .HasColumnName("Id")
            .ValueGeneratedOnAdd();
        modelBuilder.Entity<Student>()
            .HasKey(x => x.StudentNumber);
        modelBuilder
            .Entity<Student>()
            .Property(x => x.FirstName)
            .IsRequired()
            .HasMaxLength(50);
        modelBuilder
           .Entity<Student>()
           .Property(x => x.LastName)
           .IsRequired()
           .HasMaxLength(50);
        modelBuilder
            .Entity<Student>()
            .Property(x => x.Gender)
            .HasDefaultValue(true);
        modelBuilder
            .Entity<Student>()
            .HasIndex(x => x.Email)
            .IsUnique();

        modelBuilder
            .Entity<Student>()
            .HasOne(s=>s.Group)
            .WithMany(g => g.Students)
            .HasForeignKey(s=>s.GroupId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_Groups");

        // Group
        modelBuilder
            .Entity<Group>()
            .Property(x=>x.GroupName)
            .HasMaxLength(20);

        modelBuilder
            .Entity<Group>()
            .ToTable(x=>x.HasCheckConstraint("CK_Group_GroupRating","GroupRating >= 0 AND GroupRating<= 12"))
            .ToTable(x=>x.HasCheckConstraint("CK_Group_CourseYear", "CourseYear >= 1 AND CourseYear <= 4"));
        modelBuilder
            .Entity<Group>()
            .Property(x => x.GroupName)
            .HasColumnType("varchar");
        
    }
}
