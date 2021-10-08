using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoApi.Models;

namespace Repository
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> Get();

        Task<User> Get(int id);

        Task<User> Create(User user);

        Task Update(User user);

        Task Delete(int id);

        bool isPlayerExist(User user);

        bool isIdExist(int id);
    };
}