using System;
namespace SpaDay.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User()
        {
        }

        public User(string u, string e, string p)
        {
            UserName = u;
            Email = e;
            Password = p;
        }

    }
}
