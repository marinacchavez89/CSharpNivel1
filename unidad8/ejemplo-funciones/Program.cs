using System;

namespace ejemplo_funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //FUNCIONES
            //Partes de una función: 
            // CABECERA: 
            // 1. Tipo de dato. 2. Nombre. 3. Opcional: parámetros.
            // CUERPO:
            // Definición/lógica. Opcional: retorno de valor / resultado.
            // int n = devolverUno();
            Console.WriteLine("Fin del programa: " + devolverUno());
        }

        static int devolverUno(){
            int nro = 15;
            return nro;
        }
    }
}
