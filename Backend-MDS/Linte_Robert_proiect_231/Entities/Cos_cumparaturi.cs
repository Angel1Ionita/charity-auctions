using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Linte_Robert_proiect_231.Entities
{
    public class Cos_cumparaturi
    {
        public int Id { get; set; }
        //navigare
        public int UserId { get; set; }
        public User User { get; set; }
        public List<Cos_Produs> Cos_produss { get; set; }



    }
}
