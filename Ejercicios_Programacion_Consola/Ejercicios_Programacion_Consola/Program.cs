using System;
using System.Collections.Generic;
using Ejercicios_Programacion_Consola.ejercicios;

namespace Ejercicios_Programacion_Consola
{
    class Program
    {

        static void Main(string[] args)
        {
            bool nextIteration = true;
            ejercicios.ejercicios mat = new ejercicios.ejercicios();

            //Options
            do
            {
                mat.Menu();

                Console.Write("\nSi desea salir ingrese 'N', sino presione ENTER: ");
                var value = Console.ReadLine();

                if (value.ToUpper() == "N")
                {
                    nextIteration = false;
                }

            } while (nextIteration);

        }

        
    }
}
