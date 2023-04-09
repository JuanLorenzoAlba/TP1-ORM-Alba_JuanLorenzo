using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Command
{
    public class TipoMercaderiaCommand : ITipoMercaderiaCommand
    {
        private readonly RestaurantContext _context;

        public TipoMercaderiaCommand(RestaurantContext context)
        {
            _context = context;
        }

        public TipoMercaderia InsertTipoMercaderia(TipoMercaderia tipoMercaderia)
        {
            _context.Add(tipoMercaderia);
            _context.SaveChanges();

            return tipoMercaderia;
        }
        public TipoMercaderia RemoveTipoMercaderia(int tipoMercaderiaId)
        {
            var removeTipoMercaderiaId = _context.TipoMercaderias.Single(x => x.TipoMercaderiaId == tipoMercaderiaId);
            _context.Remove(removeTipoMercaderiaId);
            _context.SaveChanges();

            return removeTipoMercaderiaId;
        }
        public TipoMercaderia UpdateTipoMercaderia(int tipoMercaderiaId)
        {
            var updateTipoMercaderiaId = _context.TipoMercaderias.Single(x => x.TipoMercaderiaId == tipoMercaderiaId);
            _context.Update(updateTipoMercaderiaId);
            _context.SaveChanges();

            return updateTipoMercaderiaId;
        }
    }
}
