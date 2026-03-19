using System;
namespace Mini_Projects
{
    public class ConsoleHelper
    {
        public static void WriteInfo(string message, bool hasSeparator = false)
        {
            Write(message, ConsoleColor.Blue, hasSeparator);
        }

        public static void WriteSuccess(string message, bool hasSeparator = false)
        {
            Write(message, ConsoleColor.Green, hasSeparator);
        }

        public static void WriteError(string message, bool hasSeparator = false)
        {
            Write(message, ConsoleColor.Red, hasSeparator);
        }

        public static void WriteWarning(string message, bool hasSeparator = false)
        {
            Write(message, ConsoleColor.Yellow, hasSeparator);
        }

        public static void WriteProgress()
        {
            WriteSeparator();
            Write("yapim asamasinda", ConsoleColor.DarkCyan, true);
        }

        public static void Write(string message, ConsoleColor color, bool hasSeparator = false)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();

            if (hasSeparator)
            {
                WriteSeparator();
            }
        }

        public static void WriteSeparator()
        {
            Console.WriteLine("-----------------------------------");
        }

    }

}
