using Charity_Auctions.Entities;
using Charity_Auctions.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity_Auctions.Repositories.Cos_ProdusRepository
{
    public interface ICosProdusRepository : IGenericRepository<Cosprodus>
    {
        Task<List<Cosprodus>> GetAllCosProdusByProdusId(int id);
        Task<List<Cosprodus>> GetAllCosProdusByUserId(int id);
    }

}
