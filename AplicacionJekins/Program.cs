using System;

namespace AplicacionJekins
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite el primer numero");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el primer numero");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("La suma es: " + suma(a,b) + "Si es 0 es por que algo hizo mal");
        }

        public  static int suma(int valor1, int valor2)
        {
            if (valor1 <= 0 || valor2 <= 0)
            {
                return 0;
            }

            return valor1 + valor2;
        }
    }
}
