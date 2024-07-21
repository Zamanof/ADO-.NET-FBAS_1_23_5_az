using Microsoft.EntityFrameworkCore;

namespace ADO_.NET_06._Entity_Relationships._Many_to_Many;

internal class SocialNetworkContext: DbContext
{
    public DbSet<SocialNetwork> SocialNetworks { get; set; }
    public DbSet<User> Users { get; set; }
    public SocialNetworkContext()
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ManyToMany;Integrated Security=SSPI;");

    }
}
