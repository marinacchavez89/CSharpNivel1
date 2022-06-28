using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {   // Hacer un programa para ingresar cuatro números 
        //y luego mostrar por pantalla cuáles son mayores a 100.
        int n1, n2, n3, n4;
        int mayorCien = 0;

            Console.WriteLine("Ingrese primer nro: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo nro: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese tercer nro: ");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cuarto nro: ");
            n4 = int.Parse(Console.ReadLine());

            if(n1 > 100)
            Console.Write(n1 + " ");
            mayorCien ++;

            if(n2 > 100)
            Console.Write(n2 + " ");
            mayorCien ++;

            if(n3 > 100)
            Console.Write(n3 + " ");
            mayorCien ++;

            if(n4 > 100)
            Console.Write(n4 + " ");
            mayorCien ++;    

            if(mayorCien != 0)
               Console.Write("Son mayores a 100.");

            Console.WriteLine(" Fin del programa.");
        }
    }
}
