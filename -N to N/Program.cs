using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _N_to_N
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());
            for (; 10 <= N | N < 0;)
            {
                N = int.Parse(Console.ReadLine());
            }

            long K = N * (-1);
            for ( ;K<=N;K++)
            {
                Console.WriteLine(K);
            }
        }
    }
}
