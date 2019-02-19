using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string Commad;
            string Name = "";

            Console.WriteLine("Enter your name - SetName");
            Console.WriteLine("Number of times the name was output - DisplayName");
            Console.WriteLine("Set the console background color and symbols - SetColor");
            Console.WriteLine("Display of '#' characters with a name inside - DisplayBoxWithName");
            Console.WriteLine("Exiting the program - Exit");

            while (true)
            {
                Commad = Console.ReadLine();
                switch (Commad)
                {
                    case "SetName":

                        Name = Console.ReadLine();
                        Console.WriteLine($"Your name {Name}");
                        break;

                    case "DisplayName":

                        int age = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < age; i++)
                        {
                            Console.WriteLine($"Your name {Name}");
                        }
                        break;

                    case "SetColor":

                        Console.WriteLine("Black - 0");
                        Console.WriteLine("DarkBlue - 1");
                        Console.WriteLine("DarkGreen - 2");
                        Console.WriteLine("DarkCyan - 3");
                        Console.WriteLine("DarkRed - 4");
                        Console.WriteLine("DarkMagenta - 5");
                        Console.WriteLine("DarkYellow - 6");
                        Console.WriteLine("Gray - 7");
                        Console.WriteLine("DarkGray - 8");
                        Console.WriteLine("Blue - 9");
                        Console.WriteLine("Green - 10");
                        Console.WriteLine("Cyan - 11");
                        Console.WriteLine("Red - 12");
                        Console.WriteLine("Magenta - 13");
                        Console.WriteLine("Yellow - 14");
                        Console.WriteLine("White - 15");

                        Console.WriteLine("Set text color");
                        int Color = Convert.ToInt32(Console.ReadLine());
                        Console.ForegroundColor = (ConsoleColor)Color;

                        Console.WriteLine("Set background color");
                        Color = Convert.ToInt32(Console.ReadLine());
                        Console.BackgroundColor = (ConsoleColor)Color;
                        break;

                    case "DisplayBoxWithName":

                        string line = "";

                        for (int i = 0; i < Name.Length + 2; i++)
                        {
                            line += "#";
                        }

                        Console.WriteLine(line);
                        Console.WriteLine($"#{Name}#");
                        Console.WriteLine(line);
                        break;

                    case "Exit":

                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}