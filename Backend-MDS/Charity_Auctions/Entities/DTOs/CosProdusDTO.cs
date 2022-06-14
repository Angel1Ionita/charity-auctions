using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity_Auctions.Entities.DTOs
{
    public class CosProdusDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProdusId { get; set; }
        public int Cantitate { get; set; }

        public CosProdusDTO(Cosprodus dto)
        {
            this.Id = dto.Id;
            this.ProdusId = dto.ProdusId;
            this.UserId = dto.UserId;
            this.Cantitate = dto.Cantitate;
        }
    }
}
