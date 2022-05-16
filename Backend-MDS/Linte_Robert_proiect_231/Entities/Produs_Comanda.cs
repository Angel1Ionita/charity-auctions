using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Linte_Robert_proiect_231.Entities
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
