//B
namespace CapaEntidades
{
    public class formatoCSV : IConvertidorFormatos
    {
        public void Convertidor(Usuario usuario)
        {
            string user = $"Nombre: {usuario.Nombre}" +
            $"\nMatricula: {usuario.Matricula}" +
            $"\nCarrera: {usuario.Carrera}";

            File.WriteAllText("Usuario.csv", user);
            Console.WriteLine("Datos exportados a formato CSV");
        }
    }
}
