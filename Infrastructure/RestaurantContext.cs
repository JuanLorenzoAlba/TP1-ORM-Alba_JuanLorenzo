using Microsoft.EntityFrameworkCore;
using Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class RestaurantContext : DbContext
    {
        public DbSet<TipoMercaderia> TipoMercaderias { get; set; }
        public DbSet<Mercaderia> Mercaderias { get; set; }
        public DbSet<ComandaMercaderia> ComandasMercaderias { get; set; }
        public DbSet<Comanda> Comandas { get; set; }
        public DbSet<FormaEntrega> FormaEntregas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=RestaurantDB;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoMercaderia>(entity =>
            {
                entity.ToTable("TipoMercaderia");
                entity.HasKey(e => e.TipoMercaderiaId);

                entity.Property(e => e.Descripcion)
                .HasMaxLength(50);

                entity.HasMany(t => t.Mercaderias)
                .WithOne(m => m.TipoMercaderia)
                .HasForeignKey(m => m.TipoMercaderiaId);
            });

            modelBuilder.Entity<Mercaderia>(entity =>
            {
                entity.ToTable("Mercaderia");
                entity.HasKey(e => e.MercaderiaId);

                entity.Property(e => e.Nombre)
                .HasMaxLength(50);

                entity.Property(e => e.Ingredientes)
                .HasMaxLength(255);

                entity.Property(e => e.Preparacion)
                .HasMaxLength(255);

                entity.Property(e => e.Imagen)
                .HasMaxLength(255);

                entity.HasMany(m => m.ComandasMercaderias)
                .WithOne(cm => cm.Mercaderia)
                .HasForeignKey(cm => cm.MercaderiaId);
            });

            modelBuilder.Entity<ComandaMercaderia>(entity =>
            {
                entity.ToTable("ComandaMercaderia");
                entity.HasKey(e => new { e.MercaderiaId, e.ComandaId });

                entity.HasOne(d => d.Mercaderia)
                .WithMany(p => p.ComandasMercaderias)
                .HasForeignKey(d => d.MercaderiaId);

                entity.HasOne(d => d.Comanda)
                .WithMany(p => p.ComandasMercaderias)
                .HasForeignKey(d => d.ComandaId);
            });

            modelBuilder.Entity<Comanda>(entity =>
            {
                entity.ToTable("Comanda");
                entity.HasKey(e => e.ComandaId);

                entity.HasMany(m => m.ComandasMercaderias)
                .WithOne(cm => cm.Comanda)
                .HasForeignKey(cm => cm.ComandaId);
            });

            modelBuilder.Entity<FormaEntrega>(entity =>
            {
                entity.ToTable("FormaEntrega");
                entity.HasKey(e => e.FormaEntregaId);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50);

                entity.HasMany(t => t.Comandas)
                .WithOne(m => m.FormaEntrega)
                .HasForeignKey(m => m.FormaEntregaId);
            });
        }
    }
}
