using ADO_08._Read_Relational_data__Explicit_Loading;
using Microsoft.EntityFrameworkCore;

// Read relational datas

// Eager loading    (Hevesli yukleme)
// Explicit loading (Ashkar yukleme)
// Lazy loading     (Tenbel yukleme)



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

// Load

//var group = db.Groups.FirstOrDefault(g=> g.Id == 2);
//db.Students.Where(s => s.GroupId == group.Id).Load();

//Console.WriteLine(group);
//foreach (var s in group.Students)
//{
//    Console.WriteLine($"        {s}");
//}

db.Students.Load();
db.Groups.Load();

var groups = db.Groups.ToList();
foreach (var g in groups)
{
    Console.WriteLine(g);
    foreach (var s in g.Students)
    {
        Console.WriteLine($"        {s}");
    }
}
