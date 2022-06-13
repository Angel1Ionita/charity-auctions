using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity_Auctions.Entities
{
    public class Produs
    {
        public int Id { get; set; }
        public float Pret { get; set; }
        public string Denumire { get; set; }
        public string Url_poza { get; set; }
        public string Poster_name { get; set; }
        public string Charity_name { get; set; }

        //Navigations properties
        public ICollection<Produs_Comanda> Produs_Comandas { get; set; }
        public int Tabel_MarimiId { get; set; }
        public Tabel_Marimi Tabel_Marimi { get; set; }
        public List<Cos_Produs> Cos_produss { get; set; }
    }
}
