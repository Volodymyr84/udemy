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
            
            for (int i = 0; i < Console.WindowHeight* Console.WindowWidth; i++)
            {
                Console.Write('S');
            }
            int mus = Console.WindowHeight * Console.WindowWidth;
             Random rnd = new Random();
            int J = rnd.Next(0, mus);

            // int x = rnd.Next(Console.WindowHeight, Console.WindowWidth);
            //int y = rnd.Next(Console.WindowHeight, Console.WindowWidth);

            int rand = rnd.Next(0, 15);
            for (int k = 0; k <rand; k++)
            {
                //int x = 9;
                //int y = 10;
                int x = rnd.Next(Console.WindowHeight, Console.WindowWidth);
                int y = rnd.Next(Console.WindowHeight, Console.WindowWidth);

                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write('C');
                rand = rnd.Next(0, 15);
            }

            Console.ReadKey();
                        
        }

    }
}