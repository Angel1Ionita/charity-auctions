using Charity_Auctions.Data;
using Charity_Auctions.Entities;
using Charity_Auctions.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity_Auctions.Repositories.UserRepository
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
