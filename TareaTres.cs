using System;

public class Cuadrado_While
{
    public static void Main()
    {
        int tamaño = 3; 

        Console.Clear();

        Console.WriteLine(" DIBUJANDO DOS CUADRADOS ");
        Console.WriteLine("Presiona cualquier tecla para dibujar el primer cuadrado...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Primer cuadrado:");
        int i = 0;
        while (i < tamaño)
        {
            int j = 0;
            while (j < tamaño)
            {
                Console.Write("* ");
                j++;
            }
            Console.WriteLine();
            i++;
        }

        Console.WriteLine();
        Console.WriteLine("Presiona cualquier tecla para dibujar el segundo cuadrado...");
        Console.ReadKey();

        Console.Clear(); 

      
        Console.WriteLine("Segundo cuadrado:");
        int x = 0;
        while (x < tamaño)
        {
            int y = 0;
            while (y < tamaño)
            {
                Console.Write("* ");
                y++;
            }
            Console.WriteLine();
            x++;
        }

        Console.WriteLine();
        Console.WriteLine("¡Dibujo completado!");
        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
