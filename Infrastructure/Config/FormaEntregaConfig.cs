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
    public class FormaEntregaConfig : IEntityTypeConfiguration<FormaEntrega>
    {
        public void Configure(EntityTypeBuilder<FormaEntrega> entityBuilder)
        {
            entityBuilder.ToTable("FormaEntrega");
            entityBuilder.HasKey(e => e.FormaEntregaId);

            entityBuilder.Property(e => e.Descripcion)
            .HasMaxLength(50);

            entityBuilder.HasMany(t => t.Comandas)
            .WithOne(m => m.FormaEntrega)
            .HasForeignKey(m => m.FormaEntregaId);

            entityBuilder.HasData
            (
                new FormaEntrega
                {
                    FormaEntregaId = 1,
                    Descripcion = "Salon",
                },

                new FormaEntrega
                {
                    FormaEntregaId = 2,
                    Descripcion = "Delivery",
                },

                new FormaEntrega
                {
                    FormaEntregaId = 3,
                    Descripcion = "Pedidos Ya",
                }
            );
        }
    }
}
