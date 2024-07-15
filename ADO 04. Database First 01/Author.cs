namespace ADO_04._Database_First_01;

public class Author
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public override string ToString()
    {
        return $@"--------------- {Id} ---------------
FirstName:          {FirstName}
LastName:           {LastName}
{new string('_', 33)}";
    }
}