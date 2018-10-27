using System;

namespace Ejercicio5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementar un método que me permita saber la suma de todos 
            //los números anteriores de un número ingresado por teclado.
            Console.WriteLine("+++Suma de Numeros Anteriores+++");
            Console.WriteLine("Ingrese un Numero");
            int n = int.Parse(Console.ReadLine());
            int suma = 0;
            for (int i = 0; i < n; i++)
            {
                suma = suma + (n - i);
            }
            Console.WriteLine(suma);
            Console.WriteLine("Por Metodo SUMAR "+Sumar(n));
        }
        public static int Sumar(int x)
        {
            int sum = 0;
            for (int i = 0; i < x; i++)
            {
                sum = sum + (x - i);
            }
            return (sum);
        }
    }
}
