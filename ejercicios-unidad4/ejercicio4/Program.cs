using System;

namespace ejercicio4bis
{
    class Program
    {
        static void Main(string[] args)
        {   //Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de 
            //los dos primeros es mayor al producto del segundo con el tercero.

            int n1, n2, n3;
            
            Console.WriteLine("ingrese primer nro: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese segundo nro: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese tercer nro: ");
            n3 = int.Parse(Console.ReadLine());

            if((n1+n2)>(n2*n3)){
            Console.WriteLine("Si, la suma de los primeros nros es mayor al producto del 2do y 3ero.");
            }else{Console.WriteLine("No, la suma de los primeros no es mayor al producto de los últimos");
            }
        }
    }
}
