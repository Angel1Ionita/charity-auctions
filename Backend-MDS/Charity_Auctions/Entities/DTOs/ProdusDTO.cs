using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity_Auctions.Entities.DTOs
{
    public class ProdusDTO
    {
        public int Id { get; set; }
        public float Pret { get; set; }
        public string Denumire { get; set; }
        public string Url_poza { get; set; }
        public string Poster_name { get; set; }
        public string Charity_name { get; set; }
        //Navigations properties
        public List<Produs_Comanda> Produs_Comandas { get; set; }

        public int Tabel_MarimiId { get; set; }
        public Tabel_Marimi Tabel_Marimi { get; set; }

        public List<Cos_Produs> Cos_produss { get; set; }

        public ProdusDTO(Produs produs)
        {
            this.Denumire = produs.Denumire;
            this.Id = produs.Id;
            this.Pret = produs.Pret;
            this.Url_poza = produs.Url_poza;
            this.Poster_name = produs.Poster_name;
            this.Charity_name = produs.Charity_name;

            this.Produs_Comandas = (List<Produs_Comanda>)produs.Produs_Comandas;
            this.Tabel_MarimiId = produs.Tabel_MarimiId;
            this.Tabel_Marimi = produs.Tabel_Marimi;
            this.Cos_produss = produs.Cos_produss;
        }
    }
}
