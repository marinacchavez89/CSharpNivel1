using System;

namespace ejemplociclo
{
    class Program
    {
        static void Main(string[] args)
        {              
            // Ejemplo CICLO FOR
            
            // for(int x = 0; x < 5; x++){
            // Console.WriteLine("Hola mundo " + x);
            // }

            //Otro ejemplo de CICLO FOR

            int n = 0, promedio, suma = 0;
            

            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese nota: ");
                n = int.Parse(Console.ReadLine());
                suma += n;                                
            }

            promedio = suma / 5;
            Console.WriteLine("El promedio de la nota es: " + promedio);
        }
    }
}
