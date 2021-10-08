using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TodoApi.Models;
using EF;
using Repository;

namespace TodoApi.controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerController : ControllerBase
    {
        private readonly ILogger<PlayerController> _logger;
        private readonly PlayerContext _context;
        private readonly IPlayerRepository _playerRepository;

        public PlayerController(ILogger<PlayerController> logger, IPlayerRepository IPlayerRepository)
        {
            _logger = logger;
            _playerRepository = IPlayerRepository;
        }

        private static List<Player> teams = new List<Player>{
            new Player(1, "name1", "firstname1", 15),
        };

        [HttpGet("{id}")]
        public async Task<ActionResult<Player>> GetPlayerById(int id)
        {
            return await _playerRepository.Get(id);
        }

        [HttpGet]
        [Route("Get")]
        public async Task<IEnumerable<Player>> Get()
        {
            return await _playerRepository.Get();
        }

        [HttpPost]
        public IActionResult PostPlayer(Player player_data)
        {
            _playerRepository.Create(player_data);
            return CreatedAtAction(nameof(GetPlayerById), new { id = player_data.Id }, player_data);
        }

        [HttpDelete]
        [Route("{name}")]
        public IActionResult Delete(int id)
        {
            try{
                
                Player character = teams.Find(x => x.Id == id);
                teams.Remove(character);
            }
            catch
            {
                return NoContent();
            }
            return Ok();
        }
    }
}