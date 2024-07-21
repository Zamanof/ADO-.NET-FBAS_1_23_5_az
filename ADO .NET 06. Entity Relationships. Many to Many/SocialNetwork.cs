namespace ADO_.NET_06._Entity_Relationships._Many_to_Many;

internal class SocialNetwork
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<User> Users { get; set; } = new List<User>();
    public override string ToString()
    {
        return Name;
    }
}
