using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_Programacion_Consola.EjerciciosPropuestos
{
    class EmpleyeeAttendance
    {
        private string[] employees;
        private Matrix attendance;

        public EmpleyeeAttendance(int CountEmployee)
        {
            employees = new string[CountEmployee];
            ChargeEmployees();
        }

        public void ChargeEmployees()
        {
            for (int i = 0; i < this.employees.Length; i++)
            {
                Console.Write($"\nInserte el nombre del Empleado a agregar: ");
                this.employees[i] = (Console.ReadLine());
            }
        }

        public void InitializeNonAttendanceMatrix()
        {
            attendance = new Matrix(this.employees.Length);

            for (int i = 0; i < this.employees.Length; i++)
            {
                Console.Write($"\nCantidad de ausencias para el usuario {this.employees[i]}: ");
                attendance.AutoFillVector(i,Convert.ToInt32(Console.ReadLine()));
            }

        }

        public void PrintMatrix()
        {
            Console.WriteLine("\nLas ausencias son\n");
            for (int i = 0; i < this.employees.Length; i++)
            {
                Console.Write($"\n{this.employees[i]}:");
                attendance.printMatrixSub(i);
            }
        }

        public void MaxNonAttandande()
        {
            int count = 0;
            int max = 0;
         
            for (int i = 0; i < this.employees.Length; i++)
            {
                var value = attendance.Length(i);
                if (value > max)
                {
                    max = value;
                    count = i;
                }
            }

            Console.WriteLine($"\nEl empleado con mas ausencias es {employees[count]} con un total de {max} ausencias");
        }

    }
}
