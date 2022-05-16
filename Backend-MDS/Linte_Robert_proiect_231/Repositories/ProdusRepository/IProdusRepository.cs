using Linte_Robert_proiect_231.Entities;
using Linte_Robert_proiect_231.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Linte_Robert_proiect_231.Repositories.ProdusRepository
{
    public interface IProdusRepository : IGenericRepository<Produs>
    {
        Task<Produs> GetByName(string name);
        Task<List<Produs>> GetAllProdusWithMarimi();

        Task<Produs> GetByIdWithTabel(int id);
    }
}
