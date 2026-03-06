using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el número a descomponer: ");
        int numero = int.Parse(Console.ReadLine()!);

        int divisor = 2;

        Console.Write(numero + " = ");

        while (numero > 1)
        {
            if (numero % divisor == 0)
            {
                Console.Write(divisor);

                numero = numero / divisor;

                if (numero > 1)
                {
                    Console.Write(" x ");
                }   
            }
            else
            {
                divisor++;
            }
        }

        Console.ReadKey();
    }
}