using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IMercaderiaCommand
    {
        Mercaderia InsertMercaderia (Mercaderia mercaderia);
        Mercaderia RemoveMercaderia(int mercaderiaId);
        Mercaderia UpdateMercaderia(int mercaderiaId);
    }
}
