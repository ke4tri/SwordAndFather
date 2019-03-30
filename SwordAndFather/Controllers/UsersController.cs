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
        readonly UserRepository _userRepository;
        readonly CreateUserRequestValidator _validator;

        public UsersController()
        {
            _userRepository = new UserRepository();
            _validator = new CreateUserRequestValidator();

        }

        [HttpPost("register")]
        public ActionResult<int> AddUser(CreateUserRequest createRequest)
        {

            var validator = new CreateUserRequestValidator();
            //validation
            if (!_validator.Validate(createRequest)) 
            {
                return BadRequest(new { error = "users must have a username and password" });
            }


           
            var newUser = _userRepository.AddUser(createRequest.Username, createRequest.Password);


            //http response
            return Created($"api/users/{newUser.Id}", newUser);
        }
    }
}