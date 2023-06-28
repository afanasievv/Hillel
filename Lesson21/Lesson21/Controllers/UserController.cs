using Microsoft.AspNetCore.Mvc;

namespace Lesson21.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private List<User> users = new List<User>();

        
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            return users;
        }

        
        [HttpGet("{name}")]
        public ActionResult<User> GetUserByName(string name)
        {
            var user = users.FirstOrDefault(u => u.Name == name);
            if (user == null)
            {
                return NotFound();
            }
            return user;
        }
                
        [HttpPost]
        public IActionResult CreateUser([FromBody] User user)
        {
            users.Add(user);
            return CreatedAtAction(nameof(GetUserByName), new { name = user.Name }, user);
        }

        [HttpPut("{name}")]
        public IActionResult UpdateUser(string name, [FromBody] User updatedUser)
        {
            var user = users.FirstOrDefault(u => u.Name == name);
            if (user == null)
            {
                return NotFound();
            }
            user.Age = updatedUser.Age;
            
            return NoContent();
        }

        [HttpDelete("{name}")]
        public IActionResult DeleteUser(string name)
        {
            var user = users.FirstOrDefault(u => u.Name == name);
            if (user == null)
            {
                return NotFound();
            }
            users.Remove(user);
            return NoContent();
        }
    }
}