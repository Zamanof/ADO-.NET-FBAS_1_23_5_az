namespace ADO_.NET_06._Entity_Relationships._Many_to_Many;

internal class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Login {  get; set; }
    public string Password {  get; set; }
    public List<SocialNetwork> SocialNetworks { get; set; } = new List<SocialNetwork>();
    public override string ToString()
    {
        return $"{Login} - > {FirstName} {LastName}";
    }
}
