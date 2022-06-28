using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. 
            //Se pide determinar e informar:
            //El número de grupo con mayor porcentaje de números impares respecto al total de números que 
            //forman el grupo.
            //Informar cuántos grupos están formados por todos números ordenados de mayor a menor.
            
            int n, conNros, nrosImp, grupoImpMax = 0, min, conOrdenados = 0;
            double porcImp, porcMax = -1;
            bool banderaOrdenados;
                        

            for (int x = 0; x < 5; x++)
            {   
                conNros = 0;                
                nrosImp = 0;
                banderaOrdenados = true;
                
                n = int.Parse(Console.ReadLine());
                min = n;
                while(n != 0)
                { 
                
                conNros ++;
                if(n % 2 != 0)
                    nrosImp++;
                if(n <= min)
                    min = n;
                else
                    banderaOrdenados = false;
                
                n = int.Parse(Console.ReadLine());
                }

                porcImp = nrosImp * 100 / conNros;

                if(porcImp > porcMax ){
                porcMax = porcImp;
                grupoImpMax = x + 1;
                }

                if(banderaOrdenados)
                    conOrdenados++;


            }
            Console.WriteLine("El nro de grupo con mayor porcentaje de nros impares es: " + grupoImpMax );
            Console.WriteLine("El nro de grupos con nros ordenados son: " + conOrdenados );    
        }
    }
}
