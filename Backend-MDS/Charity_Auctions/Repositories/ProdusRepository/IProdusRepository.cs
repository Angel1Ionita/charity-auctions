using Charity_Auctions.Entities;
using Charity_Auctions.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Charity_Auctions.Repositories.ProdusRepository
{
    public interface IProdusRepository : IGenericRepository<Produs>
    {
        Task<Produs> GetByName(string name);
        Task<List<Produs>> GetAllProdusWithMarimi();

        Task<Produs> GetByIdWithTabel(int id);
    }
}
