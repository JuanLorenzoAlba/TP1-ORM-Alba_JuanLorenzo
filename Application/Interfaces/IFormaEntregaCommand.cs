using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IFormaEntregaCommand
    {
        FormaEntrega InsertFormaEntrega(FormaEntrega formaEntrega);
        FormaEntrega RemoveFormaEntrega(int formaEntregaId);
        FormaEntrega UpdateFormaEntrega(int formaEntregaId);
    }
}
