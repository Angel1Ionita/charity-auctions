using Microsoft.EntityFrameworkCore;
using Linte_Robert_proiect_231.Data;
using Linte_Robert_proiect_231.Entities;
using Linte_Robert_proiect_231.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Linte_Robert_proiect_231.Repositories.ProdusRepository
{
    public class ProdusRepository : GenericRepository<Produs>, IProdusRepository
    {

        public ProdusRepository(Proiect_context context) : base(context) { }
        public async Task<List<Produs>> GetAllProdusWithMarimi()
        {
            return await _context.Produse.Include(a => a.Tabel_Marimi).ToListAsync();
        }

        public async Task<Produs> GetByIdWithTabel(int id)
        {
            return await _context.Produse.Include(a => a.Tabel_Marimi).Where(a => a.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Produs> GetByName(string name)
        {
            return await _context.Produse.Where(a => a.Denumire.Equals(name)).FirstOrDefaultAsync();
        }
    }
}
