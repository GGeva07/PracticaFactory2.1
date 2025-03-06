//4
namespace CapaEntidades
{
    public class Usuario
    {
        public String Nombre { get; set; }

        public int Matricula { get; set; }

        public string Carrera { get; set; }

        public Usuario(string nombre, int matricula, string carrera)
        {
            Nombre = nombre;
            Matricula = matricula;
            Carrera = carrera;
        }
    }
}
