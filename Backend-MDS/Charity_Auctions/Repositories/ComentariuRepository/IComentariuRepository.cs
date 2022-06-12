using Charity_Auctions.Entities;
using Charity_Auctions.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity_Auctions.Repositories.ComentariuRepository
{
    public interface IComentariuRepository : IGenericRepository<Comentariu>
    {
        Task<List<Comentariu>> GetAllComentariiByProdusId(int id);
    }
}
