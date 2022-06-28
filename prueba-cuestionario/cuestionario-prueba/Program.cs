using System;

namespace cuestionario_prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;
            Console.WriteLine("Ingrese un nro: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro nro: ");
            n2 = int.Parse(Console.ReadLine());

            resultado = n1 + n2 + 1;

            Console.WriteLine("El resultado es " + resultado);
        }
    }
}
