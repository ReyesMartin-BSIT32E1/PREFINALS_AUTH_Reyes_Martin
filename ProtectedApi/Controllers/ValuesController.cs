using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProtectedApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize] // Requires authentication for all actions in this controller
    public class ValuesController : ControllerBase
    {
        [HttpGet("userinfo")]
        public IActionResult GetUserInfo()
        {
            // Get user information from claims
            var username = User.Identity.Name;

            // Return user information
            return Ok(new { Username = username, Section = "YourSection", Course = "YourCourse" });
        }

        [HttpGet("funfacts")]
        public IActionResult GetFunFacts()
        {
            // Return fun facts about the API creator
            string[] funFacts = {
                "Fun fact 1",
                "Fun fact 2",
                // Add more fun facts here
            };

            return Ok(funFacts);
        }
    }
}