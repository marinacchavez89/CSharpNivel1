using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar un número y luego se emita por pantalla 
            //un cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.
            int n;
            Console.WriteLine("ingrese un número");
            n = int.Parse(Console.ReadLine());
            if(n > 10){
                Console.WriteLine("El número ingresado es mayor a 10");
            }else if(n < 10){
                Console.WriteLine("El número ingresado es menor a 10");
            }
        }
    }
}
