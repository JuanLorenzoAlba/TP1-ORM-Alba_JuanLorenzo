using Application.Interfaces;

namespace Restaurant.CheckingInput
{
    public class Validador : IValidador
    {
        public int ValidarOpcion(int desde, int hasta)
        {
            int valor;
            string opcion;
            bool esNumero;
            do
            {
                Console.Write("| Ingrese un Valor Correcto: ");
                opcion = Console.ReadLine();

                esNumero = int.TryParse(opcion, out valor);
            }
            while (!esNumero || valor < desde || valor > hasta);

            return valor;
        }
    }
}
