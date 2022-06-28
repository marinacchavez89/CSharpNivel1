using System;

namespace switch
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Switch 
            char letra = 'A';

            switch(letra){
                case 'M':
                    Console.WriteLine("Tu nombre commienza con la letra M");
                    // Aca iria el código que necesite.
                    break;
                case 'H':
                    // código
                    // código
                    break;
                case 'R':
                    break;
                default:
                    // cuando no coincide ninguna, aca iria el "error".
                    break;

            }
            
        }
    }
}
