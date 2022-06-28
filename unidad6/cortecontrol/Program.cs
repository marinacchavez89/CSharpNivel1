using System;

namespace cortecontrol
{
    class Program
    {
        static void Main(string[] args)
        {
            //CORTE CONTROL
            // Vamos a cargar un legajo, edad, sueldo, codigoEquipo. (corta con sueldo - el sub lote)

            int legajo, edad, codigoEquipo;
            float sueldo;
            int equipoActual;

            //codigos de equipos:
            //1 river
            //2 bocca
            //3 racing

            Console.WriteLine("Ingrese el legajo");
            legajo =  int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la edad");
            edad =  int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el sueldo");
            sueldo =  float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el código de equipo");
            codigoEquipo =  int.Parse(Console.ReadLine());

            while (sueldo > 0)
            {   
                equipoActual = codigoEquipo;
                while (codigoEquipo == equipoActual)
                {   
                    //Acá proceso.
                    Console.WriteLine("Ingrese el legajo");
                    legajo =  int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la edad");
                    edad =  int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el sueldo");
                    sueldo =  float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el código de equipo");
                    codigoEquipo =  int.Parse(Console.ReadLine());

                    //Acá se pueden mostrar resultados.
                }

                //Acá también se pueden mostrar resultados.
            }

            //Acá también se pueden mostrar resultados.
        }
    }
}
