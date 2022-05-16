using Linte_Robert_proiect_231.Data;
using Linte_Robert_proiect_231.Entities;
using Linte_Robert_proiect_231.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Linte_Robert_proiect_231.Repositories.Cos_ProdusRepository
{
    public class CosProdusRepository : GenericRepository<Cosprodus>, ICosProdusRepository
    {
        public CosProdusRepository(Proiect_context context) : base(context) { }

        public async Task<List<Cosprodus>> GetAllCosProdusByUserId(int id)
        {
            return await _context.Cosproduse.Where(a => a.UserId == id).ToListAsync();
        }
    }
}
