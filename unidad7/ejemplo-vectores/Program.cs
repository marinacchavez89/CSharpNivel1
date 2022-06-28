using System;

namespace ejemplo_vectores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vectores. Array. Arreglo.
            int n;
            int [] numeros = new int[10];
            //  0  1  2  3  4  5  6  7  8  9
            // |  |  |  |  |  |  |  |  |  |  |

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese la nota: ");
                n = int.Parse(Console.ReadLine());
                numeros[x] = n;
            }

            int acu = 0;

            for (int x = 0; x < 10; x++)
            {
                acu += numeros[x];
                Console.WriteLine("El valor es: " + numeros[x]);
            }

            int prom = acu / 10;

            Console.WriteLine("El promedio de notas es: " + prom);
        }
    }
}
