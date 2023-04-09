using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Config
{
    public class MercaderiaConfig : IEntityTypeConfiguration<Mercaderia>
    {
        public void Configure(EntityTypeBuilder<Mercaderia> entityBuilder)
        {
            entityBuilder.ToTable("Mercaderia");
            entityBuilder.HasKey(e => e.MercaderiaId);

            entityBuilder.Property(e => e.Nombre)
            .HasMaxLength(50);

            entityBuilder.Property(e => e.Ingredientes)
            .HasMaxLength(255);

            entityBuilder.Property(e => e.Preparacion)
            .HasMaxLength(255);

            entityBuilder.Property(e => e.Imagen)
            .HasMaxLength(255);

            entityBuilder.HasMany(m => m.ComandasMercaderias)
            .WithOne(cm => cm.Mercaderia)
            .HasForeignKey(cm => cm.MercaderiaId);
        }
    }
}
