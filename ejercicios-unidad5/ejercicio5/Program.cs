using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {   // Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los 
            //números pares y el mínimo de los números impares.
            int n, pares = 0, impares = 0, mayorPar = 0, menorImpar = 0;            

            for (int x = 0; x < 20; x++)
            {   
                Console.WriteLine("Ingrese un nro: ");
                n = int.Parse(Console.ReadLine());

                if(n % 2 == 0){
                    pares++;  
                    if(pares == 1)
                        mayorPar = n;
                    else if(n > mayorPar)
                        mayorPar = n;                                                      
                }else if(n % 2 != 0){                
                    impares++;
                    if(impares == 1)
                        menorImpar = n;
                    else if(n < menorImpar)    
                        menorImpar = n;                                     
                }                                
            }

             Console.WriteLine("El nro mayor de los pares es: " + mayorPar);
             Console.WriteLine("El nro menor de los impares es: " + menorImpar);
        }
    }    
}
