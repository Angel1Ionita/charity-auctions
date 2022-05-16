using Linte_Robert_proiect_231.Data;
using Linte_Robert_proiect_231.Entities;
using Linte_Robert_proiect_231.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Linte_Robert_proiect_231.Repositories.UserRepository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(Proiect_context context) : base(context) { }

        public async Task<User> GetByIdWithComanda(string Id)
        {
            return await _context.Utilizatori.Include(a => a.Comenzi).Where(a => a.Nume == Id).FirstOrDefaultAsync();
        }

        public async Task<User> GetByIdWithCos(int Id)
        {
            return await _context.Utilizatori.Include(a => a.cos_Cumparaturi).Where(a => a.Id == Id).FirstOrDefaultAsync();
        }
    }
}
