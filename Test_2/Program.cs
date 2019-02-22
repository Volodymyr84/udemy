using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Please enter the password: ");
            string pass = Console.ReadLine();
            while (pass != "1234")
            {
                Console.Write("Please enter the correct password: ");
                pass = Console.ReadLine();
            }
            Console.WriteLine("Congratulations, you entered the correct password!");
            
            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.Write("Please enter the password: ");
            string pass = Console.ReadLine();
            int count = 0;
            while (pass != "1234"&&count<4)
            {
                Console.Write("Please enter the correct password: ");
                pass = Console.ReadLine();
                count++;
            }
            if (pass == "1234")
                Console.WriteLine("Congratulations, you entered the correct password!");
            else
                Console.WriteLine("Your attempts have exceeded five times. Goodbye!");
            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///Пользователь вводит сколько ему лет. 
            ///Программа, с помощью цикла for, должна поздравить его с днём рождения столько раз, сколько ему лет.
            
            Console.Write("Please enter your age: ");
            int age =Convert.ToInt32(Console.ReadLine());
            for (int i=0;i<age;i++)
            {
                Console.WriteLine("Happy birthday!");
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///С помощью циклов организуйте обработку команд. 
            ///В программе должны быть следующие команды:
            ///SetName (устанавливает имя)
            ///DisplayName (запрашивает число, и выводит столько раз имя)
            ///SetColor (установка цвета фона консоли и символов)
            ///DisplayBoxWithName (отображение полого квадрата из символов ‘#’ с надписью имени внутри)
            ///Решение тут https://gist.github.com/mitaytds/b0f7566cb63542a1c6be660a7ff38c8c
            */

            string Command;

            string Name = "";

            while (true)
            {

                Command = Console.ReadLine();

                switch (Command)
                {
                    case "SetName":
                        Name = Console.ReadLine();
                        break;
                    case "DisplayName":
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine(Name);
                        }
                        break;
                }
            }

           // Console.ReadKey();
        }
    }
}
