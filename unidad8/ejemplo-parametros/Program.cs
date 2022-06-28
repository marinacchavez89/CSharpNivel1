using System;

namespace ejemplo_parametros
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0, resultado;

            pedirDatos(ref n1, ref n2);

            //Lógica
            //resultado = n1 + n2; ---> esto ya no es necesario. Invoco la función:
            resultado = sumar(n1,n2); 
            //En este ej, los parámetros estan enviados por "Valor" 
            //(generan una copia en memoria cuando ejecuta la función)
            //Si yo coloco la palabra "ref" delante de las variables tanto aquí como en la función, 
            //recién ahí, le estaria mandando los parámetos por Referencia y le estaría enviando la dirección
            // en la cual están guardadas mimas variables originales ("n1" y "n2" en este caso)
            // Quedaría asi: resultado = sumar(ref n1,n2); 
            //Fin lógica.

            Console.WriteLine("El resultado es: " + resultado);

            //SCOPE (ALCANCE, ESPACIO DE TRABAJO PRINCIPAL)
        }
        // y aca quedaria asi --> static int sumar(ref int a, int b) --> parámetros por refrencia
        static int sumar(int a, int b){
            int r;
            r = a + b;
            return r;
        }

        static void pedirDatos(ref int j, ref int h){
            Console.WriteLine("Ingrese un nro: ");
            j = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro nro: ");
            h = int.Parse(Console.ReadLine());
        }
    }
}
