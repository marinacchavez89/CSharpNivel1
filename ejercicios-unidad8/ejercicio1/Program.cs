using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el 
            //producto de ambos. Luego hacer un programa que pida el precio de un artículo y la cantidad 
            //vendida y muestre por pantalla el monto total a pagar. Usar la función.

            int precio, cantidadVendida, totalPagar;

            Console.WriteLine("Ingrese el precio del producto: ");
            precio = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad vendida del producto: ");
            cantidadVendida = int.Parse(Console.ReadLine());

            totalPagar = producto(precio, cantidadVendida);

            Console.WriteLine("El total a pagar es: " + totalPagar);
        }

        static int producto(int n1, int n2){
            int producto;
            producto = n1*n2;
            return producto;
        }
    }
}
