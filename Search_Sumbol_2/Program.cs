using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Sumbol_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetNumber(0));
        }

        static int GetNumber(int n)
        {
            if (n == 10)
            {
                return 10;
            }
            return GetNumber(n + 1);
        }
    }
    }