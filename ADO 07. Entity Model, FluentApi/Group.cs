using System.ComponentModel.DataAnnotations;

namespace ADO_07._Entity_Model__FluentApi;

internal class Group
{
    public int Id { get; set; }
    public string GroupName { get; set; }
    public int GroupRating {  get; set; }
    public int CourseYear { get; set; }
    public List<Student> Students { get; set; } = [];
}
