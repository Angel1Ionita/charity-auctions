using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity_Auctions.Entities.DTOs
{
    public class CreateComentariuDTO
    {
        public string Com { get; set; }
        public string username { get; set; }
        public int Id_produs { get; set; }
    }
}
