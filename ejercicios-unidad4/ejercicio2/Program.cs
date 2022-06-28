using System;

namespace ejercicio2bis
{
    class Program
    {
        static void Main(string[] args)
        {
        //Un importante negocio de desinfectante líquido realiza descuentos dependiendo 
        //de la cantidad de litros vendidos según la siguiente escala:

            //Si vende menos de 100 litros, no hay descuento.
            //Si vende entre 101 y 300 litros, el descuento es del 10%.
            //Si vende entre 301 y 500 litros, el descuento es del 15%.
            //Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.

        //Hacer un programa que solicite el ingreso del importe total de la venta y 
        //la cantidad de litros vendidos y calcule y emita el importe con el descuento aplicado.
            
            float importe, importeTotal = 0;

            Console.WriteLine("ingrese importe ");
            importe = float.Parse(Console.ReadLine());

            if(importe < 100){
                    importeTotal += importe; 
                    Console.WriteLine("El total a pagar es " + importeTotal);                   
                }
            if((importe >= 101) && (importe <= 300)){
                importeTotal += importe*0.90F;
                Console.WriteLine("El total a pagar es " + importeTotal);
                }
            if((importe >= 301) && (importe <= 500)){
                importeTotal += importe*0.85F;
                Console.WriteLine("El total a pagar es " + importeTotal);
                }
            if(importe > 500){
                importeTotal += importe*0.75F;
                Console.WriteLine("El total a pagar es " + importeTotal);
            }            
        }
    }
}
