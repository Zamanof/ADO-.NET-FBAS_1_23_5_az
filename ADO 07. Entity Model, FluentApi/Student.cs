namespace ADO_07._Entity_Model__FluentApi;
internal class Student
{
   
    public int StudentNumber { get; set; }
   
    public string? FirstName { get; set; }
   
    public string? LastName { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public bool Gender { get; set; }

    // Foreign Key
    public int GroupId {  get; set; }

    // Navigation Property
    public Group? Group { get; set; }

}
