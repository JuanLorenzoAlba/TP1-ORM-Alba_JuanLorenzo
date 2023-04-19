using Application.Interfaces;
using Application.UseCase.Comandas;
using Application.UseCase.ComandasMercaderias;
using Application.UseCase.FormaEntregas;
using Application.UseCase.Mercaderias;
using Domain.Entities;
using Infrastructure.Command;
using Infrastructure.Persistence;
using Infrastructure.Querys;
using Restaurant.CheckingInput;

namespace Restaurant.Functionalities
{
    public class RegistradorComanda : IRegistradorComanda
    {
        private readonly RestaurantContext _restaurantContext;

        private readonly IValidador _validador;

        private readonly IComandaCommand _comandaCommand;
        private readonly IComandaQuery _comandaQuery;
        private readonly IComandaService _comandaService;

        private readonly IMercaderiaCommand _mercaderiaCommand;
        private readonly IMercaderiaQuery _mercaderiaQuery;
        private readonly IMercaderiaService _mercaderiaService;

        private readonly IFormaEntregaCommand _formaEntregaCommand;
        private readonly IFormaEntregaQuery _formaEntregaQuery;
        private readonly IFormaEntregaService _formaEntregaService;

        private readonly IComandaMercaderiaCommand _comandaMercaderiaCommand;
        private readonly IComandaMercaderiaQuery _comandaMercaderiaQuery;
        private readonly IComandaMercaderiaService _comandaMercaderiaService;

        public RegistradorComanda()
        {
            _restaurantContext = new RestaurantContext();

            _validador = new Validador();

            _comandaCommand = new ComandaCommand(_restaurantContext);
            _comandaQuery = new ComandaQuery(_restaurantContext);
            _comandaService = new ComandaService(_comandaCommand, _comandaQuery);

            _mercaderiaCommand = new MercaderiaCommand(_restaurantContext);
            _mercaderiaQuery = new MercaderiaQuery(_restaurantContext);
            _mercaderiaService = new MercaderiaService(_mercaderiaCommand, _mercaderiaQuery);

            _formaEntregaCommand = new FormaEntregaCommand(_restaurantContext);
            _formaEntregaQuery = new FormaEntregaQuery(_restaurantContext);
            _formaEntregaService = new FormaEntregaService(_formaEntregaCommand, _formaEntregaQuery);

            _comandaMercaderiaCommand = new ComandaMercaderiaCommand(_restaurantContext);
            _comandaMercaderiaQuery = new ComandaMercaderiaQuery(_restaurantContext);
            _comandaMercaderiaService = new ComandaMercaderiaService(_comandaMercaderiaCommand, _comandaMercaderiaQuery);
        }
        public void RegistrarLasComanda()
        {
            Console.Clear();
            int indice = 1;
            Console.WriteLine("+--------------------------------------------------+");
            Console.WriteLine("|              Formas de Entrega                   |");
            Console.WriteLine("+--------------------------------------------------+");
            foreach (var formaEntregaItem in _formaEntregaService.GetFormaEntregaList())
            {
                Console.WriteLine("| " + indice + ". " + formaEntregaItem.Descripcion);
                indice++;
            }
            Console.WriteLine("+--------------------------------------------------+");

            int opcionFormaEntrega = _validador.ValidarOpcion(1, _formaEntregaService.GetFormaEntregaList().Count);
            FormaEntrega formaEntrega = _formaEntregaService.GetFormaEntregaList()[opcionFormaEntrega - 1];

            Console.Clear();
            indice = 1;
            Console.WriteLine("+--------------------------------------------------+");
            Console.WriteLine("|              Menu de Comidas                     |");
            Console.WriteLine("+--------------------------------------------------+");
            foreach (var mercaderiaItem in _mercaderiaService.GetMercaderiaList())
            {
                Console.WriteLine("| " + indice + ". " + mercaderiaItem.Nombre + " / " + "$" + mercaderiaItem.Precio);
                indice++;
            }
            Console.WriteLine("+--------------------------------------------------+");
            Console.WriteLine("| PRESIONE 0 cuando desee finalizar con la compra  |");
            Console.WriteLine("+--------------------------------------------------+");

            int opcionComida = _validador.ValidarOpcion(0, _mercaderiaService.GetMercaderiaList().Count);
            int precioTotal = 0;
            List<Mercaderia> listaMercaderiasPedidas = new List<Mercaderia>();

            while (opcionComida != 0)
            {
                precioTotal = precioTotal + _mercaderiaService.GetMercaderiaList()[opcionComida - 1].Precio;
                Console.WriteLine("| MontoTotal = " + precioTotal);
                listaMercaderiasPedidas.Add(_mercaderiaService.GetMercaderiaList()[opcionComida - 1]);

                opcionComida = _validador.ValidarOpcion(0, _mercaderiaService.GetMercaderiaList().Count);
            }

            Comanda comanda = _comandaService.CreateComanda(precioTotal, DateTime.Now, formaEntrega);

            foreach (var mercaderiaPedidaItem in listaMercaderiasPedidas)
            {
                _comandaMercaderiaService.CreateComandaMercaderia(mercaderiaPedidaItem, comanda);
            }

            Console.Clear();
            Console.WriteLine("+--------------------------------------------------+");
            Console.WriteLine("|          Pedido Realizado Correctamente          |");
            Console.WriteLine("+--------------------------------------------------+");
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}
