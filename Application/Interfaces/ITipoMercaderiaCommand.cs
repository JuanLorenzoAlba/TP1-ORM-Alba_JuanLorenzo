using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ITipoMercaderiaCommand
    {
        TipoMercaderia InsertTipoMercaderia(TipoMercaderia tipoMercaderia);
        TipoMercaderia RemoveTipoMercaderia(int tipoMercaderiaId);
        TipoMercaderia UpdateTipoMercaderia(int tipoMercaderiaId);
    }
}
