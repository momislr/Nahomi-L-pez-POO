using System;

public class Program
{
    static public void Main ()
    {

  int filas, i, a;
        Console.Write(" Ingresa el lado del triangulo ");
        filas    =int.Parse(Console.ReadLine());
        Console.WriteLine(" ");

        for (i = 1; i <= filas; i++)
        {
            for (a = 1; a <= i; a++)
            {
                Console.Write("* ");
            }

            Console.WriteLine();
        }
        
    }
}
