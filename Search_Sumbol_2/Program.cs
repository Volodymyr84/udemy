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


            Console.ReadKey();
                        
        }

    }
}