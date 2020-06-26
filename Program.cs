using System;
using System.IO;

namespace AutoClicker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                if (Console.ReadKey().Key == ConsoleKey.L)
                {
                    Console.WriteLine("Do the thing!");
                    MouseOperations OpHandle = new MouseOperations();
                    MouseOperations.MouseEventFlags GoDown = MouseOperations.MouseEventFlags.LeftDown;
                    MouseOperations.MouseEvent(GoDown);
                    MouseOperations.MouseEventFlags AndUp = MouseOperations.MouseEventFlags.LeftUp;
                    MouseOperations.MouseEvent(AndUp);
                }
            }
        }
    }
}
