using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 
            //más una comisión del 5% sobre el total facturado por cada empleado. 
            //Hacer un programa para ingresar el total facturado por un empleado y 
            //que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.
            
            float totalFacturado, sueldoFinal;
            const float sueldo = 15000;
            const float comision = 0.05F;

            Console.WriteLine("Ingrese el total facturado: ");
            totalFacturado = float.Parse(Console.ReadLine());            

            sueldoFinal = sueldo + (totalFacturado*comision);

            Console.WriteLine("El toral a pagar es: " + sueldoFinal);
        }
    }
}
