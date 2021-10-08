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
    public class UserRepository : IUserRepository
    {
        private readonly PlayerContext _context;

        public UserRepository(PlayerContext context)
        {
            _context = context;
        }

        public async Task<User> Create(User user)
        {
            _context.Users.Add(user);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch(Exception exception){
                throw exception;
            }
            return user;
        }

        public async Task Delete(int id)
        {
            var userToDelete = await _context.FindAsync<User>(id);
            _context.Users.Remove(userToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<User>> Get()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> Get(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task Update(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public bool isuserExist(User user)
        {
            return _context.Users.Any(e => e.Id == user.Id);
        }

        public bool isIdExist(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }

        public bool isPlayerExist(User user)
        {
            throw new NotImplementedException();
        }
    }
}