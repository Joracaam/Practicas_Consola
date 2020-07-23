using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ejercicios_Programacion_Consola.ejercicios
{
    public class Ejercicios
    {
        private int firstValue { get; set; }
        private int secondValue { get; set; }

        public void Menu()
        {
            Console.Clear();
            Console.Write("Elija una de las siguientes opciones\n\n");

            Console.Write("" +
                                "Ejercicios propuestos:\n\n" +
                                "1- Cociente y residuo\n" +
                                "2- Hallar Multiplos\n" +
                                "3- Multiplicar\n" +
                                "4- Dividir\n" +
                                "5- Encontrar vocales\n" +
                                "6- Encontrar numeros positivos\n" +
                                "7- Valor absoluto\n" +
                                "8- Imprimir del 1 al 10\n" +
                                "9- Imprimir en orden descendente los pares del 26 al 10\n" +
                                "10- Imprimir del 1 al 10 (Usando Do...While)\n" +
                                "11- Imprimir en orden descendente los pares del 26 al 10 (Usando Do...While)\n" +
                                "12- Imprimir en orden descendente los numeros del 15 al 5\n" +
                                "13- Mostrar los proximos n numeros a partor de un numero dado\n" +
                                "14- Mostrar los multiplos de 3 desde el 1 al 50\n" +
                                "15- Vector\n" +
                                "16- Vector de salarios\n" +
                                "17- Vector de Paises\n" +
                                "18- Ordenar Vectores paralelos (Ciudades)\n" +
                                "19- Matrix\n" +
                                "20- Temperatura promedio\n" +
                                "21- Matriz Irregular\n" +
                                "22- Empleados\n" +
                                "23- Intercambio Matriz\n" +
                                "24- Vertices Matriz\n" +
                                "Opcion: ");

            int SelectedOption = 0;
            var Option = Int32.TryParse(Console.ReadLine(),out SelectedOption);
            

            switch (SelectedOption)
            {
                case 1:
                    divideAndGetRest();
                    break;
                case 2:
                    isMultiple();
                    break;
                case 3:
                    multiplyByZero();
                    break;
                case 4:
                    Console.Write("Inserte el primer valor a dividir: ");
                    firstValue = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Inserte el seguno valor a dividir: ");
                    secondValue = Convert.ToInt32(Console.ReadLine());
                    divide(firstValue, secondValue);
                    break;
                
                case 5:
                    findVocals();
                    break; 
                
                case 6:
                    countRealNumbers();
                    break;
                
                case 7:
                    abs();
                    break;

                case 8:
                    printFromOneToTen();
                    break;
                
                case 9:
                    printDescendingPars(26, 10);
                    break;                
                
                case 10:
                    printFromOneToTenWithDoWhile();
                    break;                
                
                case 11:
                    printDescendingParsWithDoWhile(26,10);
                    break;                
                
                case 12:
                    printNumberFromAGivenValueDesc(15,5);
                    break;
                
                case 13:
                    printNumberFromAGivenValueAsc(1,8);
                    break;                
                
                case 14:
                    GetMultipleByInterval(1,50,3);
                    break;
                
                case 15:
                    vector();
                    break;                
                
                case 16:
                    Console.WriteLine("Los salarios en orden de menos mayor son: ");
                    SortVector(5);
                    break;

                case 17:
                    Console.WriteLine("Los paises en orden de menos mayor son: ");
                    SortVector_string(5);
                    break;

                case 18:
                    parallelVectorSorting(5);
                    break;
                
                case 19:
                    printMatrix(matrix(2,5));
                    break;

                case 20:
                    AvgValue(4,3);
                    break;
                    
                case 21:
                    irregularMatrix(5);
                    break;                    
                
                case 22:
                    employeeAttendance(3);
                    break;                
                
                case 23:
                    Console.Write("Cantidad de Filas: ");
                    firstValue = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Cantidad de Columnas: ");
                    secondValue = Convert.ToInt32(Console.ReadLine());

                    var _matrix = matrix(firstValue, secondValue);

                    Console.WriteLine($"\nMatriz ANTES de intercambiar las filas {1} y {2}");
                    printMatrix(_matrix);

                    Console.WriteLine($"Matriz LUEGO de intercambiar las filas {1} y {2}");
                    printMatrix(changeRowsMatrixOrder(_matrix, 1, 2));                    
                    break;
                case 24:
                    Console.Write("Cantidad de filas: ");
                    firstValue = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Cantidad de columnas: ");
                    secondValue = Convert.ToInt32(Console.ReadLine());
                    printMatrixVertex(matrix(firstValue, secondValue));
                    break;

                default:
                    break;
            }

        }

        //WebServices
        // Method to get the Max double value in an array
        public Int64 MajorNumber()
        {
            bool nextValue = true;
            List<Int64> values = new List<Int64>();

            do
            {
                Console.Write("\nIngrese el valor que desea insertar: ");
                values.Add(Convert.ToInt64(Console.ReadLine()));

                Console.Write("Le gustaria ingresar otro valor extra? Y/N");
                var next = Console.ReadLine();

                if (next.ToUpper() == "N")
                {
                    nextValue = false;
                }

            } while (nextValue);



            var MajorNumber = values.Max();
            return MajorNumber;
        }

        // Method to get the reflection of a number
        public int InvertNumber()
        {
            string InvertedNumber = "";
            Console.Write("Inserte el numero que desea invertir: ");
            int insertedValue = Convert.ToInt32(Console.ReadLine());


            string Number = insertedValue.ToString();

            foreach (char value in Number)
            {
                // Put the character before the inverted string
                InvertedNumber = value + InvertedNumber;
            }

            if (!string.IsNullOrWhiteSpace(InvertedNumber))
            {
                return Convert.ToInt32(InvertedNumber);
            }
            else
            {
                return 0;
            }
        }

        // Method to get the Sum of two double variables
        public int add()
        {
            Console.Write("Inserte el primer valor a sumar: ");
            int firstInsertedValue = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inserte el segundo valor a sumar: ");
            int secondInsertedValue = Convert.ToInt32(Console.ReadLine());

            return (firstInsertedValue + secondInsertedValue);
        }

        // Method to get the difference of two double variables
        public int substract()
        {
            Console.Write("Inserte el primer valor a restar: ");
            int firstInsertedValue = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inserte el segundo valor a restar: ");
            int secondInsertedValue = Convert.ToInt32(Console.ReadLine());

            return (firstInsertedValue - secondInsertedValue);
        }

        // Method to get the product of two double variables
        public int multiply()
        {
            Console.Write("Inserte el primer valor a multiplicar: ");
            int firstInsertedValue = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inserte el segundo valor a multiplicar: ");
            int secondInsertedValue = Convert.ToInt32(Console.ReadLine());

            return (firstInsertedValue * secondInsertedValue);
        }

        // Method to get the  two double variables
        public void divide(int a, int b)
        {
            if (b != 0)
            {
                var div = (a / b);
                Console.WriteLine($"El cociente es: {div}");
            }
            else
            {
                Console.WriteLine($"No se puede dividir entre cero");
            }
        }

        // Method to get the power of a number (base) elevated to a number (exponent)
        public int pow()
        {
            Console.Write("Inserte el valor de ls base: ");
            int baseValue = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inserte el valor del exponente: ");
            int exponentValue = Convert.ToInt32(Console.ReadLine());

            int pow = baseValue;

            for (int i = 1; i < exponentValue; i++)
            {
                pow *= baseValue;
            }
            return (pow);
        }

        // Method to get the division of two variables
        public void divideAndGetRest()
        {
            Console.Write("Inserte el primer valor a dividir: ");
            int firstInsertedValue = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inserte el seguno valor a dividir: ");
            int secondInsertedValue = Convert.ToInt32(Console.ReadLine());

            if (secondInsertedValue != 0)
            {
                divide(firstInsertedValue, secondInsertedValue);
                modularDivision(firstInsertedValue , secondInsertedValue);
            }
            else
            {
                Console.WriteLine($"No puede dividir entre cero");
            }
        }

        // Method to get the  two double variables
        public void modularDivision(int a, int b)
        {

            if (b != 0)
            {
                var rest = (a % b);
                Console.WriteLine($"El residuo es: {rest}");
            }
            else
            {
                Console.WriteLine($"No puede dividir entre cero");
            }
        }


        // Method to get the power of a number 'a' elevated to a number 'b'
        public void isMultiple()
        {
            Console.Write("Ingrese el primer valor: ");
            int firstInsertedValue = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo valor: ");
            int secondInsertedValue = Convert.ToInt32(Console.ReadLine());

            if (secondInsertedValue != 0)
            {
                
                if (isMultiple_bool(firstInsertedValue,secondInsertedValue))
                {
                    Console.WriteLine($"{firstInsertedValue} es un multipo de {secondInsertedValue}");
                }
                else
                {
                    Console.WriteLine($"{firstInsertedValue} NO es un multiplo de {secondInsertedValue}");
                }
            }
            else
            {
                Console.WriteLine($"No puede dividir entre cero");
            }
        }

        // Boolean method to evaluate if a given number 'a' is multiple of a given number 'b'
        public bool isMultiple_bool(int a, int b)
        {

            if (b != 0)
            {
                if ((a%b) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        // Multiply just if one of the values isn't nos zero
        public void multiplyByZero()
        {
            Console.Write("\nIngrese el valor que desea multiplicar: ");
            var firstValue = Convert.ToInt32(Console.ReadLine());

            if (firstValue == 0)
            {
                Console.Write("El producto de 0 por cualquier número es 0");
            }
            else
            {
                Console.Write("\nIngrese el valor que desea multiplicar: ");
                var secondValue = Convert.ToInt32(Console.ReadLine());

                if (secondValue == 0)
                {
                    Console.Write("El producto de 0 por cualquier número es 0");
                }
                else
                {
                    Console.WriteLine($"El producto es {firstValue*secondValue}");
                }
            }           
        }

        // Find vocals
        public void findVocals()
        {
            List<string> vocales = new List<string>(){"a","e","i","o","u"};

            Console.Write("Ingrese una letra: ");
            var letter = Console.ReadLine();

            if (vocales.Contains(letter.ToLower()))
            {
                Console.WriteLine($"{letter} es una vocal");
            }
            else
            {
                Console.WriteLine($"{letter} NO es una vocal");
            }
        }

        // Signs Of number
        public void countRealNumbers()
        {
            int count = 0;
            Console.Write("\nIngrese el primer valor: ");
            var firstValue = Convert.ToInt32(Console.ReadLine());

            if (firstValue > 0)
            {
                count++;
            }

            Console.Write("\nIngrese el segundo valor: ");
            var secondValue = Convert.ToInt32(Console.ReadLine());

            if (secondValue > 0)
            {
                count++;
            }

            if (count > 0)
            {
                Console.WriteLine($"Hay {count} números Positivo");
            }
            else
            {
                Console.WriteLine("Ninguno de los números es positivo");
            }

            
        }

        // Abs
        public void abs()
        {
            Console.Write("\nIngrese un numero: ");
            var value = Convert.ToInt32(Console.ReadLine());

            value = (value >= 0 ? value : value *= -1);
            Console.WriteLine($"El valor absolutivo es: {value}");
        }

        // print number from 1 to 10
        public void printFromOneToTen()
        {
            int number = 1;
            while (number <= 10)
            {
                Console.Write($"[ {number} ]");
                number++;
            }
        }

        // print pars number from 26 to 10 desc
        public void printDescendingPars(int from, int to)
        {
            if (from > to)
            {
                int _from = from % 2 == 0 ? from : from - 1;
                Console.WriteLine($"Números pares desde el {from} hasta el {to}");

                while (_from >= to)
                {
                    Console.Write($" [{_from}] ");
                    _from -= 2;
                }
            }
            else
            {
                Console.WriteLine("El primer parametro debe ser mayor que el segundo para evitar loop infinito");
            }
        }

        // print number from 1 to 10 with do while
        public void printFromOneToTenWithDoWhile()
        {
            int number = 1;
            do
            {
                Console.Write($"[ {number} ]");
                number++;
            } while (number <= 10);
        }

        // print pars number from 26 to 10 desc with do whilw
        public void printDescendingParsWithDoWhile(int from, int to)
        {
            if (from > to)
            {
                int _from = from % 2 == 0 ? from : from - 1;
                Console.WriteLine($"Números pares desde el {from} hasta el {to}");

                do
                {
                    Console.Write($" [{_from}] ");
                    _from -= 2;
                } while (_from >= to);
            }
            else
            {
                Console.WriteLine("El primer parametro debe ser mayor que el segundo para evitar loop infinito");
            }
        }

        // Number numbers from a given value to other in desc
        public void printNumberFromAGivenValueDesc(int from, int to)
        {
            if (from > to)
            {
                Console.WriteLine($"Números desde el {from} hasta el {to}");

                for (int i = from; i >= to; i--)
                {
                    Console.Write($" [{i}] ");
                }
            }
            else
            {
                Console.WriteLine("El primer parametro debe ser mayor que el segundo para evitar loop infinito");
            }
        }

        // Number numbers from a given value to other in desc
        public void printNumberFromAGivenValueAsc(int from, int CountOfPar)
        {
            if (CountOfPar >= 0)
            {
                Console.WriteLine($"Los proximos {CountOfPar} números pares a partir del {from} son:");
                int _from = from % 2 == 0 ? from : from + 1;

                for (int i = _from, count = 0; count < CountOfPar; i+=2, count++)
                {
                    Console.Write($" [{i}] ");

                }
            }
            else
            {
                Console.WriteLine("El segundo parametro debe ser un numero positivo");
            }
        }

        // Find multiples of a given number inside an interval
        public void GetMultipleByInterval(int start, int end, int multipleOf)
        {
            if (start <= end)
            {
                Console.WriteLine($"Los multiplos de {multipleOf} desde {start} hasta {end} son: ");
                for (int i = start; i <= end; i++)
                {
                    if (isMultiple_bool(i,multipleOf))
                    {
                        Console.Write($" [{i}] ");
                    }
                }
            }
            else
            {
                Console.WriteLine("El primer valor debe ser menor que el segundo");
            }
        }

        // Min value in Vector and print how many time its  
        public void vector()
        {
            List<int> vector = new List<int>();
            bool follow = true;
            int value = 0, count = 0;

            do
            {
                Console.Write("Ingrese el valor a agregar: ");

                var converted = false;

                converted = Int32.TryParse(Console.ReadLine(), out value);

                if (converted)
                {
                    vector.Add(value);
                }

                Console.WriteLine("Le gustaria agregar otro valor? Y/N");
                var nextValue = Console.ReadLine();

                if (nextValue.ToUpper() == "N")
                {
                    follow = false;
                }

            } while (follow);

            var minValueInArray = vector.Min();

            foreach (var item in vector)
            {
                if (item == minValueInArray)
                {
                    count++;
                }
            }
            Console.WriteLine($"El menor numero es {minValueInArray} y se repite {count} veces");
        }

        // Vector sorting
        public void SortVector(int CountOfElements)
        {
            List<double> values = new List<double>();
            int count = 0;

            do
            {
                Console.Write($"Inserte el valor #{count+1}: ");
                values.Add(double.Parse(Console.ReadLine()));
                count++;
            } while (count < CountOfElements);

            values.Sort();
            
            foreach (var item in values)
            {
                Console.Write($" [{item}] ");
            }
        }

        // Make an algorithm for sorting using string array
        public void SortVector_string(int CountOfElements)
        {
            string[] values = new string[5];
            int count = 0;

            do
            {
                Console.Write($"Inserte el valor #{count + 1}: ");
                values[count] = (Console.ReadLine());
                count++;
            } while (count < CountOfElements);

            for (int i = 0; i < CountOfElements - 1; i++)
            {
                for (int j = i + 1; j < values.Length; j++)
                {
                    if (values[i].CompareTo(values[j]) > 0)
                    {
                        String temp = values[i];
                        values[i] = values[j];
                        values[j] = temp;
                    }
                }
            }

            foreach (var item in values)
            {
                Console.Write($" [{item}] ");
            }
        }

        // Countries and Population
        public void parallelVectorSorting(int countArray)
        {
            string[] stringArray = new string[countArray];
            int[] intArray = new int[countArray];
            int count = 0;

            do
            {
                Console.Write($"\nInserte el nombre #{count + 1}: ");
                stringArray[count] = (Console.ReadLine());

                Console.Write($"Inserte cantidad de habitantes #{count + 1}: ");
                intArray[count] = Convert.ToInt32(Console.ReadLine());
                count++;
            } while (count < countArray);

            // Sorting for String Array
            for (int i = 0; i < countArray - 1; i++)
            {
                for (int j = i + 1; j < stringArray.Length; j++)
                {
                    if (stringArray[i].CompareTo(stringArray[j]) > 0)
                    {
                        String tempString = stringArray[i];
                        int tempInt = intArray[i];

                        stringArray[i] = stringArray[j];
                        stringArray[j] = tempString;

                        intArray[i] = intArray[j];
                        intArray[j] = tempInt;


                    }
                }
            }

            Console.WriteLine("\nEn order de las ciudades:");
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.Write($" [{stringArray[i]}: {intArray[i]}] "); 
            }

            // Sorting for int Array
            for (int i = 0; i < countArray - 1; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i].CompareTo(intArray[j]) > 0)
                    {
                        String tempString = stringArray[i];
                        int tempInt = intArray[i];

                        stringArray[i] = stringArray[j];
                        stringArray[j] = tempString;

                        intArray[i] = intArray[j];
                        intArray[j] = tempInt;


                    }
                }
            }

            Console.WriteLine("\nEn order de la poblacion:");
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.Write($" [{stringArray[i]}: {intArray[i]}] ");
            }

        }

        // Matrix
        public int[,] matrix(int rows, int columns)
        {
            int[,] matrix = new int[rows,columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Ingrese el valor en la posicion [{i},{j}]: ");
                    matrix[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            return matrix;
        }

        public void printMatrix(int[,] matrix)
        {
            Console.WriteLine("\nLa matriz es:\n");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("\t|");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($" \t{matrix[i, j]} ");
                }
                Console.WriteLine("\t|");
            }
        }

        // Average
        public double average(List<double> values)
        {
            double Total = 0;
            foreach (var item in values)
            {
                Total += item;
            }
            return Total/values.Count;
        }

        // Irregular Matrix
        public void irregularMatrix(int rows)
        {
            var matrix = new EjerciciosPropuestos.Matrix(rows);
            matrix.initializeVector(rows);

            Console.WriteLine("\nLa matriz es:\n");
            matrix.printMatrix();
        }

        // Employees attendance
        public void employeeAttendance(int count)
        {
            var employees = new EjerciciosPropuestos.EmpleyeeAttendance(count);
            employees.InitializeNonAttendanceMatrix();
            employees.PrintMatrix();
            employees.MaxNonAttandande();


        }

        // Change rows order in Matrix
        public int[,] changeRowsMatrixOrder(int[,] matrix, int numRowFrom, int numRowTo)
        {
            if (matrix.GetLength(0) > 1)
            {
                for (int i  = 0; i < matrix.GetLength(1); i++)
                {
                    int temp = matrix[numRowFrom - 1, i];
                    matrix[numRowFrom - 1, i] = matrix[numRowTo - 1, i];
                    matrix[numRowTo - 1, i] = temp;
                }
            }
            else
            {
                Console.WriteLine("La matriz cuenta con menos de dos filas");
            }
            
            return matrix;
        }

        // Print matrix vertex
        public void printMatrixVertex(int[,] matrix)
        {
            Console.WriteLine("\nLos vertices son: \n");

            Console.WriteLine($"\tVertice [0,0]: {matrix[0,0]}");
            Console.WriteLine($"\tVertice [0,{matrix.GetLength(1) -1}]: {matrix[0, matrix.GetLength(1) -1 ]}");
            Console.WriteLine($"\tVertice [{matrix.GetLength(0) - 1},0]: {matrix[matrix.GetLength(0) -1 ,0]}");
            Console.WriteLine($"\tVertice [{matrix.GetLength(0) -1},{matrix.GetLength(1) - 1}]: {matrix[matrix.GetLength(0) -1,matrix.GetLength(1) -1]}");
        }

        // Average Temperature
        public void AvgValue(int firstDimension, int secondDimension)
        {
            int _count = 0;
            string[] name = new string[firstDimension];
            double[,] values = new double[firstDimension,secondDimension];

            do
            {
                Console.Write($"\nIngrese el Nombre No. {_count+1 }: ");
                name[_count] = Console.ReadLine();

                int _count_2 = 0;
                do
                {
                    Console.Write($"\n\tValor No. {_count_2+1}: ");
                    values[_count,_count_2] = Convert.ToDouble(Console.ReadLine());
                    _count_2++;

                } while (_count_2 < secondDimension);

                _count++;
            } while (_count < firstDimension);

            Console.Clear();
            Console.WriteLine("\nValores Capturados\n");
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write($"\n\t{name[i]}: ");
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    Console.Write($"\t\t[{values[i,j]}] ");

                }
            }

            double val = 0;
            int max = 0;

            Console.WriteLine("\nValores Promedios\n");
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write($"\n\t{name[i]}: ");
                double Total = 0;
                for (int j = 0; j < values.GetLength(1); j++)
                {                
                    Total += values[i, j];
                }
                var prom = Total / values.GetLength(1);
                Console.WriteLine($"\t\t[{prom}]");

                if (prom >= val)
                {
                    val = prom;
                    max = i;

                }
            }

            Console.WriteLine("\nEl promedio mayor\n");
            Console.WriteLine($"\t\t\n{name[max]}: [{val}]");

        }
    }
}
