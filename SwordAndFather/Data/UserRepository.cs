using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public List<User> GetAll()
        {
            var users = new List<User>();
            var connection = new SqlConnection("Server=localhost;Database=SwordAndFather; Trusted_Connection = True;");
            connection.Open();

            var getAllUsersCommand = connection.CreateCommand();
            getAllUsersCommand.CommandText = "select * from users";

            var reader = getAllUsersCommand.ExecuteReader();


            while (reader.Read())
            {
                //returns object not int
                //var Id = reader[0];
                //var Id = (int)reader[0];
                //var Id = reader.GetInt32(0);
                var id = (int)reader["Id"];
                var username = reader["username"].ToString();
                var password = reader["password"].ToString();
                var user = new User(username, password) { Id = id } ;

                users.Add(user);
            }
            connection.Close();
            return users;
        }
            

    }
}
