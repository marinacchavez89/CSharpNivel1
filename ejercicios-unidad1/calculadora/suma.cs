using System;

namespace calculadora
{
    class Suma

    {
         static void Main(string[] args)
         {
        
        // Paso 0 - declarar variables.
        // tipo de variables/datos: int (nros ent),float(nros coma), char(letra), bool (v o f, en 0 y 1)
        int n1, n2, suma;   

        // Paso 1: Perdir los valores.
        Console.WriteLine("Ingrese un número: ");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro número: ");
        n2 = int.Parse(Console.ReadLine());

        // Paso 2: realizar el cálculo.
        suma = n1 + n2;

        // Paso 3: emimtir resultado.
        Console.WriteLine("La suma de los dos números es: " + suma);
        }
    }
}