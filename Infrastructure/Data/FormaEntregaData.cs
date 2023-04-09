using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class FormaEntregaData : IEntityTypeConfiguration<FormaEntrega>
    {
        public void Configure(EntityTypeBuilder<FormaEntrega> entityBuilder)
        {
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
