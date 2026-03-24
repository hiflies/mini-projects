using Mini_Projects.ProductList.V1;
using Mini_Projects.ProductList.V2;
using Mini_Projects.Utils;

namespace Mini_Projects.ProductList
{
    public class ProductLists
    {
        public static void Run()
        {
            while (true)
            {
                Console.Clear();
                ConsoleHelper.WriteInfo("Choose a version or 'q' to quit: ");
                //Console.WriteLine("Choose a version or 'q' to quit: ");
                //Console.BackgroundColor = ConsoleColor.Blue;
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
                    //Console.ForegroundColor = ConsoleColor.Cyan;
                    //Console.WriteLine("-------------------------------");
                    ConsoleHelper.WriteProgress();
                    //Console.WriteLine("Yapim asamasinda");
                    //Console.WriteLine("-------------------------------");
                    Console.ResetColor();
                    ProductListV2.Run();


                    Console.WriteLine("-------------------------------");
                    continue;
                }
                else
                {
                    ConsoleHelper.WriteError("You need to write a number from the list.", true);
                    //Console.ForegroundColor = ConsoleColor.DarkRed;
                    //Console.WriteLine("-------------------------------");
                    //Console.WriteLine("You need to write a number from the list.");
                    //Console.ResetColor();

                }
            }

        }
    }
}

