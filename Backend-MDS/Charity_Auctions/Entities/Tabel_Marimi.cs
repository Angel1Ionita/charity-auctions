using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity_Auctions.Entities
{
    public class Tabel_Marimi
    {
        public int Id { get; set; }
        public int S { get; set; }
        public int M { get; set; }
        public int L { get; set; }
        public int XL { get; set; }

        //Navigation 

        public Produs Produs { get; set; }
    }
}
