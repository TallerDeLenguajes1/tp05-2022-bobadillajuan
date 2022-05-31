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
        } 
    }
}