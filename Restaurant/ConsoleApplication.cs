using Restaurant.Functionalities;
using Restaurant.CheckingInput;

namespace ConsoleApplication
{
    public class ConsoleApplication
    {
        static void Main(string[] args)
        {
            bool seguir = true;

            while (seguir)
            {
                new ImpresionMenu().Imprimir();

                int opcion = new Validador().ValidarOpcion(1, 3);

                switch (opcion)
                {
                    case (1):
                        new RegistradorComanda().RegistrarLasComanda();
                        break;

                    case (2):
                        new EnlistadorComanda().EnlistarComandas();
                        break;

                    case (3):
                        Console.Clear();
                        seguir = false;
                        break;
                }
            }
        }
    }
}