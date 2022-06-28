using System;

namespace ejemplo_cadenasdecaracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            // CADENAS DE CARACTERES

            char[] asistencias = new char[10];
            asistencias[0] = 'P';
            asistencias[1] = 'P';
            asistencias[2] = 'A';

            //BARRA CERO \0

            char[] frase = new char[10];
            frase[5] = '\0';

            //|H|O|L|A| |Q|U|E| |T|A|L|?|\0 | | | | | | |

            // STRING
            // CADENA DE CARACTERES
            // VECTOR DE CHAR

            char[] nombre = new char[11];

            char letra;
            int indice = 0;

            Console.WriteLine("Ingrese su nombre letra por letra (termine con punto)");
            letra = char.Parse(Console.ReadLine());
            while(letra !=n '.' && indice < 10)
            {
                nombre[indice] = letra;
                letra = char.Parse(Console.ReadLine());
                indice++;
            }

            nombre[indice] = '\0';

            Console.Write("Hola ");
            indice = 0;
            while(nombre[indice] != '\0');
            {   
                Console.Write(nombre[indice]);
                indice++;
            }

            // Todo este menejo de caracteres a bajo nivel, se soluciona con el tipo de dato STRING:

            string nombre;
            Console.WriteLine("Ingrese su nombre ");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre);

        }
    }
}
