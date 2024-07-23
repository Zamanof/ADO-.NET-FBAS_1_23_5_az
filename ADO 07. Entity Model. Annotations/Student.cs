namespace ADO_07._Entity_Model._Annotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Index(nameof(Email), IsUnique =true, Name ="UQ_Students_Email")]
internal class Student
{
    [Key]
    [Column("Id")]
    public int StudentNumber { get; set; }
    [Required]
    [MaxLength(50)]
    public string? FirstName { get; set; }
    [Required]
    [MaxLength(50)]
    public string? LastName { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public bool Gender { get; set; }

    // Foreign Key
    [ForeignKey(nameof(Group))]
    public int GroupId {  get; set; }

    // Navigation Property
    public Group? Group { get; set; }

}
