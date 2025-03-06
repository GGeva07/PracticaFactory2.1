using CapaEntidades;

namespace CapaNegocio
{
    public class FactoryFormatos 
    {
        public static IConvertidorFormatos ConvertirFormatos(int formato)
        {
            switch (formato)
            {
                case 1:
                    return new formatoTXT();
                case 2:
                    return new formatoJSON();
                case 3:
                    return new formatoCSV();
                default:
                    Console.WriteLine("Opcion no valida intenta de nuevo");
                    return null;
            }
            
        }
    }
}
