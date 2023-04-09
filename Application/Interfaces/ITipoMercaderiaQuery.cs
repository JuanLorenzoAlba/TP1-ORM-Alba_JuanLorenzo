using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ITipoMercaderiaQuery
    {
        List<TipoMercaderia> GetTipoMercaderiaList();
        TipoMercaderia GetTipoMercaderiaById(int tipoMercaderiaId);
    }
}
