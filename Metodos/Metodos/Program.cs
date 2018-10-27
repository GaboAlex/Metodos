using System;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            float promedio = 0;
            Console.WriteLine("**Ingrese la cantidad de Calificaciones**");
            float N1 = float.Parse(Console.ReadLine());
            promedio = CalcularPromedio(N1);
            Console.WriteLine("El Promedio es: " + promedio + "\n");
            AproboDesaprobo(promedio);
        }
        public static float CalcularPromedio(float x)
        {
            float suma = 0;
            float promedio = 0;
            Console.WriteLine("**Ingrese las Calificaciones**\n");
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("La nota " + i + " es: ");
                int nota = int.Parse(Console.ReadLine());
                suma = suma + nota;
            }
            promedio = suma / x;
            return (promedio);
        }
        public static void AproboDesaprobo(float x)
        {
            if (x > 10.5)
            {
                Console.WriteLine("(: ****APROBADO****** :)");
            }
            else
            {
                Console.WriteLine("):  Desaprobado  :(");
            }
        }
    }
}
