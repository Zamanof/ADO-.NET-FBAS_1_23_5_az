using ADO_07._Entity_Model__FluentApi;

// Entity Model. Annotations



using ApplicationContext db = new();
List<Student> students = [
    new Student(){
        FirstName = "Nadir",
        LastName = "Zamanov",
        Age = 44,
        Gender = false,
        Email = "zamanov@itstep.org"
    },
    new Student(){
        FirstName = "Salam",
        LastName = "Salamov",
        Age = 25,
        Gender = false,
        Email = "salamov@itstep.org"
    },
    ];

Group group = new()
{
    GroupName = "FBAS_1_23_5_az",
    GroupRating = 12,
    CourseYear = 2,
    Students = students
};

Student student = new()
{
    FirstName = "Ali",
    LastName = "Aliyev",
    Age = 25,
    Gender = false,
    Email = "Aliyev@itstep.org",
    GroupId = 1
};
db.Groups.Add(group);
db.SaveChanges();

