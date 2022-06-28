using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para recibir listas de números positivos que están separadas entre sí por un 
            //cero. El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene 
            //cada lista.

            int n, con, numeroGrupo = 0;

            do
            {   numeroGrupo++;
                con = 0;
                n = int.Parse(Console.ReadLine());
             while (n > 0){
                con++;
                n = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("La cantidad de nros del grupo " + numeroGrupo + " es: " + con);

            }while (n >= 0);
        }
    }
}
