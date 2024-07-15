using ADO_04._EF_Core_start__DB_First;
// EF Core
// ORM - Object-Relational Mapping

// Database First
// Code First
// Model First

#region Add Data
//using (StudentContext db = new StudentContext())
//{
//    Student student = new Student()
//    {
//        FirstName = "Freddie",
//        LastName = "Mercury",
//        BirthDate = new DateTime(1946, 9, 5)
//    };
//    db.Students.Add(student);

//    Student student1 = new Student()
//    {
//        FirstName = "Ibrahim",
//        LastName = "Talibli",
//        BirthDate = new DateTime(2008, 7, 10)
//    };
//    db.Students.Add(student1);

//    Student student2 = new Student()
//    {
//        FirstName = "Angelina",
//        LastName = "Jolie",
//        BirthDate = new DateTime(1975, 6, 4)
//    };
//    db.Students.Add(student2);
//    db.SaveChanges();
//}
#endregion

#region Add Datas
//using (var db = new StudentContext())
//{
//    List<Student> students = new List<Student>() {
//    new Student()
//    {
//        FirstName = "Elvin",
//        LastName = "Siracli",
//        BirthDate = new DateTime(2008, 2, 11)
//    },
//     new Student()
//    {
//        FirstName = "Cavid",
//        LastName = "Atamoghlanov",
//        BirthDate = new DateTime(1998, 01, 01)
//    },
//      new Student()
//    {
//        FirstName = "Nadir",
//        LastName = "Zamanov",
//        BirthDate = new DateTime(1880, 10, 7)
//    },
//       new Student()
//    {
//        FirstName = "Neil",
//        LastName = "Armstrong",
//        BirthDate = new DateTime(1930, 8, 5)
//    },
//        new Student()
//    {
//        FirstName = "Elon",
//        LastName = "Mask",
//        BirthDate = new DateTime(1971, 6, 28)
//    }
//};
//    //foreach (var student in students)
//    //{
//    //    db.Add(student);
//    //}

//    db.AddRange(students);
//    db.SaveChanges();
//}
#endregion

#region Read Data

//using (StudentContext db = new())
//{
//    var student = db.Students.FirstOrDefault();
//    Console.WriteLine(student);
//}

#endregion

using StudentContext db = new();

#region Read Datas

//var students = db.Students.ToList();
//students.ForEach(s=>Console.WriteLine(s));

//var youngStudents = db.Students
//    .Where(s => s.BirthDate.Year > 2000)
//    .ToList();
//youngStudents.ForEach(s =>Console.WriteLine(s));
#endregion

#region Delete Data
//db.Remove(db.Students.FirstOrDefault(s => s.FirstName == "Angelina"));
//db.SaveChanges();
#endregion

#region Delete Datas
//var studentsForRemove = db.Students
//    .Where(s => s.BirthDate.Month > 8);
//db.RemoveRange(studentsForRemove);
//db.SaveChanges();
#endregion

#region Update Data
//var student = db.Students.FirstOrDefault(s => s.FirstName == "Cavid");
//student.BirthDate = new DateTime(1998, 7, 15);
//db.Students.Update(student);
//db.SaveChanges();
#endregion

db.Database.EnsureDeleted();