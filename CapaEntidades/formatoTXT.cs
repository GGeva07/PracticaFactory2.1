//A

namespace CapaEntidades
{
    public class formatoTXT : IConvertidorFormatos
    {
        public void Convertidor(Usuario usuario)
        {
            string user = $"Nombre: {usuario.Nombre}" +
                $"\nMatricula: {usuario.Matricula}" +
                $"\nCarrera: {usuario.Carrera}";

            File.WriteAllText("Usuario.txt", user);
            Console.WriteLine("Datos exportados a formato TXT");
        }
    }
}
