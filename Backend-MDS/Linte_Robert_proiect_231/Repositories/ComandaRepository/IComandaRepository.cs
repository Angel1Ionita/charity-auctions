using Linte_Robert_proiect_231.Entities;
using Linte_Robert_proiect_231.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Linte_Robert_proiect_231.Repositories.ComandaRepository
{
    public interface IComandaRepository : IGenericRepository<Comanda>
    {
        Task<Comanda> GetByIdWithProduse(int id);
        Task<List<Comanda>> GetComenziByUserId(int id);
        Task<List<Comanda>> GetAllComenziWithProduse();
    }
}
