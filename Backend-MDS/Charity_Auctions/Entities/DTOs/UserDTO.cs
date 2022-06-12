using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity_Auctions.Entities.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Adresa_email { get; set; }
        public string Parola { get; set; }
        public string Tip { get; set; }

        //Navigation properties
        public ICollection<Comanda> Comenzi { get; set; }
        public int Cos_cumparaturi_id { get; set; }

        public Cos_cumparaturi cos_Cumparaturi { get; set; }
        public UserDTO(User dto)
        {
            this.Id = dto.Id;
            this.Nume = dto.Nume;
            this.Adresa_email = dto.Adresa_email;
            this.Parola = dto.Parola;
            this.Tip = dto.Tip;
            this.Comenzi = dto.Comenzi;
            this.Cos_cumparaturi_id = dto.Id;
            this.cos_Cumparaturi = new Cos_cumparaturi();
            this.cos_Cumparaturi.Id = dto.Id;
        }
    }
}
