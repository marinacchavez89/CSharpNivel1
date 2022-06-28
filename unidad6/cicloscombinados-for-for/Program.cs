using System;

namespace cicloscombinados_for_for
{
    class Program
    {
        static void Main(string[] args)
        {   // FOR con FOR
            int prom, acu, n;
            
            for (int y = 0; y < 10; y++)
            {
                acu = 0;
                for (int x = 0; x < 20; x++)
                {
                    Console.WriteLine("Ingrese la edad: ");
                    n = int.Parse(Console.ReadLine());
                    acu += n;
                }
                prom = acu / 20;
                Console.WriteLine("El promeio es: " + prom);
            }        
        }
    }
}
