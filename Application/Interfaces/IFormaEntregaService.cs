using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IFormaEntregaService
    {
        FormaEntrega CreateFormaEntrega(string descripcion);
        FormaEntrega RemoveFormaEntrega(int formaEntregaId);
        FormaEntrega UpdateFormaEntrega(int formaEntregaId);
        List<FormaEntrega> GetFormaEntregaList();
        FormaEntrega GetFormaEntregaById(int formaEntregaId);
    }
}
