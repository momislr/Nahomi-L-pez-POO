using System;

namespace NumerosAleatorios
{
    public static class Inicio
    {
        public static void Main()
        {
            Random random = new Random();
            int sumaTotal = 100;

            Console.WriteLine();

            int numeroA = random.Next(0, 101);
            Console.WriteLine("Número A: " + numeroA);

            sumaTotal -= numeroA;

            int numeroB = random.Next(0, sumaTotal + 1);
            Console.WriteLine("Número B: " + numeroB);

            int numeroC = 100 - (numeroA + numeroB);
            Console.WriteLine("Número C: " + numeroC);

            for (int contador = 1; contador <= 100; contador++)
            {
                if (contador <= numeroA)
                {
                    string simbolo1 = "💗";
                    Console.WriteLine(contador + " -> " + simbolo1);
                }
                else if (contador <= numeroA + numeroB)
                {
                    string simbolo2 = "✨";
                    Console.WriteLine(contador + " -> " + simbolo2);
                }
                else
                {
                    string simbolo3 = "💚";
                    Console.WriteLine(contador + " -> " + simbolo3);
                }
            }
        }
    }
}
