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
                Console.Write($"Cantidad de ausencias para el usuario {this.employees[i]}: ");
                attendance.initializeVector(i,Convert.ToInt32(Console.ReadLine()));
            }

        }

        public void RegisterNonAttendance()
        {

        }

    }
}
