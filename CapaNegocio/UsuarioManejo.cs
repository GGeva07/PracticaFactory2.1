using CapaEntidades;

namespace CapaNegocio
{
    public class UsuarioManejo
    {
        static Usuario? usuario;
        public static Usuario PedirDatos()
        {
            Console.WriteLine("Ingrese los sigtes. datos en este orden (nombre, matricula y carrera)");
            string nombre = Console.ReadLine();
            int matricula = Convert.ToInt32(Console.ReadLine());
            string carrera = Console.ReadLine();


            if (nombre != null && carrera != null)
            {
                usuario = new Usuario(nombre, matricula, carrera);
            }

            return usuario;
            Console.Clear();
        }
    }
}
