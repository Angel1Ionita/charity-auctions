using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity_Auctions.Entities
{
    public class User
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
    }
}
