using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementar Métodos que me permita saber de 3 números cual es el mayor y el menor
            Console.WriteLine("***Ingrese tres numero***\n");
            Console.WriteLine("Ingrese Primer numero: ");
            int n1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Segundo numero: ");
            int n2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Tercer numero: ");
            int n3 = Int32.Parse(Console.ReadLine());
            int Max = Mayor(n1, n2, n3);
            int Min = Menor(n1, n2, n3);
            Console.WriteLine("El numero Mayor es => " + Max);
            Console.WriteLine("El numero Menor es => " + Min);
        }
        public static int Mayor(int x1, int x2, int x3)
        {
            int mayor = 0;
            if (x1 > x2 && x1 > x3)
            {
                mayor = x1;
            }
            else if (x2 > x1 && x2 > x3)
            {
                mayor = x2;
            }
            else
            {
                mayor = x3;
            }
            return (mayor);
        }
        public static int Menor(int y1, int y2, int y3)
        {
            int menor = 0;
            if (y1 < y2 && y1 < y3)
            {
                menor = y1;
            }
            else if (y2 < y1 && y2 < y3)
            {
                menor = y2;
            }
            else
            {
                menor = y3;
            }
            return (menor);
        }
    }
}
