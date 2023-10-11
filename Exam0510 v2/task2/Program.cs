using System;

class Program
{
    static int SumOfNaturals(int M, int N)
    {
        if (M > N)
        {
            return 0;
        }
        else
        {
            return M + SumOfNaturals(M + 1, N);
        }
    }

    static void Main()
    {
        Console.Write("введите значение M: ");
        int M = int.Parse(Console.ReadLine());

        Console.Write("введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        if (M <= N)
        {
            int result = SumOfNaturals(M, N);
            Console.WriteLine($"cумма натуральных чисел от {M} до {N} = {result}");
        }
    }
}
