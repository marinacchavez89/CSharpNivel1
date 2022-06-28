using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar cuatro números distintos y luego mostrar 
            //por pantalla el menor de ellos.
            int n1, n2, n3, n4, numeroMenor;

            Console.WriteLine("Ingrese primer nro: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo nro: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese tercer nro: ");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cuarto nro: ");
            n4 = int.Parse(Console.ReadLine());

            if(n1<n2)               
               numeroMenor = n1;
            else
               numeroMenor = n2;            
            if(n3 < numeroMenor)
               numeroMenor = n3;
            if(n4 < numeroMenor)         
               numeroMenor = n4;            

            Console.WriteLine("El menor nro es " + numeroMenor);
        }
    }
}
