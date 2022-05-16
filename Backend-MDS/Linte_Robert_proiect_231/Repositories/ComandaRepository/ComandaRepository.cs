using Linte_Robert_proiect_231.Data;
using Linte_Robert_proiect_231.Entities;
using Linte_Robert_proiect_231.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Linte_Robert_proiect_231.Repositories.ComandaRepository
{
    public class ComandaRepository : GenericRepository<Comanda>, IComandaRepository
    {
        public ComandaRepository(Proiect_context context) : base(context) { }

        public async Task<List<Comanda>> GetAllComenziWithProduse()
        {
            return await _context.Comenzi.Include(a => a.Produs_Comandas).ToListAsync();
        }

        public async Task<Comanda> GetByIdWithProduse(int id)
        {
            return await _context.Comenzi.Include(a => a.Produs_Comandas).Where(a => a.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Comanda>> GetComenziByUserId(int id)
        {
            return await _context.Comenzi.Include(a => a.Produs_Comandas).Where(a => a.Userid == id).ToListAsync();
        }
    }
}
