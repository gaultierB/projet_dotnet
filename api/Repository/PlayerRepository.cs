using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;
using TodoApi.controllers;
using EF;

namespace Repository
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly PlayerContext _context;

        public PlayerRepository(PlayerContext context)
        {
            _context = context;
        }

        public async Task<Player> Create(Player player)
        {
            _context.Players.Add(player);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch(Exception exception){
                throw exception;
            }
            
            return player;
        }

        public async Task Delete(int id)
        {
            var playerToDelete = await _context.FindAsync<Player>(id);
            _context.Players.Remove(playerToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Player>> Get()
        {
            return await _context.Players.ToListAsync();
        }

        public async Task<Player> Get(int id)
        {
            return await _context.Players.FindAsync(id);
        }

        public async Task Update(Player player)
        {
            _context.Entry(player).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public bool isPlayerExist(Player player)
        {
            return _context.Players.Any(e => e.Id == player.Id);
        }

        public bool isIdExist(int id)
        {
            return _context.Players.Any(e => e.Id == id);
        }
    }
}