using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Config
{
    public class ComandaMercaderiaConfig : IEntityTypeConfiguration<ComandaMercaderia>
    {
        public void Configure(EntityTypeBuilder<ComandaMercaderia> entityBuilder)
        {
            entityBuilder.ToTable("ComandaMercaderia");
            entityBuilder.HasKey(e => new { e.MercaderiaId, e.ComandaId });

            entityBuilder.HasOne(d => d.Mercaderia)
            .WithMany(p => p.ComandasMercaderias)
            .HasForeignKey(d => d.MercaderiaId);

            entityBuilder.HasOne(d => d.Comanda)
            .WithMany(p => p.ComandasMercaderias)
            .HasForeignKey(d => d.ComandaId);
        }
    }
}
