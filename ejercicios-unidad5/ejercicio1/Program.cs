using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Hacer un programa para mostrar los números del 1 al 10. 
            //No se debe realizar ningún pedido de datos.
            
            int n = 0;
            
            for ( int x = 0; x < 10; x++){
                n += 1;
                Console.WriteLine( n );
            }
            
        }
    }
}
