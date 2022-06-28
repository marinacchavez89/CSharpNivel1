using System;

namespace cicloscombinados_while_while
{
    class Program
    {
        static void Main(string[] args)
        {
            // WHILE con  FOR
            int prom, acu, n, con;

            Console.WriteLine("Ingrese 1 para comenzar a procesar o 0 para terminar.");
            n = int.Parse(Console.ReadLine());
            while(n != 0){
                acu = 0;
                for (int x = 0; x < 20; x++)
                {
                    Console.WriteLine("Ingrese la edad: ");
                    n = int.Parse(Console.ReadLine());
                    acu += n;
                }
                prom = acu / 20;
                Console.WriteLine("El promedio es: " + prom);

                Console.WriteLine("Ingrese 1 para continuar o 0 para terminar.");
                n = int.Parse(Console.ReadLine());
            }
        }
    }
}
