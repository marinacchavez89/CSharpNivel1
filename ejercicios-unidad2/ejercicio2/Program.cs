using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para solicitar dos números y 
            //luego calcule y emita la suma en pantalla.
            int n1, cubo;

            Console.WriteLine("Ingrese un número: ");
            n1 = int.Parse(Console.ReadLine());

            cubo = n1*n1*n1;

            Console.WriteLine("El cubo del número ingresado es: " + cubo);
        }
    }
}
