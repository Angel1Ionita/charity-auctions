using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity_Auctions.Entities.DTOs
{
    public class ComandaDTO
    {
        public int Id { get; set; }
        public string Adresa_livrare { get; set; }
        public DateTime Data_comanda { get; set; }

        //Navigation properties

        public int Userid { get; set; }
        public User User { get; set; }

        public List<Produs_Comanda> Produs_Comandas { get; set; }

        public ComandaDTO(Comanda comanda)
        {
            this.Id = comanda.Id;
            this.Adresa_livrare = comanda.Adresa_livrare;
            this.Data_comanda = comanda.Data_comanda;
            this.Userid = comanda.Userid;
            this.User = comanda.User;
            this.Produs_Comandas = comanda.Produs_Comandas;
        }
    }
}
