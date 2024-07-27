namespace ADO_08._Read_Relational_data._Lazy_Loading;

public class Group
{
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual List<Student> Students { get; set; } = [];

    public override string ToString()
    {
        return Name;
    }
}
