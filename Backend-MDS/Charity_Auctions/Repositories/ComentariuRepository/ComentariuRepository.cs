using Charity_Auctions.Data;
using Charity_Auctions.Entities;
using Charity_Auctions.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity_Auctions.Repositories.ComentariuRepository
{
    public class ComentariuRepository : GenericRepository<Comentariu>, IComentariuRepository
    {
        public ComentariuRepository(Proiect_context context) : base(context) { }
        public async Task<List<Comentariu>> GetAllComentariiByProdusId(int id)
        {
            return await _context.Comentarii.Where(a => a.Id_produs == id).ToListAsync();
        }
    }
}
