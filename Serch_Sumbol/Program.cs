using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serch_Sumbol
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int goodCount = r.Next(4, 15);
            for (int i = 0; i < Console.WindowWidth * Console.WindowHeight; i++)
            {
                Console.Write('S');
            }
           //Console.BackgroundColor = ConsoleColor.Red;

            int rectWidth = 10;
            int rectHeight = 10;
            int countInRaw = Console.WindowWidth / rectWidth;
            for (int i = 0; i < goodCount; i++)
            {
                int rectLeftUpX = rectWidth * (i % countInRaw);
                int rectLeftUpY = i / countInRaw;
                int x = r.Next(rectLeftUpX, rectLeftUpX + rectWidth);
                int y = r.Next(rectLeftUpY, rectLeftUpY + rectHeight);
                Console.SetCursorPosition(x,y);
                Console.Write('C');
            }

            Console.ReadKey();

        }
    }
}
