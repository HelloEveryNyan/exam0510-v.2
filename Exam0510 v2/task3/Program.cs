using System;

class Program
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
        return 0;
    }

    static void Main()
    {
        Console.Write("введите значение m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("введите значение n: ");
        int n = int.Parse(Console.ReadLine());

        int result = Ackermann(m, n);
        Console.WriteLine($"A(m,n) = {result}");
    }
}
