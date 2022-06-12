using Charity_Auctions.Entities;
using Charity_Auctions.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity_Auctions.Repositories.ComandaRepository
{
    public interface IComandaRepository : IGenericRepository<Comanda>
    {
        Task<Comanda> GetByIdWithProduse(int id);
        Task<List<Comanda>> GetComenziByUserId(int id);
        Task<List<Comanda>> GetAllComenziWithProduse();
    }
}
