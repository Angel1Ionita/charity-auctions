using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity_Auctions.Entities
{
    public class Comanda
    {
        public int Id { get; set; }
        public string Adresa_livrare { get; set; }
        public DateTime Data_comanda { get; set; }

        //Navigation properties

        public int Userid { get; set; }
        public User User { get; set; }

        public List<Produs_Comanda> Produs_Comandas { get; set; }
    }
}
