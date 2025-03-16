using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User.Domain.Entities;

namespace User.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<UserSeeder>> GetUsers();
        // Criar tasks de busca e crud.
    }
}