using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Comanda
    {
        public Guid ComandaId { set; get; }
        public int PrecioTotal { set; get; }
        public DateTime Fecha { set; get; }

        public int FormaEntregaId { get; set; }
        public FormaEntrega FormaEntrega { set; get; }

        public ICollection<ComandaMercaderia> ComandasMercaderias { get; set; }
    }
}
