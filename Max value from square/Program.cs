using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_value_from_square
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            
            int N = int.Parse(Console.ReadLine());
            int[,] max = new int[N,N];

            for (; x < N; x++)
            {
                for (; y < N; y++)
                {
                    max[x, y] = int.Parse(Console.ReadLine()); 
                }
                y = 0;
            }
                

        }
    }
}

/*
 *  string Text = "Pechkin! Pochtaljon Pechkin A";
            string[] separators = { ",", ".", "!", "?", ";", ":", " ", "/", "'", "|" };
            string[] a = Text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
*/