using CapaNegocio;
using CapaEntidades;

namespace Interfaz
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool parar = true;
            while (parar)
            {
                Console.WriteLine("" +
                    "Menuuuu" +
                "\n1.Convertir " +
                "\n2 Salir");
                int opc = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("" +
                            "1. Convertir a TXT" +
                        "\n2. Convertir a JSON" +
                        "\n3. Convertir a CSV");

                        int opcion = Convert.ToInt32(Console.ReadLine());
                        IConvertidorFormatos convertir = FactoryFormatos.ConvertirFormatos(opcion);
                        convertir.Convertidor(UsuarioManejo.PedirDatos());
                        Console.Clear();
                        break;

                    case 2:
                        parar = false;
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion valida por favor");
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
