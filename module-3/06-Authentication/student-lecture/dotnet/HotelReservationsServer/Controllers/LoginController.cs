using HotelReservations.DAO;
using HotelReservations.Security;
using HotelReservations.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace HotelReservations.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ITokenGenerator tokenGenerator;
        private readonly IPasswordHasher passwordHasher;
        private readonly IUserDao userDao;

        public LoginController(ITokenGenerator _tokenGenerator, IPasswordHasher _passwordHasher, IUserDao _userDao)
        {
            tokenGenerator = _tokenGenerator;
            passwordHasher = _passwordHasher;
            userDao = _userDao;
        }

        [HttpPost]
        public IActionResult Authenticate(LoginUser userParam)
        {
            // Get the user by username
            User user = userDao.GetUser(userParam.Username);

            // If no user was found or it was a password mismatch, return a generic bad request.
            if (user == null || !passwordHasher.VerifyHashMatch(user.PasswordHash, userParam.Password, user.Salt))
            {
                return BadRequest(new { message = "Username or password is incorrect" });
            }

            // Create an authentication token
            string token = tokenGenerator.GenerateToken(user.Id, user.Username, user.Role);

            // Create a ReturnUser object to return to the client
            ReturnUser retUser = new ReturnUser() 
            { 
                Id = user.Id, 
                Username = user.Username, 
                Role = user.Role, 
                Token = token 
            };

            return Ok(retUser);
        }

        [HttpGet]
        public ActionResult GetUserInformation()
        {
            return Ok(User.Identity.Name); // TODO: Take a look at the user's information via the debugger
        }

        [HttpGet("test/auth")]
        public ActionResult AuthorizedOnly()
        {
            return Ok(); // TODO: Restrict this to only authenticated users
        }


        [HttpGet("test/admin")]
        public ActionResult AdminOnly()
        {
            return Ok(); // TODO: Restrict this to only admin users
        }

    }
}
