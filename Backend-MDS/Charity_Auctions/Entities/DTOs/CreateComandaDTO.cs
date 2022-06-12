using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity_Auctions.Entities.DTOs
{
    public class CreateComandaDTO
    {
        public int Id { get; set; }
        public string Adresa_livrare { get; set; }
        public DateTime Data_comanda { get; set; }
        public int Userid { get; set; }
        public List<Produs_Comanda> Produs_Comandas { get; set; }
    }
}
