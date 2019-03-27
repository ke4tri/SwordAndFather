using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc; // mvc patterns
using SwordAndFather.Models;

namespace SwordAndFather.Controllers
{
    [Route("api/[controller]")] // attribute defines additional infomration about class(metadata)
    [ApiController] // atribute each attribute is a class
    //[Route("api/[controller]"), ApiController] [ApiControllerAttribute] is the same

    public class UsersController : ControllerBase
    {
        static List<User> _users = new List<User>(); // static and instantce members

        [HttpPost("register")]
        public int AddUser(User newUser)
        {

            //var newUser = new User(username, password);
            newUser.Id = _users.Count + 1;
            _users.Add(newUser);
            return newUser.Id;
        }
    }
}