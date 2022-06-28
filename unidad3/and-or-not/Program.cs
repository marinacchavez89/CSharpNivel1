using System;

namespace and_or_not
{
    class Program
    {
        static void Main(string[] args)
        {   
            // AND [y] Oprador: &&
            //OR [o] Operador: ||
            int edad = 20;
            char inicial = 'J';
            
            //NOT [no] Operador: !
            if((inicial == 'J' || inicial == 'H') && !(edad < 20)){
                Console.WriteLine("21 OFF");
            }
            Console.WriteLine("Fin del programa");
        }
    }
}
