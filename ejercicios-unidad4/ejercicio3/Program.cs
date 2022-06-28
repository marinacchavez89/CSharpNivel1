using System;

namespace ejercicio3bis
{
    class Program
    {
        static void Main(string[] args)
        {   
        //Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. 
        //Para ello existe la siguiente escala de precios:

                        //i5 (1)   i7 (2)	 i9 (3)
            //8 RAM (1)	 USD 800  USD 900	USD 1200
            //16 RAM (2) USD 900  USD 1000	USD 1400
            //32 RAM (3) USD 1000 USD 1400	USD 2000

        //Además, el equipo viene con un disco que permite almacenar 500 GB de información y que 
        //se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo  adicional de USD 300. 
            
        //Hacer un programa que solicite la opción de procesador, la opción de memoria  RAM, y si 
        //extiende el disco o no (ingresa 1 para extender y 0 para no extender) y calcule y 
        //emita por pantalla el monto de la máquina seleccionada.
            int ram, procesador, extraMemo, importe = 0;

            Console.WriteLine("ingrese nro de RAM");
            ram = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese número de procesador");
            procesador = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Extiende memoria? Ingrese 1: si; 2: no ");
            extraMemo = int.Parse(Console.ReadLine());
           

            if(ram == 1 && procesador == 1 ){
                importe += 800;                
            }

            if(ram == 1 && procesador == 2){
                importe += 900;                
            }

            if(ram == 1 && procesador == 3){
                importe += 1200;                
            }

            if(ram == 2 && procesador == 1){
                importe += 900;                
            }

            if(ram == 2 && procesador == 2){
                importe += 1000;                
            }

            if(ram == 2 && procesador == 3){
                importe += 1400;                
            }

            if(ram == 3 && procesador == 1){
                importe += 1000;                
            }

            if(ram == 3 && procesador == 2){
                importe += 1400;                
            }

            if(ram == 3 && procesador == 3){
                importe += 2000;                
            }

            if (extraMemo == 1)
                importe += 300;
                Console.WriteLine("El importe a pagar es " + importe );        
        }
    }
}
