using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace EF{
    public class PlayerContext : DbContext{
        
        public PlayerContext(DbContextOptions<PlayerContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Player> Players {get; set;}
        public DbSet<User> Users {get; set;}
    }
}