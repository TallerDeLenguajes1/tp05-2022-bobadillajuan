using System;

namespace TallerDeLenguajes
{
    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Ejercicio 02 _ Calculadora -----\n\n\n");

            int controlador;
            double numeroUno, numeroDos, resultado;
            do
            {
            Console.WriteLine("Por favor, selecciones una operación: \n1) Sumar.\n2) Restar.\n3) Multiplicar.\n4) Dividir.\n5) Salir.\n");
            controlador = Convert.ToInt32(Console.ReadLine());

            switch (controlador)
            {
                case 1:
                    Console.WriteLine("\nIngrese el primer numero: ");
                    numeroUno = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\nIngrese el segundo numero: ");
                    numeroDos = Convert.ToDouble(Console.ReadLine());
                    resultado = numeroUno + numeroDos;
                    Console.WriteLine("\nResultado: " + resultado + "\n");
                break;
                case 2:
                    Console.WriteLine("\nIngrese el primer numero: ");
                    numeroUno = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\nIngrese el segundo numero: ");
                    numeroDos = Convert.ToDouble(Console.ReadLine());
                    resultado = numeroUno - numeroDos;
                    Console.WriteLine("\nResultado: " + resultado + "\n");
                break;
                case 3:
                    Console.WriteLine("\nIngrese el primer numero: ");
                    numeroUno = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\nIngrese el segundo numero: ");
                    numeroDos = Convert.ToDouble(Console.ReadLine());
                    resultado = numeroUno * numeroDos;
                    Console.WriteLine("\nResultado: " + resultado + "\n");
                break;
                case 4:
                    Console.WriteLine("\nIngrese el primer numero: ");
                    numeroUno = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\nIngrese el segundo numero: ");
                    numeroDos = Convert.ToDouble(Console.ReadLine());
                    resultado = numeroUno / numeroDos;
                    Console.WriteLine("\nResultado: " + resultado + "\n");
                break;
                case 5:
                    Console.WriteLine("\nSalió del programa correctamente");
                break;
                default:
                    Console.WriteLine("\nIngrese la opcion nuevamente: \n");
                break;
            }

            
            } while (controlador != 5);
            Console.WriteLine("----- Ejercicio 03 _ Calculadora Versión 2-----\n\n\n");

            double operadorMath, numeroUnoMath, numeroDosMath;

            Console.WriteLine("\nPor favor, ingrese un número: \n");
            operadorMath = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Valor absoluto: " + Math.Abs(operadorMath));
            Console.WriteLine("Cuadrado: " + Math.Pow(operadorMath, 2));
            Console.WriteLine("Raíz Cuadrada: " + Math.Sqrt(operadorMath));
            Console.WriteLine("Seno: " + Math.Sin(operadorMath));
            Console.WriteLine("Coseno: " + Math.Cos(operadorMath));
            Console.WriteLine("Redondeado: " + (int)Math.Round(operadorMath));

            Console.WriteLine("\nIngrese dos operadores para determinar el mayor de ellos:\n");
            Console.WriteLine("\nPrimer operador: ");
            numeroUnoMath = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nSegundo operador: ");
            numeroDosMath = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("El operador " + Math.Min(numeroUnoMath, numeroDosMath) + " es el menor");
            Console.WriteLine("El operador " + Math.Max(numeroUnoMath, numeroDosMath) + " es el mayor");

        } 
    }
}