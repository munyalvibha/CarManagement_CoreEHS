using CarManagementAPI.Enum;
using Microsoft.AspNetCore.Mvc;

namespace CarManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MenuController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetMenu([FromQuery] Role role)
        {
            var menu = role switch
            {
                Role.Admin => new[] { "Dashboard", "Users", "Settings" },
                Role.User => new[] { "Dashboard", "Profile" },
                Role.Manager => new[] { "Dashboard", "Reports" },
                _ => new string[] { }
            };
            return Ok(menu);
        }
    }
}
