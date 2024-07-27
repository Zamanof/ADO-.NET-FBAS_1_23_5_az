using ADO_08._Read_Relational_data._Lazy_Loading;
// Read relational datas

// Eager loading    (Hevesli yukleme)
// Explicit loading (Ashkar yukleme)
// Lazy loading     (Tenbel yukleme)
// Lazy Loadingin ishlemesi uchun:
// 1. Contextde .UseLazyLoadingProxies() methodu chaqrilmalidir (Microsoft.EntityFrameworkCore.Proxies)
// 2. Butun Entity Model class-lari inheritance uchun achiq olmalidir
// 3. Butun Navigation Property-ler vitrual olmalidir



using ApplicationContext db = new();


//List<Student> students = [
//    new Student(){
//        FirstName = "Tulku",
//        LastName = "Heci",
//        Age = 14
//    },
//    new Student(){
//        FirstName = "Kechi",
//        LastName = "Boz",
//        Age = 3
//    },
//    new Student(){
//        FirstName = "QanXoruz",
//        LastName = "Mercanzade",
//        Age = 7
//    }
//];

//db.Groups.Add(new Group() { Name = "AnimalFarm", Students = students });
//db.Groups.Add(new Group()
//{
//    Name = "Teenage Mutant Ninja Turtles",
//    Students = new List<Student>()
//    {
//        new Student()
//        {
//            FirstName = "Leonardo",
//            LastName = "Splinteroglu",
//            Age = 40
//        },
//        new Student()
//        {
//            FirstName = "Michelangelo",
//            LastName = "Splinteroglu",
//            Age = 40
//        },
//        new Student()
//        {
//            FirstName = "Raphael",
//            LastName = "Splinteroglu",
//            Age = 40
//        },
//        new Student()
//        {
//            FirstName = "Donatello",
//            LastName = "Splinteroglu",
//            Age = 40
//        },
//        new Student()
//        {
//            FirstName = "Mbappe",
//            LastName = "Kylian",
//            Age = 26
//        }
//    }
//});

//db.Students.Add(new Student
//{
//    FirstName = "Ushaq",
//    LastName = "BuzUsteQochaq",
//    GroupId = 2
//});

//db.Students.Add(new Student
//{
//    FirstName = "Pishik",
//    LastName = "QatiqChorekYemishik",
//    GroupId = 1
//});

//db.SaveChanges();

var groups = db.Groups.ToList();
foreach (var group in groups)
{
    Console.WriteLine(group);
    foreach (var st in group.Students)
    {
        Console.WriteLine($"        {st}");
    }
}

Console.ReadLine();
db.Students.Add(new Student
{
    FirstName = "Salat",
    LastName = "Sezarov",
    GroupId = 2
});

db.SaveChanges();

var groups1= db.Groups.ToList();
foreach (var group in groups1)
{
    Console.WriteLine(group);
    foreach (var st in group.Students)
    {
        Console.WriteLine($"        {st}");
    }
}