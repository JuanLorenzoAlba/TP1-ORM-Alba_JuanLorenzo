using Application.Interfaces;
using Application.UseCase.Comandas;
using Application.UseCase.ComandasMercaderias;
using Application.UseCase.FormaEntregas;
using Application.UseCase.Mercaderias;
using Domain.Entities;
using Infrastructure.Command;
using Infrastructure.Persistence;
using Infrastructure.Querys;

namespace Restaurant
{
    public class Menu : IMenu
    {
        private RestaurantContext _restaurantContext;

        private IComandaCommand _comandaCommand;
        private IComandaQuery _comandaQuery;
        private IComandaService _comandaService;

        private IMercaderiaCommand _mercaderiaCommand;
        private IMercaderiaQuery _mercaderiaQuery;
        private IMercaderiaService _mercaderiaService;

        private IFormaEntregaCommand _formaEntregaCommand;
        private IFormaEntregaQuery _formaEntregaQuery;
        private IFormaEntregaService _formaEntregaService;

        private IComandaMercaderiaCommand _comandaMercaderiaCommand;
        private IComandaMercaderiaQuery _comandaMercaderiaQuery;
        private IComandaMercaderiaService _comandaMercaderiaService;

        public Menu()
        {
            _restaurantContext = new RestaurantContext();

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
        public void Imprimir()
        {
            Console.WriteLine("+--------------------------------------------------+");
            Console.WriteLine("|              Restaurante el Alba                 |");
            Console.WriteLine("+--------------------------------------------------+");
            Console.WriteLine("| Seleccione una de las opciones:                  |");
            Console.WriteLine("| 1. Hacer pedido                                  |");
            Console.WriteLine("| 2. Mostrar pedidos                               |");
            Console.WriteLine("| 3. Salir                                         |");
            Console.WriteLine("+--------------------------------------------------+");
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
            Console.Write("| Elige una opcion: ");
            int opcionFormaEntrega = int.Parse(Console.ReadLine());

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
            Console.WriteLine("| 0. Terminar");

            Console.WriteLine("+--------------------------------------------------+");
            Console.Write("| Elige una opcion: ");
            int opcionComida = int.Parse(Console.ReadLine());

            int precioTotal = 0;
            List<Mercaderia> listaMercaderiasPedidas = new List<Mercaderia>();

            while (opcionComida != 0)
            {
                precioTotal = precioTotal + _mercaderiaService.GetMercaderiaList()[opcionComida - 1].Precio;
                Console.WriteLine("| MontoTotal = " + precioTotal);
                listaMercaderiasPedidas.Add(_mercaderiaService.GetMercaderiaList()[opcionComida - 1]);

                Console.Write("| Elige otra opcion: ");
                opcionComida = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("+-------------[ Pedido Realizado ]-----------------+");
            Comanda comanda = _comandaService.CreateComanda(precioTotal, DateTime.Now, formaEntrega);

            foreach (var mercaderiaPedidaItem in listaMercaderiasPedidas)
            {
                _comandaMercaderiaService.CreateComandaMercaderia(mercaderiaPedidaItem, comanda);
            }

        }
        public void EnlistarComandas()
        {
            Console.Clear();
            Console.WriteLine("+--------------------------------------------------+");
            Console.WriteLine("|              Lista de Comandas                   |");
            Console.WriteLine("+--------------------------------------------------+");

            var listaComandas = (from cm in _restaurantContext.ComandasMercaderias
                                 join m in _restaurantContext.Mercaderias on cm.MercaderiaId equals m.MercaderiaId
                                 join c in _restaurantContext.Comandas on cm.ComandaId equals c.ComandaId
                                 select new Comanda
                                 {
                                     ComandaId = c.ComandaId,
                                     PrecioTotal = c.PrecioTotal,
                                     FormaEntrega = c.FormaEntrega,
                                 }
                                 ).ToList();

            var listaMercaderias = (from cm in _restaurantContext.ComandasMercaderias
                                    join m in _restaurantContext.Mercaderias on cm.MercaderiaId equals m.MercaderiaId
                                    join c in _restaurantContext.Comandas on cm.ComandaId equals c.ComandaId
                                    select new Mercaderia
                                    {
                                        MercaderiaId = m.MercaderiaId,
                                        Nombre = m.Nombre,
                                        Ingredientes = m.Ingredientes,
                                        Preparacion = m.Preparacion,
                                        Imagen = m.Imagen,
                                        TipoMercaderia = m.TipoMercaderia,
                                    }
                                    ).ToList();

            var listaComandasDistintas = listaComandas.DistinctBy(c => c.ComandaId).ToList();

            var listaMercaderiaDistintas = listaMercaderias.DistinctBy(m => m.MercaderiaId).ToList();

            foreach (var comandaItem in listaComandasDistintas)
            {
                Console.Clear();
                Console.WriteLine("+--------------------------------------------------+");
                Console.WriteLine("| CodigoComanda = " + comandaItem.ComandaId);
                Console.WriteLine("| PrecioTotal = " + "$" + comandaItem.PrecioTotal);
                Console.WriteLine("| Forma de Entrega = " + comandaItem.FormaEntrega.Descripcion);
                Console.WriteLine("+--------------------------------------------------+");
                Console.WriteLine("");

                foreach (var comandaMercaderiaItem in _comandaMercaderiaService.GetComandaMercaderiaList())
                {

                    if (comandaItem.ComandaId == comandaMercaderiaItem.ComandaId)
                    {
                        foreach (var mercaderiaItem in listaMercaderiaDistintas)
                        {
                            if (mercaderiaItem.MercaderiaId == comandaMercaderiaItem.MercaderiaId)
                            {
                                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
                                Console.WriteLine("| Nombre del Plato = " + mercaderiaItem.Nombre);
                                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
                                Console.WriteLine("| Ingredientes = " + mercaderiaItem.Ingredientes);
                                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
                                Console.WriteLine("| Preparacion = " + mercaderiaItem.Preparacion);
                                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
                                Console.WriteLine("| Imagen = " + mercaderiaItem.Imagen);
                                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
                                Console.WriteLine("| Tipo de Mercaderia = " + mercaderiaItem.TipoMercaderia.Descripcion);
                                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
                                Console.WriteLine("");

                            }
                        }
                    }

                }
                Console.Write("Presione ENTER para ver la siguiente comanda");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine("+-------------[ Consulta Realizada ]-----------------+");
        }
    }
}
