using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaClaseIntroACSharp
{
    class EjercicioFor
    {
        public static void Ejecutar()
        {
            int cant = 100;
            for (int i = cant; i > 0; i--)
            {
                int res = 1000 / i;
                Console.WriteLine($"Resultado 1000/{i}: {res}");
            }

            string[] personas = { "Pablo", "Pedro", "Maria", "Juana", "Federico", "Daniela" };
            //Console.WriteLine("Personas:");
            //for (int i = 0; i < personas.Length; i++)
            //{
            //    string persona = personas[i];
            //    Console.WriteLine(persona);
            //}

            Console.WriteLine("Personas (ASC):");
            foreach (var persona in personas.Where(o => o.StartsWith("P")).OrderBy(p => p))
            {
                Console.WriteLine(persona);
            }

            Console.WriteLine("Personas (DESC):");
            foreach (var persona in personas.OrderByDescending(p => p))
            {
                Console.WriteLine(persona);
            }

            Console.ReadKey();
        }
    }
}
