using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity_Auctions.Entities
{
    public class Cos_Produs
    {
        public int Id { get; set; }

        public int ProdusId { get; set; }
        public Produs Produs { get; set; }
        public int Cantitate { get; set; }
        public int Cos_cumparaturi_Id { get; set; }
        public Cos_cumparaturi Cos_Cumparaturi { get; set; }
    }
}
