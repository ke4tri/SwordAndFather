using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwordAndFather.Models;

namespace SwordAndFather.Data
{
    // Stores Users with the UserRepository
    // They do not just do one thing though
    public class UserRepository
    {
        static List<User> _users = new List<User>(); // static and instantce members

        public User AddUser(string userName, string password)
        {
            //datavase-y sort of thing
            var newUser = new User(userName, password);

            newUser.Id = _users.Count + 1;

            _users.Add(newUser);

            return newUser;
        }

    }
}
