using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase.FormaEntregas
{
    public class FormaEntregaService : IFormaEntregaService
    {
        private readonly IFormaEntregaCommand _command;
        private readonly IFormaEntregaQuery _query;

        public FormaEntregaService(IFormaEntregaCommand command, IFormaEntregaQuery query)
        {
            _command = command;
            _query = query;
        }

        public FormaEntrega GetFormaEntregaById(int formaEntregaId)
        {
            return _query.GetFormaEntregaById(formaEntregaId);
        }

        public List<FormaEntrega> GetFormaEntregaList()
        {
            return _query.GetFormaEntregaList();
        }

        public FormaEntrega CreateFormaEntrega(string descripcion)
        {
            var formaEntrega = new FormaEntrega
            {
                Descripcion = descripcion,
            };

            return _command.InsertFormaEntrega(formaEntrega);
        }

        public FormaEntrega RemoveFormaEntrega(int formaEntregaId)
        {
            return _command.RemoveFormaEntrega(formaEntregaId);
        }

        public FormaEntrega UpdateFormaEntrega(int formaEntregaId)
        {
            return _command.UpdateFormaEntrega(formaEntregaId);
        }
    }
}
