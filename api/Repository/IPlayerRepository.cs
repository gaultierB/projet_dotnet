using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoApi.Models;

namespace Repository
{
    public interface IPlayerRepository
    {
        Task<IEnumerable<Player>> Get();

        Task<Player> Get(int id);

        Task<Player> Create(Player player);

        Task Update(Player player);

        Task Delete(int id);

        bool isPlayerExist(Player player);

        bool isIdExist(int id);
    };
}