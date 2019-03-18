using System;

namespace Inversion
{
    class Program
    {
        static void Main(string[] args)
        {
            long inver = long.Parse(Console.ReadLine());

           long rez = inver % 2;
            if (rez ==1 | rez==-1)
            {
                inver = inver * 2;
            }
            else
                inver = inver / 2;

            Console.WriteLine(inver);
        }
    }
}



/*
Enter 1 number.
Multiply it by 2 if it is odd,
or divide it by 2 if it is even.

Initial data: 1 number.
Range of values: a number from -1018 to 1018.
Output: 1 number - the result of division or multiplication.
  
 */
