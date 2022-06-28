using System;

namespace cicloscombinados_for_while
{
    class Program
    {
        static void Main(string[] args)
        {   
            // FOR con WHILE
            int prom, acu, n, con;
            
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese la edad: ");
                n = int.Parse(Console.ReadLine());
                acu = 0; 
                con = 0;           
                while(n != 0){
                acu += n;
                con++;
                Console.WriteLine("Ingrese la edad: ");
                n = int.Parse(Console.ReadLine());
                }

                prom = acu / con;
                Console.WriteLine("El promeio es: " + prom);                
            }            
        }
    }
}
