using Linte_Robert_proiect_231.Entities;
using Linte_Robert_proiect_231.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Linte_Robert_proiect_231.Repositories.Cos_ProdusRepository
{
    public interface ICosProdusRepository : IGenericRepository<Cosprodus>
    {
        Task<List<Cosprodus>> GetAllCosProdusByUserId(int id);
    }
}
