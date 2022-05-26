using System;

namespace TallerDeLenguajes
{
    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Ejercicio 01 -----\n\n\n");


            Console.WriteLine("Ingrese un numero");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num > 0){
            string n = num.ToString();
            n.ToCharArray();
            for (int i = n.Length-1; i>=0; i--){
            Console.Write("{0}",n[i]);
            }
            }else{
                Console.WriteLine("\nNumero invalido.");
            }
        } 
    }
}