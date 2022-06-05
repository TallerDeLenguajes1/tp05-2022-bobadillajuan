using System;

namespace TallerDeLenguajes
{
    class Programa
    {
        static void Main(string[] args)
        {
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