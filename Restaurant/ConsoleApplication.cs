using Restaurant;

namespace ConsoleApplication
{
    public class ConsoleApplication
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            menu.Imprimir();

            Console.Write("| Opcion: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case (1):
                    menu.RegistrarLasComanda();
                    break;

                case (2):
                    menu.EnlistarComandas();
                    break;
            }
        }
    }
}