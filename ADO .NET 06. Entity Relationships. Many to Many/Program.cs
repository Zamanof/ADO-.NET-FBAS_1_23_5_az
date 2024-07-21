// Entity relationships. Many to Many

using ADO_.NET_06._Entity_Relationships._Many_to_Many;
using Microsoft.EntityFrameworkCore;

using SocialNetworkContext db = new();
//SocialNetwork fb = new SocialNetwork() { Name = "Facebook"};
//SocialNetwork insta = new SocialNetwork() { Name = "Instagram"};
//SocialNetwork ok = new SocialNetwork() { Name = "OK"};

//User user1 = new User() 
//{
//    FirstName = "Nadir",
//    LastName = "Zamanov",
//    Login = "mr.13",
//    Password = "P@ss12345"
//};
//fb.Users.Add(user1);
//ok.Users.Add(user1);
//insta.Users.Add(user1);

//User user2 = new User()
//{
//    FirstName = "John",
//    LastName = "Doe",
//    Login = "JD",
//    Password = "q1w2e3r4t5y6"
//};
//fb.Users.Add(user2);
//insta.Users.Add(user2);

//db.SocialNetworks.AddRange(fb, insta, ok);
//db.SaveChanges();


//var networks = db.SocialNetworks.Include(s=> s.Users).ToList();
//foreach (var network in networks)
//{
//    Console.WriteLine(network.Name);
//	foreach (var user in network.Users)
//	{
//        Console.WriteLine($"    {user}");
//    }
//}

var users = db.Users.Include(u=> u.SocialNetworks).ToList();
foreach (var user in users)
{
    Console.WriteLine(user);
    foreach(var sn in user.SocialNetworks)
    {
        Console.WriteLine($"    {sn}");
    }
}
