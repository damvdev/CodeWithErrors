// Programa.cs
using System;

namespace CodeWithErrors
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = a + b;
            int d = 0; // Variable sin usar

            if (c > 10)
            {
                Console.WriteLine("La suma es mayor que 10");
            }
            else if (c > 5)
            {
                Console.WriteLine("La suma es mayor que 5");
            }
            else
            {
                Console.WriteLine("La suma es menor o igual que 5");
            }

            // Código duplicado
            Console.WriteLine("El resultado es: " + c);
            Console.WriteLine("El resultado es: " + c);

            // Método largo y complejo
            CalculateSomething(a, b);
        }

        static void CalculateSomething(int x, int y)
        {
            int result = x * y;
            if (result > 100)
            {
                Console.WriteLine("El resultado es mayor que 100");
            }
            else if (result > 50)
            {
                Console.WriteLine("El resultado es mayor que 50");
            }
            else if (result > 20)
            {
                Console.WriteLine("El resultado es mayor que 20");
            }
            else
            {
                Console.WriteLine("El resultado es menor o igual que 20");
            }
        }
    }
}
