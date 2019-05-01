using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwordAndFather.Models
{
    public class User
    {
        //public User(string username, string password)
        //{
        //    Username = username;
        //    Password = password;
        //}
        // we are going to go with no constructor 
        // public User() { }

        //public int Id { get; set; }
        //public string Username { get; set; }
        //public string Password { get; set; }

        
            public int Id { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }

            public List<Target> Targets { get; set; }
        


    }
}
