using System;
using task7PI;

namespace Task7PI
{
    class Program
    {
        static void Main()
        {
            Pythagorean pythagorean = new Pythagorean();
            Console.WriteLine("Введите значение для a:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение для b:")
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение для c:");
            int c = int.Parse(Console.ReadLine());

            if (pythagorean.IsPythagoreanTriple(a, b, c))
            {
                Console.WriteLine($"Тройка ({a}, {b}, {c}) является тройкой Пифагора.");
            }
            else
            {
                Console.WriteLine($"Тройка ({a}, {b}, {c}) не является тройкой Пифагора.");
            }
        }

       
    }
}
