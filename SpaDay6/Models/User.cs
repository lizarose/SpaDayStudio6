using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

namespace SpaDay6;

public class User
{
    //Properties
    public int Id { get; }
    static int nextId = 1;
   public string Username { get; set; }
   public string Email { get; set; }
   public string Password { get; set; } 
   public DateTime Date { get; set; } = DateTime.Now;

   //Constructor
public User()
{
    Id = nextId;
    nextId++;
}

public User (string username, string email, string password)
{
    Username = username;
    Email = email;
    Password = password;
}
   //Override

   //Method

}
