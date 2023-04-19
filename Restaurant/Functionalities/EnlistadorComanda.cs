using Application.Interfaces;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Restaurant.Functionalities
{
    public class EnlistadorComanda : IEnlistadorComanda
    {
        private readonly RestaurantContext _restaurantContext;

        public EnlistadorComanda()
        {
            _restaurantContext = new RestaurantContext();
        }
        public void EnlistarComandas()
        {
            Console.Clear();
            Console.WriteLine("+--------------------------------------------------+");
            Console.WriteLine("|              Lista de Comandas                   |");
            Console.WriteLine("+--------------------------------------------------+");

            var comandaMercaderiaList = _restaurantContext.Comandas
                            .Include(cm => cm.ComandasMercaderias)
                            .ThenInclude(m => m.Mercaderia)
                            .Select(c => new
                            {
                                c.ComandaId,
                                c.PrecioTotal,
                                c.FormaEntrega,
                                Mercaderias = c.ComandasMercaderias.Select(m => new
                                {
                                    m.Mercaderia.MercaderiaId,
                                    m.Mercaderia.Nombre,
                                    m.Mercaderia.Ingredientes,
                                    m.Mercaderia.Preparacion,
                                    m.Mercaderia.Imagen,
                                    m.Mercaderia.TipoMercaderia
                                })
                            }).ToList();

            foreach (var comandaItem in comandaMercaderiaList)
            {
                Console.Clear();
                Console.WriteLine("+--------------------------------------------------+");
                Console.WriteLine("| CodigoComanda = " + comandaItem.ComandaId);
                Console.WriteLine("| PrecioTotal = " + "$" + comandaItem.PrecioTotal);
                Console.WriteLine("| Forma de Entrega = " + comandaItem.FormaEntrega.Descripcion);
                Console.WriteLine("+--------------------------------------------------+");
                Console.WriteLine("");

                foreach (var mercaderiaItem in comandaItem.Mercaderias)
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
                Console.Write("Presione ENTER para ver la siguiente comanda");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine("+--------------------------------------------------+");
            Console.WriteLine("|              Fin de la Consulta                  |");
            Console.WriteLine("+--------------------------------------------------+");
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}
