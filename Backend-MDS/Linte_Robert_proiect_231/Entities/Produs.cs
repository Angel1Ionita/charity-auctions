using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Linte_Robert_proiect_231.Entities
{
    public class Produs
    {
        public int Id { get; set; }
        public float Pret { get; set; }
        public string Denumire { get; set; }
        public string Url_poza { get; set; }

        //Navigations properties
        public ICollection<Produs_Comanda> Produs_Comandas { get; set; }
        public int Tabel_MarimiId { get; set; }
        public Tabel_Marimi Tabel_Marimi { get; set; }
        public List<Cos_Produs> Cos_produss { get; set; }
    }
}
