using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa un año: ");
        int año = int.Parse(Console.ReadLine());

        int contador = 0;

        for (int i = año + 1; contador < 50; i++)
        {
            if ((i % 4 == 0 && i % 100 != 0) || (i % 400 == 0))
            {
                Console.WriteLine(i + " es bisiesto");
                contador++;
            }
        }
    }
}
