using System;

namespace ejerecicio5bis
{
    class Program
    {
        static void Main(string[] args)
        {   //Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los 
            //mismos se encuentran ordenados de forma decreciente.

            int n1, n2, n3, n4;
            
            Console.WriteLine("ingrese primer nro: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese segundo nro: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese tercer nro: ");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese cuarto nro: ");
            n4 = int.Parse(Console.ReadLine());

            if(n1>n2 && n3<n2 && n4<n3){
                Console.WriteLine("Los nros se encuentran ordenados de forma decreciente");
            }else{
                Console.WriteLine("Los nros no se encuentran ordenados de forma decreciente");
            }            
        }
    }
}
