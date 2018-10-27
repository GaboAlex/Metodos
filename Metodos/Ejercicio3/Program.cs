using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int acum = 1;
            for (int i = 0; i < 5; i++)
            {
                acum = acum * i;
            }
            Console.WriteLine(acum);
            Console.WriteLine(factorial(5));
        }
        public static int factorial(int nro)
        {
            if (nro == 1)
            {
                return 1;
            }
            else
            {
                return nro * factorial(nro - 1);
            }
        }
    }
}
