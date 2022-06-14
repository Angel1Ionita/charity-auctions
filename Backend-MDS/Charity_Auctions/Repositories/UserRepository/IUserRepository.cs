using Charity_Auctions.Entities;
using Charity_Auctions.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity_Auctions.Repositories.UserRepository
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> GetByIdWithComanda(string Id);

        Task<User> GetByIdWithCos(int Id);
    }
}
