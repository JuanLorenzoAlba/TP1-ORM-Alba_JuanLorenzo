using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IComandaMercaderiaService
    {
        ComandaMercaderia CreateComandaMercaderia(Mercaderia mercaderia, Comanda comanda);
        ComandaMercaderia RemoveComandaMercaderia(int comandaMercaderiaId);
        ComandaMercaderia UpdateComandaMercaderia(int comandaMercaderiaId);
        List<ComandaMercaderia> GetComandaMercaderiaList();
        ComandaMercaderia GetComandaMercaderiaById(int comandaMercaderiaId);
    }
}
