using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parni_Chusla
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter the number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] parni = new int[number];
            int[] nepar = new int[number];
            int count = 0;
            int countn = 0;
            for (int i = 0; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    parni[count] = i;
                    count++;
                }
                else
                {
                    nepar[countn] = i;
                    countn++;
                }
                
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("PARNI CHUSLA:");
            for (int i = 0; i < count; i++)
            {
                
                Console.Write(parni[i]+ ",");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Ne PARNII CUSLA:");
            for (int i = 0; i < countn; i++)
            {
                Console.Write("," + nepar[i]);
            }

            Console.ReadKey();

             
        }
    }
}
