// Entity Relationships. One To Many

using ADO_.NET_06._Entity_Relationships._One_To_Many;
using Microsoft.EntityFrameworkCore;

using GroupContext db = new();

//List<Student> students = new List<Student>()
//{
//    new Student()
//    {
//        FirstName = "Elvin",
//        LastName = "Siracli",
//        BirthDay = new DateTime(2008, 2, 11)
//    },
//     new Student()
//    {
//        FirstName = "Cavid",
//        LastName = "Atamoghlanov",
//        BirthDay = new DateTime(1998, 01, 01)
//    },
//      new Student()
//    {
//        FirstName = "Nadir",
//        LastName = "Zamanov",
//        BirthDay = new DateTime(1880, 10, 7)
//    },
//       new Student()
//    {
//        FirstName = "Neil",
//        LastName = "Armstrong",
//        BirthDay = new DateTime(1930, 8, 5)
//    },
//        new Student()
//    {
//        FirstName = "Elon",
//        LastName = "Mask",
//        BirthDay = new DateTime(1971, 6, 28)
//    }
//};

//Group stepGroup = new Group()
//{
//    Name = "FBAS_1_23_5_az",
//    Students = students
//};
//db.Groups.Add(stepGroup);

//Group ninjaGroup = new Group() {
//    Name = "Teenage Mutant Ninja Turtles",
//    Students = new List<Student>()
//    {
//        new Student()
//        {
//            FirstName = "Leonardo",
//            LastName = "Splinteroglu",
//            BirthDay = new DateTime(1984, 1, 13)
//        },
//        new Student()
//        {
//            FirstName = "Michelangelo",
//            LastName = "Splinteroglu",
//            BirthDay = new DateTime(1984, 1, 13)
//        },
//        new Student()
//        {
//            FirstName = "Raphael",
//            LastName = "Splinteroglu",
//            BirthDay = new DateTime(1984, 1, 13)
//        },
//        new Student()
//        {
//            FirstName = "Donatello",
//            LastName = "Splinteroglu",
//            BirthDay = new DateTime(1984, 1, 13)
//        },
//        new Student()
//        {
//            FirstName = "Mbappe",
//            LastName = "Kylian",
//            BirthDay = new DateTime(1998, 12, 20)
//        }
//    }
//};
//db.Groups.Add(ninjaGroup);
//db.SaveChanges();

var groups = db.Groups.Include(x=> x.Students).ToList();

foreach(var group in groups)
{
    Console.WriteLine(group);
    foreach(var student in group.Students)
    {
        Console.WriteLine($"    {student}");
    }
    Console.WriteLine();
}
