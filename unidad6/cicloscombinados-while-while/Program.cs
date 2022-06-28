using System;

namespace cicloscombinados_while_while
{
    class Program
    {
        static void Main(string[] args)
        {   //WHILE con WHILE
            int prom, acu, n, con;

            Console.WriteLine("Ingrese la edad: ");
            n = int.Parse(Console.ReadLine());

            while(n > 0){
            
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

                Console.WriteLine("Ingrese edad para continuar o un negativo para terminar.");
                n = int.Parse(Console.ReadLine());
            } 
        }
    }
}
