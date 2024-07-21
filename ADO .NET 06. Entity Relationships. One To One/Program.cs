using ADO_.NET_06._Entity_Relationships._One_To_One;
using Microsoft.EntityFrameworkCore;
// Entity Relationships. One To One


using StudentContext db = new StudentContext();

//Student student = new Student() { 
//    FirstName = "Donald",
//    LastName = "Duck",
//    BirthDay = new DateTime(1934, 5, 17)
//};

//StudentCard donaldCard = new()
//{
//    StartDate = new DateTime(1951, 9, 1),
//    EndDate = new DateTime(1955, 9, 1),
//    Student = student
//};

//db.StudentCards.Add(donaldCard);
//db.SaveChanges();

var studentCards = db.StudentCards.Include(x=>x.Student).ToList();

Console.WriteLine(studentCards[0]);
Console.WriteLine(studentCards[0].Student);