using System;
using System.Diagnostics;
using System.Threading;

namespace WindowsAutoShutDowner
{
    class WindowsAutoShutDowner
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            for (int i = 0; i < Console.BufferWidth; i++)
            {
                Console.Write("-");
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            string greeting = "Hello, " + Environment.UserName;
            Console.SetCursorPosition((Console.BufferWidth / 2) - greeting.Length + 2, 1);
            Console.WriteLine(greeting);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            for (int i = 0; i < Console.BufferWidth; i++)
            {
                Console.Write("-");
            }

            string computerName = Environment.MachineName;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter the minutes to shutdown ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(computerName + ": ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            int time = Int32.Parse(Console.ReadLine());

            int remainingTime = time + 1;
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < time; i++)
            {
                remainingTime--;
                Console.SetCursorPosition(0, 5);
                Console.WriteLine("Remaining time to Shut Down: {0} minutes", remainingTime);
                Thread.Sleep(1000 * 60);
            }

            Console.ForegroundColor = ConsoleColor.Blue;

            if (DateTime.Now.Hour > 21)
            {
                Console.WriteLine("Good night!");
            }
            else
            {
                Console.WriteLine("");
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Process.Start("shutdown", "/s /t 1");
        }
    }
}
