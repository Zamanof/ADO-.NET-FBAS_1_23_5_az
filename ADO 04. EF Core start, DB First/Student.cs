namespace ADO_04._EF_Core_start__DB_First;

internal class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }

    public override string ToString()
    {
        return $@"--------------- {Id} ---------------
FirstName:          {FirstName}
LastName:           {LastName}
Birthday:           {BirthDate.ToShortDateString()}
{new string('_', 33)}";
    }
}
