using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity_Auctions.Entities.DTOs
{
    public class CreateUserDTO
    {
        public string Nume { get; set; }
        public string Adresa_email { get; set; }
        public string Parola { get; set; }
        public string Tip { get; set; }

        public Cos_cumparaturi cos_Cumparaturi { get; set; }
    }
}
