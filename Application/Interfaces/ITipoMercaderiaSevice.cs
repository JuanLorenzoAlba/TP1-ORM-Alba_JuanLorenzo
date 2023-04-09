using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ITipoMercaderiaSevice
    {
        TipoMercaderia CreateTipoMercaderia(string descripcion);
        TipoMercaderia RemoveTipoMercaderia(int tipoMercaderiaId);
        TipoMercaderia UpdateTipoMercaderia(int tipoMercaderiaId);
        List<TipoMercaderia> GetTipoMercaderiaList();
        TipoMercaderia GetTipoMercaderiaById(int tipoMercaderiaId);
    }
}
