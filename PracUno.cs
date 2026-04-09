using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa un número: ");
        int x = int.Parse(Console.ReadLine());

        for (int i = 0; i <= x; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i + " es par");
            }
            else
            {
                Console.WriteLine(i + " es impar");
            }
        }
    }
}
