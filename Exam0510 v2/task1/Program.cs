using System;

class Program
{
    static void PrintNaturalNumbers(int N)
    {
        if (N > 1)
        {
            Console.Write(N + ", ");
        }
        else
        {
            Console.Write(N);
        }

        if (N > 1)
        {
            PrintNaturalNumbers(N - 1);
        }
    }

    static void Main(string[] args)
    {
        Console.Write("введите значение N: ");
        if (int.TryParse(Console.ReadLine(), out int N))
        {
            Console.Write("N = " + N + " -> \"");
            PrintNaturalNumbers(N);
            Console.WriteLine("\"");
        }
    }
}