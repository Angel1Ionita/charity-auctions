using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity_Auctions.Entities
{
    public class Produs_Comanda
    {
        public int Id { get; set; }

        public int ProdusId { get; set; }
        public Produs Produs { get; set; }
        public int Cantitate { get; set; }
        public int ComandaId { get; set; }
        public Comanda Comanda { get; set; }
    }
}
