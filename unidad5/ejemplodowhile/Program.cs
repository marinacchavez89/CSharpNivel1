using System;

namespace ejemplodowhile
{
    class Program
    {
        static void Main(string[] args)
        {   //Ej de ciclo DO WHILE

            int n, con = 0;

            do{
                Console.WriteLine("Ingrese un nro: ");
                n = int.Parse(Console.ReadLine());
                con++;
            }while(n != 0);

            Console.WriteLine("Ingresaste: " + con + " nros.");
            
        }
    }
}
