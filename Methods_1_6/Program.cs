using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] numbers = { 10, 5, 9, 21 };
            Console.WriteLine(Max(numbers));

            Console.WriteLine(Max(new int[] { 5, 16, 4, 98 }));

            Console.WriteLine(Max(1,9,2,8,3,7,4,6,5)); ;
            */

            Console.WriteLine(GetNumber(0));

            Console.ReadLine();
        }

        static int Max(params int[] numbers)
        {
            int maxNumber = numbers[0] ;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (maxNumber < numbers[i])
                {
                    maxNumber = numbers[i];
                }
            }
            return maxNumber;
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
