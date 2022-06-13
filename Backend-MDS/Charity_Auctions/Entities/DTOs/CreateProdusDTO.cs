using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity_Auctions.Entities.DTOs
{
    public class CreateProdusDTO
    {
        public string Denumire { get; set; }
        public float Pret { get; set; }
        public string Url_poza { get; set; }
        public string Poster_name { get; set; }
        public string Charity_name { get; set; }
        public Tabel_Marimi Tabel_Marimi { get; set; }
    }
}
