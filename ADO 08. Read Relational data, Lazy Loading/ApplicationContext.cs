﻿using Microsoft.EntityFrameworkCore;

namespace ADO_08._Read_Relational_data._Lazy_Loading;

internal class ApplicationContext: DbContext
{
    public DbSet<Group> Groups { get; set; }
    public DbSet<Student> Students { get; set; }

    public ApplicationContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseLazyLoadingProxies()
            .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=LazyDataLoading;Integrated Security=SSPI;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>().Property(x=> x.FirstName).IsRequired();
        modelBuilder.Entity<Student>().Property(x=> x.LastName).IsRequired();
    }
}