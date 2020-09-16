using System;
using System.IO;
using System.Threading;
using System.Windows.Input;

namespace AutoClicker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("Press Enter to begin and Escape to exit \nYou cannot exit while the 1000 clicks are clicking");

            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Console.WriteLine("Enter the amount of times you want to click");
                int Count = Int32.Parse(Console.ReadLine());

                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Do the thing!");

                    MouseOperations OpHandle = new MouseOperations();

                    for (int i = 0; i < Count+1; i++)
                    {
                        MouseOperations.MouseEventFlags GoDown = MouseOperations.MouseEventFlags.LeftDown;
                        MouseOperations.MouseEvent(GoDown);
                        MouseOperations.MouseEventFlags AndUp = MouseOperations.MouseEventFlags.LeftUp;
                        MouseOperations.MouseEvent(AndUp);

                        Thread.Sleep(30);
                    }
                }

                Console.WriteLine("Done!");
            }
        }

        /*[System.ComponentModel.TypeConverter(typeof(System.Windows.Input.KeyConverter))]
        public enum Key

        public static bool IsKeyDown(System.Windows.Input.Key key);*/
    }
}
