using Charity_Auctions.Data;
using Charity_Auctions.Entities;
using Charity_Auctions.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity_Auctions.Repositories.Cos_ProdusRepository
{
    public class CosProdusRepository : GenericRepository<Cosprodus>, ICosProdusRepository
    {
        public CosProdusRepository(Proiect_context context) : base(context) { }

        public async Task<List<Cosprodus>> GetAllCosProdusByProdusId(int id)
        {
            return await _context.Cosproduse.Where(a => a.ProdusId == id).ToListAsync();
        }

        public async Task<List<Cosprodus>> GetAllCosProdusByUserId(int id)
        {
            return await _context.Cosproduse.Where(a => a.UserId == id).ToListAsync();
        }
    }
}
