using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TodoApi.Models;
using Newtonsoft.Json;
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
        public IEnumerable<Player> Get()
        {
            return teams.ToArray();
        }

        [HttpGet]
        [Route("GetBdd")]
        public async Task<IEnumerable<Player>> Getbdd()
        {
            return await _playerRepository.Get();
        }

        [HttpPost]
        public async Task<IActionResult> PostPlayer(Player player_data)
        {
            var new_player = await _playerRepository.Create(player_data);
            return CreatedAtAction(nameof(GetPlayerById), new { id = new_player.Id }, new_player);
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePlayer(Player player_data)
        {
            await _playerRepository.Update(player_data);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if(!_playerRepository.isIdExist(id))
            {
                return NotFound();
            }
            await _playerRepository.Delete(id);
            return Ok();
        }
    }
}