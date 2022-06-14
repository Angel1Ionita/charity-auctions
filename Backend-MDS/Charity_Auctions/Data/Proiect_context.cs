using Microsoft.EntityFrameworkCore;
using Charity_Auctions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity_Auctions.Data
{
    public class Proiect_context : DbContext
    {
        public Proiect_context(DbContextOptions<Proiect_context> options) : base(options) { }

        public DbSet<Comanda> Comenzi { get; set; }
        public DbSet<Produs> Produse { get; set; }
        public DbSet<Cosprodus> Cosproduse { get; set; }
        public DbSet<Tabel_Marimi> Tabel_Marimi { get; set; }

        public DbSet<User> Utilizatori { get; set; }

        public DbSet<Comentariu> Comentarii { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //One to One
            modelBuilder.Entity<Produs>()
                .HasOne(a => a.Tabel_Marimi)
                .WithOne(adr => adr.Produs);

            //One to Many
            modelBuilder.Entity<User>()
                .HasMany(a => a.Comenzi)
                .WithOne(b => b.User);

            //One to One
            modelBuilder.Entity<User>()
                .HasOne(a => a.cos_Cumparaturi)
                .WithOne(a => a.User);

            //Many to Many
            modelBuilder.Entity<Produs_Comanda>().HasKey(arp => new { arp.ComandaId, arp.ProdusId });

            modelBuilder.Entity<Produs_Comanda>()
                .HasOne(arp => arp.Produs)
                .WithMany(a => a.Produs_Comandas)
                .HasForeignKey(arp => arp.ProdusId);

            modelBuilder.Entity<Produs_Comanda>()
                .HasOne(arp => arp.Comanda)
                .WithMany(a => a.Produs_Comandas)
                .HasForeignKey(arp => arp.ComandaId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
