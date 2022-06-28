using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un 
            //registro con los siguientes datos:
                //- Número de Artículo (1 a 15)
                //- Cantidad Vendida 
            // Puede haber varios registros para el mismo artículo y el último se indica con número de 
            //artículo igual a 0.
            
            // Se pide determinar e informar:
                // a) El número de artículo que más se vendió en total.
                // b) Los números de artículos que no registraron ventas.
                // c) Cuantas unidades se vendieron del número de artículo 10.

            int nroArticulo, cantidadVendida;
            int[] ventas = new int [15];
            
            for (int x = 0; x < 15; x++)
            {   
                ventas[x] = 0; 
            }

            Console.WriteLine("Ingrese nro de articulo");
            nroArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad vendida");
            cantidadVendida = int.Parse(Console.ReadLine());

            while (nroArticulo != 0)
            {   
                ventas[nroArticulo - 1] += cantidadVendida;

                Console.WriteLine("Ingrese nro de articulo");
                nroArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese cantidad vendida");
                cantidadVendida = int.Parse(Console.ReadLine());
            }

           // Punto A
           int maxCantidad = ventas[0];
           int nroMaximo = 1;
           for (int x = 0; x < 15; x++)
           {
                if(ventas[x] > maxCantidad);
                maxCantidad = ventas[x];
                nroArticulo = x + 1;
           }

           Console.WriteLine("El nro de articulo que más se vendió es: " + nroArticulo);

           //Punto B

           for (int x = 0; x < 15; x++)
           {
                if(ventas[x] == 0){
                    Console.WriteLine("El articulo: " + (x + 1) + " no tuvo ventas");
                }
           }

           //Punto C
           Console.WriteLine("La cantidad vendida del articulo 10 es " + ventas[9]);
        }
    }
}
