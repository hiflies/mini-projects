using System;
namespace Mini_Projects
{
    public class ProductLists
    {
        public static void Run()
        {
            while (true)
            {
                Console.WriteLine("Choose a version or 'q' to quit: ");
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("1. Product List Checkpoint 1");
                Console.WriteLine("2. Product List Checkpoint 2");
                Console.WriteLine("");

                Console.ResetColor();
                Console.Write("Version: ");

                string data = Console.ReadLine().Trim();

                if (data.ToLower() == "q")
                {
                    break;
                }

                if (data == "1")
                {
                    ProductListV1.Run();


                    Console.WriteLine("-------------------------------");
                    continue;
                }
                else if (data == "2")
                {
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("Yapim asamasinda");
                    Console.WriteLine("-------------------------------");
                    ProductListV2.Run();


                    Console.WriteLine("-------------------------------");
                    continue;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("You need to write a number from the list.");
                    Console.ResetColor();

                }
            }

        }
    }
}

