using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IComandaMercaderiaCommand
    {
        ComandaMercaderia InsertComandaMercaderia(ComandaMercaderia comandaMercaderia);
        ComandaMercaderia RemoveComandaMercaderia(int comandaMercaderiaId);
        ComandaMercaderia UpdateComandaMercaderia(int comandaMercaderiaId);
    }
}
