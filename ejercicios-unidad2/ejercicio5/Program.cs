using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {

            // ctrl + f2 selecciona todo lo similar en variables y demás.

            //Hacer un programa para ingresar por teclado las tres notas de exámenes 
            //de un alumno y luego calcule y emita por pantalla el promedio final.
            
            float n1, n2, n3, promedio;

            Console.WriteLine("Ingrese nota primer exámen: ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese nota segundo exámen: ");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese nota tercer exámen: ");
            n3 = float.Parse(Console.ReadLine());

            promedio = (n1 + n2 + n3)/3;

            Console.WriteLine("La nota promedio del alumno es: " + promedio);
        }
    }
}
