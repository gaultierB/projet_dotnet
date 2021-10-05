using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TodoApi.Models.Player;
using Newtonsoft.Json;

namespace TodoApi.controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerController : ControllerBase
    {
        private readonly ILogger<PlayerController> _logger;

        public PlayerController(ILogger<PlayerController> logger)
        {
            _logger = logger;
        }

        private static List<Player> teams = new List<Player>{
            new Player(1, "name1", "firstname1", 15),
        };

        [HttpGet]
        public IEnumerable<Player> Get()
        {
            return teams.ToArray();
        }

        [HttpPost]
        public IActionResult Post(List<Player> teams)
        {
            foreach (Player player in teams)
            {
                try{
                    teams.Add(player);
                }
                catch
                {
                    return NoContent();
                }
            }
            return Ok();
        }

        [HttpDelete]
        [Route("{name}")]
        public IActionResult Delete(string name)
        {
            try{
                
                Player character = teams.Find(x => x.Name == name);
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