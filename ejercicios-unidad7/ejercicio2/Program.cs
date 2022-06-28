using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 10  números enteros y los guarde en un vector. 
            //Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores 
            //que son mayores al promedio.

            int [] numeros = new int[10];
            
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un nro: ");
                numeros[x] = int.Parse(Console.ReadLine());
            }

            int acu = 0, prom;

            for (int x = 0; x < 10; x++)
            {
                acu += numeros[x];
            }

            prom = acu / 10;

            Console.WriteLine("El promedio de los nros es " + prom);

            for (int x = 0; x < 10; x++)
            {
                if(numeros[x] > prom){
                    Console.WriteLine("Este valor es mayor al promedio " + numeros[x]);
                }
            } 

            

        }
    }
}
