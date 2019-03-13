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
             int CX = Console.CursorLeft+1;
             int CY = Console.CursorTop;

            int mus = Console.WindowHeight * Console.WindowWidth;
             Random rnd = new Random();
            int J = rnd.Next(0, mus);
            int count =0;
            int rand = rnd.Next(0, 15);

            for (int k = 0; k <rand; k++)
            {
                int x = rnd.Next(0, Console.WindowWidth);
                int y = rnd.Next(0, Console.WindowHeight);
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write('C');
                rand = rnd.Next(0, 15);
                count = k;
            }
            Lastposition(CX, CY);
            Console.WriteLine("Enter the number of characters C");
                int rez = Convert.ToInt32(Console.ReadLine());
            if (rez == (count + 1))
            {
                Console.WriteLine("You are a good player");
            }
            else
            {
                Console.Write("The number of characters C is equal to: " + (count + 1));
            }
            Console.ReadKey();
        }
        public static void Lastposition(int CX, int CY)
        {
          Console.SetCursorPosition(CX,CY);
        }

    }
}