using System;

namespace ejemplo2_funciones
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

            //Lógica
            //resultado = n1 + n2; ---> esto ya no es necesario. Invoco la función:
            resultado = sumar(n1,n2);
            //Fin lógica.

            Console.WriteLine("El resultado es: " + resultado);
        }

        static int sumar(int a, int b){
            int r;
            r = a + b;
            return r;
        }
    }
}
