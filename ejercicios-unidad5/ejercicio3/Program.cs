using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {   //Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas 
            //personas mayores a 18 años.
            int n = 0, mayor = 0, cantmayor = 0, promedio;

            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese edad: ");
                n = int.Parse(Console.ReadLine());
                if(n > 18){
                    mayor += n;
                    cantmayor += 1;
                }
            }

            promedio = mayor / cantmayor ; 

            Console.WriteLine("Promedio personas mayores a 18 años: " + promedio);
        }
    }
}
