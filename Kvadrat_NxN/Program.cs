using System;

namespace Kvadrat_NxN
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            if (1 <= N & N <= 80)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        Console.Write('*');
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
