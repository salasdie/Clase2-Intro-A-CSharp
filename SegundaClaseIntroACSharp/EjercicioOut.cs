using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaClaseIntroACSharp
{
    class EjercicioOut
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Ingrese su nombre:");
            string nombre = Console.ReadLine();

            string resultado;

            ConvertirEnMayusculas(nombre, out resultado);
            Console.WriteLine("En mayusculas:");
            Console.WriteLine(resultado);
            Console.ReadLine();
        }

        private static bool ConvertirEnMayusculas(string nombre, out string resultado)
        {
            if (!string.IsNullOrEmpty(nombre))
            {
                resultado = nombre.ToUpper();
                return true;
            }
            else
            {
                resultado = "Nombre vacio";
                return false;
            }
        }
    }
}
