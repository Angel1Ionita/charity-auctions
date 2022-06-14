using Microsoft.EntityFrameworkCore;
using Charity_Auctions.Data;
using Charity_Auctions.Entities;
using Charity_Auctions.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity_Auctions.Repositories.ProdusRepository
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
