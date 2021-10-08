using System.Collections.Generic;
using System;
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
        public async Task<ActionResult<User>> PostUser([FromBody] User user_data)
        {
            Console.WriteLine(user_data.Login);
            var new_user = await _userRepository.Create(user_data);
            return CreatedAtAction(nameof(GetUserById), new { id = new_user.Id }, new_user);
        }
    }
}