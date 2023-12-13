using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение для a:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение для b:");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение для c:");
        int c = int.Parse(Console.ReadLine());

        if (IsPythagoreanTriple(a, b, c))
        {
            Console.WriteLine($"Тройка ({a}, {b}, {c}) является тройкой Пифагора.");
        }
        else
        {
            Console.WriteLine($"Тройка ({a}, {b}, {c}) не является тройкой Пифагора.");
        }
    }

    static bool IsPythagoreanTriple(int a, int b, int c)
    {
        return a * a + b * b == c * c;
    }
}
