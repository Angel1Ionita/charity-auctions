using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity_Auctions.Entities.DTOs
{
    public class ComentariuDTO
    {
        public int Id { get; set; }
        public string Com { get; set; }
        public string username { get; set; }
        public int Id_produs { get; set; }

        public ComentariuDTO(Comentariu dto)
        {
            this.username = dto.username;
            this.Id = dto.Id;
            this.Id_produs = dto.Id_produs;
            this.Com = dto.Com;
        }
    }
}
