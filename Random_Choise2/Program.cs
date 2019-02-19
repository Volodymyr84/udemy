using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Choise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 10;
            for (int t = 0; k > t; t++)
            {
                Console.Write("Enter the you choice: Kurnuca;Nozhuci;Papir;0;1;2");
                int Choice = Convert.ToInt32(Console.ReadLine());
                Random random = new Random();
                int answerCPU = random.Next(3); //метод нам вернет случайное число от 0 до 2
                Console.WriteLine("CPU Choice: " + answerCPU);



                if (Choice == answerCPU)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Nicuja");
                }

                if (Choice == 0 & answerCPU == 1 | Choice == 1 & answerCPU == 2 | Choice == 2 & answerCPU == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    
                    Console.WriteLine("User Vin!!!");
                } //UV
                if (Choice == 1 & answerCPU == 0 | Choice == 2 & answerCPU == 1 | Choice == 0 & answerCPU == 2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("CPU Vin!!!");
                }

                Console.WriteLine("0-1, 1-2, 2-0 User Vin!!!");
            }
            Console.ReadKey();
        }
    }
}
