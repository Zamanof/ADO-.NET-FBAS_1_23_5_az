using System.ComponentModel.DataAnnotations;

namespace ADO_07._Entity_Model._Annotations;

internal class Group
{
    public int Id { get; set; }
    public string GroupName { get; set; }
    [Range(0, 12)]
    public int GroupRating {  get; set; }
    [Range(1, 4)]
    public int CourseYear { get; set; }
    public List<Student> Students { get; set; } = [];
}
