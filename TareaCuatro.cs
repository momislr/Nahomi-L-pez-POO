using System;

public class Program
{
    static public void Main ()
    {
        
        int a, b, c, temp;

        Console.Write("Ingresa el primer número: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        b = int.Parse(Console.ReadLine());

        Console.Write("Ingresa el tercer número: ");
        c = int.Parse(Console.ReadLine());

       
        if (a > n)
        {
            temp = a;
            a = b;
            b = temp;
        }

        if (a > c)
        {
            temp = a;
            a = c;
            c = temp;
        }

        if (b > c)
        {
            temp = b;
            b = c;
            c = temp;
        }

        Console.WriteLine("Números ordenados de menor a mayor:");
        Console.WriteLine(a + ", " + b + ", " + c);
    }
}
