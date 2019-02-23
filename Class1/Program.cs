using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            Home home1 = new Home('#',ConsoleColor.Yellow,10,new Vector2(10, 10));
            Home home2 = new Home('#', ConsoleColor.Red, 10, new Vector2(10, 15));
            home1.Render();
            home2.Render();

            Console.ReadKey();
        }
    }

    class Home
    {
        public char Symbol;
        public ConsoleColor Color;
        public int CurrentGuests;
        public readonly int MaxGuests;
        public Vector2 Position;

        public Home(char symbol, ConsoleColor color, int maxGuests,Vector2 position)
        {
            Symbol = symbol;
            Color = color;
            MaxGuests = maxGuests;
            Position = position;
        }

        public void AddGuest()
        {
            if (CurrentGuests + 1 > MaxGuests) return;

            CurrentGuests += 1;
        }

        public void Render()
        {
            Console.SetCursorPosition(Position.X,Position.Y);
            Console.ForegroundColor = Color;
            Console.Write(Symbol);
        }
    }
    class Vector2
    {
        public int X, Y;
        public Vector2(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
