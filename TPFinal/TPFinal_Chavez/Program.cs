using System;

namespace TPFinal_Chavez
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que permita ingresar una lista de números que corta cuando se 
            //ingresa un cero. A partir de dichos datos informar:
                // a. El mayor de los números pares.
                // b. La cantidad de números impares.
                // c. El menor de los números primos.
            //Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.

            int n, pares = 0,  mayorPar = 0, conImp = 0, primos = 0, menorPrimo = 0;            

            do{
                Console.WriteLine("Ingresar un nro: ");
                n = int.Parse(Console.ReadLine()); 

                if(n % 2 != 0){
                conImp++;
                }

                if(n % 2 == 0){
                pares++;  
                if(pares == 1)
                mayorPar = n;
                else if(n > mayorPar)
                        mayorPar = n;
                }

                if(primo(n)){
                primos++;
                if(primos == 1)
                menorPrimo = n;
                else if(n < menorPrimo)
                        menorPrimo = n;
                }
            }while(n != 0);    

            Console.WriteLine("El mayor de los nros pares es: " + mayorPar);
            Console.WriteLine("La cantidad de nros impares es: " + conImp);
            Console.WriteLine("El nro primo menor es: " + menorPrimo);           
        }

        static bool primo(int a){
        
            int con = 0;

            for (int x = 1; x <= a; x++)
            {
                if(a % x == 0)
                con++;                
            }
            if(con == 2){
                    return true;
                }else{
                    return false;
                }
        }
    }
}
