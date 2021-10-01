using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painter
{
    public static class Turtle
    {
        public static int x = 0;
        public static int y = 0;
        public static int direction = 1;
    }
    class Program
    {
        private static void JumpTo(int gorizontal, int vertical)
        {
            Console.SetCursorPosition(gorizontal, vertical);
            Turtle.x = gorizontal;
            Turtle.y = vertical;
            Console.Write("█");
        }
        private static void GoStraight(int step)
        {
            step = step - 1;
            switch (Turtle.direction)
            {
                case 0:
                    for (int i = 0; i < step; i++)
                    {
                        Turtle.y = Turtle.y - 1;
                        Console.SetCursorPosition(Turtle.x, Turtle.y);
                        Console.Write("█");
                    }
                    break;
                case 1:
            
                for (int i = 0; i < step; i++)
                {
                    Turtle.x = Turtle.x + 1;
                    Console.SetCursorPosition(Turtle.x, Turtle.y);
                    Console.Write("█");
                }
                    break;
                case 2:
            
                for (int i = 0; i < step; i++)
                {
                    Turtle.y = Turtle.y + 1;
                    Console.SetCursorPosition(Turtle.x, Turtle.y);
                    Console.Write("█");
                }
                    break;
                case 3:
            
                for (int i = 0; i < step; i++)
                {
                    Turtle.x = Turtle.x - 1;
                    Console.SetCursorPosition(Turtle.x, Turtle.y);
                    Console.Write("█");
                }
                    break;
            }
        }
        private static void TurnLeft()
        {
            if (Turtle.direction > 0)
            {
                Turtle.direction = Turtle.direction - 1;
            }
            else
            {
                Turtle.direction = 3;
            }
        }
        private static void TurnRight()
        {
            if (Turtle.direction < 3)
            {
                Turtle.direction = Turtle.direction + 1;
            }
            else
            {
                Turtle.direction = 0;
            }
        }
        private static void TurnTo180()
        {
            if (Turtle.direction < 3)
            {
                Turtle.direction = Turtle.direction + 1;
            }
            else
            {
                Turtle.direction = 0;
            }

            if (Turtle.direction < 3)
            {
                Turtle.direction = Turtle.direction + 1;
            }
            else
            {
                Turtle.direction = 0;
            }
        }
        static void Main()
        {
            Console.CursorVisible = false;
            
            Console.ForegroundColor = ConsoleColor.Red;
            JumpTo(57, 10);
            TurnRight();
            GoStraight(4);
            TurnRight();
            GoStraight(2);

            Console.ForegroundColor = ConsoleColor.Green;
            JumpTo(59, 10);
            TurnTo180();
            GoStraight(3);
            TurnRight();
            GoStraight(4);
            TurnRight();
            GoStraight(3);
            TurnRight();
            GoStraight(4);
            Console.ForegroundColor = ConsoleColor.Cyan;
            JumpTo(63, 10);
            TurnTo180();
            GoStraight(4);
            TurnLeft();
            GoStraight(3);
            TurnLeft();
            GoStraight(3);
            TurnLeft();
            GoStraight(3);
            Console.Read();
        }
    }
}
