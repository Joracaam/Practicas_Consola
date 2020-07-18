using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_Programacion_Consola.EjerciciosPropuestos
{
    public class Matrix
    {
        private int[][] matrix { get; set; }

        public Matrix(int count, int mode = 0)
        {
            this.matrix = new int[count][];
        }

        public void initializeVector(int rows)
        {
            var count = 0;

            do
            {
                var item = count + 1;

                var vector = new int[item];

                for (int i = 0; i < item; i++)
                {
                    Console.Write($"\nIngrese el valor [{count}][{i}]: ");
                    vector[i] = Convert.ToInt32(Console.ReadLine());
                }

                this.matrix[count] = vector;
                count++;

            } while (count < rows);
        }

        public void initializeVector(int first, int second)
        {

            var vector = new int[second];

            for (int i = 0; i < second; i++)
            {
                Console.Write($"\nIngrese el valor [{first}][{i}]: ");
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

            this.matrix[first] = vector;

        }

        public void printMatrix()
        {
            for (int i = 0; i < this.matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write($" \t{matrix[i][j]} ");
                }
                Console.WriteLine("\t");
            }
        }
    }
}
