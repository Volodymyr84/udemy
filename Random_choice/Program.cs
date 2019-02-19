using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_choice
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter the you choice: Kurnuca;Nozhuci;Papir: ");
            string Choice = Console.ReadLine();
            Random random = new Random();
            int answerCPU = random.Next(3); //метод нам вернет случайное число от 0 до 2

            switch (answerCPU)
            {
                case 0:
                    Console.WriteLine("CPU Answer is Kurnuca");
                    break;
                case 1:
                    Console.WriteLine("CPU Answer is Nozhuci");
                    break;
                case 2:
                    Console.WriteLine("CPU Answer is Papir");
                    break;
            }
            int Uansver = 6;
            switch (Choice)
            {
                case "Kurnuca":
                    Uansver = 0;
                    break;
                case "Nozhuci":
                    Uansver = 1;
                    break;
                case "Papir":
                    Uansver = 2;
                    break;
                default:
                    Console.WriteLine("Nemae takogo parametru");
                    break;

            }



            if (Uansver == answerCPU)
            {
                Console.WriteLine("Nicuja");
            }
            if (Uansver == 0 & answerCPU == 1 | Uansver == 1 & answerCPU == 2 | Uansver == 2 & answerCPU == 0)
            {
                Console.WriteLine("User Vin!!!");
            } //UV
            else
                Console.WriteLine("CPU Vin!!!");
           
            Console.ReadKey();
        }
    }
}
