using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Linte_Robert_proiect_231.Entities.DTOs
{
    public class CreateProdusDTO
    {
        public string Denumire { get; set; }
        public float Pret { get; set; }
        public string Url_poza { get; set; }
        public Tabel_Marimi Tabel_Marimi { get; set; }
    }
}
