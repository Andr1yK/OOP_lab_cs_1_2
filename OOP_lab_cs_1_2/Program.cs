using System;

class Program
{
    static void Main()
    {
        int i, N;
        double S;

        Console.Write("N = ");
        N = int.Parse(Console.ReadLine());

        S = 0;
        i = N;

        while (i <= 22)
        {
            S += Math.Sqrt(i * i + N * N) / i;
            i++;
        }
        Console.WriteLine($"S = {S} (while)");

        S = 0;
        i = N;

        do
        {
            S += Math.Sqrt(i * i + N * N) / i;
            i++;
        } while (i <= 22);
        Console.WriteLine($"S = {S} (do ... while)");

        S = 0;

        for (int j = N; j <= 22; j++)
        {
            S += Math.Sqrt(j * j + N * N) / j;
        }
        Console.WriteLine($"S = {S} (for i++)");

        S = 0;

        for (int j = 22; j >= N; j--)
        {
            S += Math.Sqrt(j * j + N * N) / j;
        }
        Console.WriteLine($"S = {S} (for i--)");
    }
}