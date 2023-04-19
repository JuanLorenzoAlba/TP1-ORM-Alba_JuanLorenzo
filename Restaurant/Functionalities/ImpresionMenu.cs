using Application.Interfaces;

namespace Restaurant.Functionalities
{
    public class ImpresionMenu : IImpresionMenu
    {
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

    }
}
