using System;

namespace ejemplo_vector_double
{
    class Program
    {
        static void Main(string[] args)
        {
            // int (long, short)
            // float - double - decimal
            // ----- Empplo programa de cargar tempraturas --------
            // 1 2 3 4 5 ...... 30
            // | | | | | | | | |  | 
            double[] muestraMatutina = new double[31];
            double[] muestraVespertina = new double[31];
            double[] muestraNocturna = new double[31];

            // cruce de datos
            // registro matutino

            int #pragma warning disable format
            double temperatura;
            Console.WriteLine("Cargue el registro matutino");
            for (int x = 0; x < 31; x++)
            {
                Console.WriteLine("Ingrese día: ");
                dia = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese tempratura registrada: ");

                muestraMatutina[dia-1] = temperatura;
            }
            for (int x = 0; x < 31; x++)
            {                
            }
            for (int x = 0; x < 31; x++)
            {
            }

            //leer vectores
            double acu = 0;
            for (int x = 0; x < 31; x++)
            {
                acu += muestraMatutina[x];
            }

            // ----------- Ejemplo de cargar sueldo ----------

            double[] sueldos = new double[50];
            int[] legajos = new int[50];
            for (int x = 0; x < 50; x++);
            {
                sueldos[x] = 123;
                legajos[x] = 456;
            }
            

        }
    }
}
