using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese orden de la matriz: ");
        int n = int.Parse(Console.ReadLine()!);

        int[,] matriz = new int[n, n];

        int suma = 0;
        int max = int.MinValue;
        int min = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = (i + 1) - j;

                suma += matriz[i, j];

                if (matriz[i, j] > max)
                    max = matriz[i, j];

                if (matriz[i, j] < min)
                    min = matriz[i, j];
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine($"\nLa sumatoria es:  {suma}");
        Console.WriteLine($"El valor máximo es: {max}");
        Console.WriteLine($"El valor mínimo es: {min}");
    }
}