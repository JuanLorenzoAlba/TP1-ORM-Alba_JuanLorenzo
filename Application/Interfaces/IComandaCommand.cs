using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IComandaCommand
    {
        Comanda InsertComanda(Comanda comanda);
        Comanda RemoveComanda(Guid comandaId);
        Comanda UpdateComanda(Guid comandaId);
    }
}
