namespace ADO_.NET_06._Entity_Relationships._One_To_Many;

internal class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDay { get; set; }

    public override string ToString()
    {
        return $"Firstname: {FirstName} Lastname: {LastName} Birthday: {BirthDay.ToShortDateString()}";

    }
}
