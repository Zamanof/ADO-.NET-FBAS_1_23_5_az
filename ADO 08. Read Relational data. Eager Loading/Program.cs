using ADO_08._Read_Relational_data._Eager_Loading;
using Microsoft.EntityFrameworkCore;
// Read relational datas

// Eager loading    (Hevesli yukleme)
// Explicit loading (Ashkar yukleme)
// Lazy loading     (Tenbel yukleme)


using ApplicationContext db = new();

//db.Database.EnsureDeleted();
//db.Database.EnsureCreated();


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

//db.Students.Add(new Student {
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


// Include(), ThenInclude()
//var groups = db.Groups.Include(g=> g.Students).ToList();

//foreach (var g in groups)
//{
//    Console.WriteLine(g);
//    foreach (var s in g.Students)
//    {
//        Console.WriteLine($"        {s}");
//    }
//}

//var students = db.Students.Include(s=> s.Group);
//foreach (var student in students)
//{
//    Console.WriteLine($"{student} -> {student.Group}");
//}


// 
// Eger proqramda datalar contexte elave olunubsa onlari Include olmadan da load etmek mumkundur
//var groups1 = db.Groups.ToList();

//foreach (var group in groups1)
//{
//    Console.WriteLine(group);
//    foreach (var st in group.Students)
//    {
//        Console.WriteLine($"        {st}");
//    }
//}