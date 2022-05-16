using Linte_Robert_proiect_231.Entities;
using Linte_Robert_proiect_231.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Linte_Robert_proiect_231.Repositories.UserRepository
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> GetByIdWithComanda(string Id);

        Task<User> GetByIdWithCos(int Id);
    }
}
