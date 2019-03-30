using SwordAndFather.Models;

namespace SwordAndFather.Controllers
{
    public class CreateUserRequestValidator
    {
        public bool Validate(CreateUserRequest requestToValidate)
        {
            return string.IsNullOrEmpty(requestToValidate.Username)
                || string.IsNullOrEmpty(requestToValidate.Password);
            //can validate all things with the string, has username been already used?
            
        }
    }
}