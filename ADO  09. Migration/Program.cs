using ADO__09._Migration;
// Migration
// Entity modelde her hansi bir deyishiklik olduqda database-de
// bu modeli deyishmek uchun:
// 1. Database-e el ile mudaxile (SQL ALTER, UI-da designer-de deyishmek)
//  Problem: SQL biliklerinin olmamasi
// 2. Database.//db.Database.EnsureDeleted(); db.Database.EnsureCreated();
//  Problem: database-in yerli-dibli silinmesi ve datanin itmesi
// 3. Migration: 
// Power Shell:  dotnet ef migrations add migration_name    - Migrasiyanin yaradilmasi
//               dotnet ef database update                  - Migrasiyanin database-e tetbiqi
// Package Manager Console: Add-Migration migration_name    - Migrasiyanin yaradilmasi
//                          Update-Database                 - Migrasiyanin database-e tetbiqi


using ApplicationContext db = new();
//db.Database.EnsureDeleted();
//db.Database.EnsureCreated();
Student student = new()
{
    FirstName = "John",
    LastName = "Doe"
};
db.Students.Add(student);
db.SaveChanges();

db.Students.ToList().ForEach(Console.WriteLine);

