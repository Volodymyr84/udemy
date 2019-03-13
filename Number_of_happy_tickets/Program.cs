using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_of_happy_tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Билет с шестизначным номером считается счастливым, если сумма трёх первых цифр равна сумме трёх последних цифр.
            //Посчитать, сколько существует счастливых билетов.
            //Начальные данные: нет. Вывод результата: количество счастливых билетов.
            /*
             A ticket with a six-digit number is considered happy, if the sum of the first three digits is equal to the sum of the last three digits.
                Calculate how many happy tickets there are.
                Initial data: no.  Displaying the result: the number of lucky tickets.
            */
            
            int  a, b, c,i,d,e,f;
            int count = 0;
            for (i=0; i <= 999999; i++)
            {
                int Smax = i / 1000;
                a = Smax / 100;
                b = Smax / 10 % 10;
                c = Smax % 10;
                int SUMAX = a + b + c;

                int Smin = i % 1000;
                d = Smin / 100;
                e = Smin / 10 % 10;
                f = Smin % 10;
                int SUMIN = d + e + f;

                if (SUMAX == SUMIN)
                    count++;
            }
            Console.WriteLine(count);
            Console.ReadKey();

}
}
}
