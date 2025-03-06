//G
using System.Text.Json;
namespace CapaEntidades
{
    public class formatoJSON : IConvertidorFormatos
    {
        public void Convertidor(Usuario usuario)
        {
            string user = JsonSerializer.Serialize(usuario);
            File.WriteAllText("usuario.json", user);
            Console.WriteLine("Datos exportados a formato JSON");
        }
    }
}
