using EjemploAPI01.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EjemploAPI01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private static List<User> Users = new List<User>
        {
            new User { Id = 1, Name = "Carlos Suazo", Email = "carlos@ejemplo.com" },
            new User { Id = 2, Name = "Carmela Espinoza", Email = "carmela@ejemplo.com" },
            new User { Id = 3, Name = "Ernesto Cano", Email = "ernesto@ejemplo.com" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            return Users;
        }

        // GET: api/users/1
        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            var user = Users.FirstOrDefault(x => x.Id == id);
            if(user == null)
            {
                return NotFound();
            }
            return user;
        }

        // POST: api/users
        [HttpPost]
        public ActionResult<User> CreateUser(User user)
        {
            user.Id = Users.Max(u => u.Id) + 1;
            Users.Add(user);
            return CreatedAtAction(nameof(GetUser),
                new { id = user.Id}, user);
        }

        // PUT: api/users/1
        [HttpPut("{id}")]
        public ActionResult UpdateUser(int id, User updateUser)
        {
            var user = Users.FirstOrDefault(x => x.Id == id);
            if(user == null)
            {
                return NotFound();
            }
            user.Name = updateUser.Name;
            user.Email = updateUser.Email;
            return NoContent();
        }

        // DELETE: api/users/1
        [HttpDelete("{id}")]
        public ActionResult DeleteUser(int id)
        {
            var user = Users.FirstOrDefault(u => u.Id == id);
            if(user == null)
            {
                return NotFound();
            }
            Users.Remove(user);
            return NoContent();
        }
    }
}
