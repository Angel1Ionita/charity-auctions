using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity_Auctions.Entities.DTOs
{
    public class CreateCosProdusDTO
    {
        public int UserId { get; set; }
        public int ProdusId { get; set; }
        public int Cantitate { get; set; }
    }
}
