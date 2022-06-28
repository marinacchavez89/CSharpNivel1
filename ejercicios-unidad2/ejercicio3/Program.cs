using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que permita ingresar los kilómetros existentes 
            //entre dos ciudades y la velocidad promedio de un vehículo. 
            //Calcular y emitir por pantalla el tiempo aproximado que 
            //demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.
            float km, velocidad, tiempo;

            Console.WriteLine("Ingrese los kilómetros: ");
            km = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la velocidad promedio: ");
            velocidad = float.Parse(Console.ReadLine());

            tiempo = km/velocidad;

            Console.WriteLine("El tiempo que tardará para llegar es: " + tiempo.ToString("0.00") + " horas.");

        }
    }
}
