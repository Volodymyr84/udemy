using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasck_325
{
    class Program
    {
        /*
         * С помощью циклов организуйте обработку команд. В программе должны быть следующие команды:

           + SetName (устанавливает имя)

           + DisplayName (запрашивает число, и выводит столько раз имя)

            SetColor (установка цвета фона консоли и символов)

            DisplayBoxWithName (отображение полого квадрата из символов ‘#’ с надписью имени внутри)
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the command SetName for set you name");
            Console.WriteLine("Enter the command DisplayName for display how many times must be displayed You name");
            Console.WriteLine("Enter the command SetColor set console and text color");
            Console.WriteLine("Enter the command DisplayBoxWithName display of a hollow square of ‘#’ characters with the inscription of the name inside");
            Console.WriteLine("Enter the command Reset for reset color in CMD");
            Console.WriteLine("Enter the command Exit for exit the program");

            string Command;

            string Name = "";

            while (true)
            {
                Console.WriteLine("Please write your choice! ");
                Command = Console.ReadLine();

                switch (Command)
                {
                    case "SetName":
                        Console.WriteLine("Enter You Name");
                        Name = Console.ReadLine();
                        break;
                    case "DisplayName":
                        if (Name == "")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("To get started, enter your name!");
                        }
                        else
                        {
                            Console.WriteLine("Enter the number of repetitions (Example: 1,5,7,10)");
                            int cout = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < cout; i++)
                            {
                                Console.WriteLine(Name);
                            }
                        }
                        Console.ResetColor();
                        break;
                    case "SetColor":
                        Console.WriteLine("Please make your choice as shown in the example:");
                        Console.WriteLine("Black = 0,DarkBlue = 1,DarkGreen = 2,DarkCyan = 3,DarkRed = 4,DarkMagenta = 5,DarkYellow = 6,Gray = 7,DarkGray = 8,Blue = 9,Green = 10,Cyan = 11,Red = 12,Magenta = 13,Yellow = 14,White = 15;");
                        Console.WriteLine("Enter value for Foreground Color");
                        int color = Convert.ToInt32(Console.ReadLine());
                        Console.ForegroundColor = (ConsoleColor)color;
                        Console.WriteLine("Enter value for Background Color ");
                        color = Convert.ToInt32(Console.ReadLine());
                        Console.BackgroundColor = (ConsoleColor)color;
                        break;
                    case "Reset":
                        Console.ResetColor();
                        break;
                    case "Exit":
                        Environment.Exit(0);
                        break;
                    case "DisplayBoxWithName":

                        if (Name == "")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("To get started, enter your name!");
                            Console.ResetColor();
                        }
                        
                        else
                        { 
                        string frame = "";
                        for (int i = 0; i < Name.Length + 2; i++)
                        {
                            frame += "#";
                        }
                        Console.WriteLine(frame);
                        Console.WriteLine($"#{Name}#");
                        Console.WriteLine(frame);
                        }
                        break;
                }
            }

        }
    }
}

