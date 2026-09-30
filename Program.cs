using System;

class Program
{
    static void Main()
    {
        int[] A = { 1, 2, 3, 4, 5, 6 };
        int n = A.Length;

        for (int i = 0; i < n / 2; i++)
        {
            int sum = A[i] + A[n - 1 - i];
            Console.WriteLine($"Сумма {i + 1}-го и {n - i}-го элементов: {sum}");
        }
    }
}
