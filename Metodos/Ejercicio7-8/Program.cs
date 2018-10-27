using System;

namespace Ejercicio7_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementar un método que calcule la potencia de un número, ingresando por teclado la base y el exponente
            Console.WriteLine("POTENCIA DE UN NUMERO");
            Console.WriteLine("Ingrese la base: ");
            int bas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el exponente: ");
            int expo = int.Parse(Console.ReadLine());
            double result = 0;
            result = Math.Pow(bas, expo);
            Console.WriteLine("El exponenten de " + bas + " es: " + result);
            Console.WriteLine("El resultado es: " + Potencia(bas, expo));
        }
        public static double Potencia(int n1, int n2)
        {
            double respuesta = 1;
            for (int i = 0; i < n2; i++)
            {
                respuesta = respuesta * n1;
            }
            return (respuesta);
        }
    }
}
