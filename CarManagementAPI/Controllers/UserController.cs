using CarManagementAPI.Models;
using CarManagementAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] User model)
        {
            var user = _userService.Authenticate(model.Username, model.Password);
            if (user == null)
                return Unauthorized();

            return Ok(user);
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] User model)
        {
            _userService.Register(model);
            return Ok();
        }
    }
}
