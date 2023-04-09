using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IMercaderiaService
    {
        Mercaderia CreateMercaderia(string nombre, int precio, string ingredientes, string preparacion, string imagen, TipoMercaderia tipoMercaderia);
        Mercaderia RemoveMercaderia(int mercaderiaId);
        Mercaderia UpdateMercaderia(int mercaderiaId);
        List<Mercaderia> GetMercaderiaList();
        Mercaderia GetMercaderiaById(int mercaderiaId);
    }
}
