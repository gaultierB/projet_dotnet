using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TodoApi.Models;
using EF;
using Repository;

namespace TodoApi.controllers
{
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly PlayerContext _context;
        private readonly IUserRepository _userRepository;

        public UserController(ILogger<UserController> logger, IUserRepository IUserRepository)
        {
            _logger = logger;
            _userRepository = IUserRepository;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUserById(int id)
        {
            return await _userRepository.Get(id);
        }

        [HttpGet]
        [Route("Get")]
        public async Task<IEnumerable<User>> Get()
        {
            return await _userRepository.Get();
        }

        [HttpPost]
        public IActionResult PostUser(User user_data)
        {
            _userRepository.Create(user_data);
            return CreatedAtAction(nameof(GetUserById), new { id = user_data.Id }, user_data);
        }

        // [HttpDelete]
        // [Route("{name}")]
        // public IActionResult Delete(int id)
        // {
        //     try{
        //         User user = Users.Find(x => x.Id == id);
        //         Users.Remove(user);
        //     }
        //     catch
        //     {
        //         return NoContent();
        //     }
        //     return Ok();
        // }
    }
}