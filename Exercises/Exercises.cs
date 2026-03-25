using Mini_Projects.ProductList.V1;
using Mini_Projects.ProductList.V2;
using Mini_Projects.Utils;

namespace Mini_Projects.Exercises;

public class Exercises
{
    public static void Run()
    {
        while (true)
        {
            Console.Clear();
            ConsoleHelper.WriteInfo("Choose a week or 'q' to quit: ");
            //Console.WriteLine("Choose a version or 'q' to quit: ");
            //Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Week 11");
            Console.WriteLine("Week 13");
            Console.WriteLine("");
            Console.ResetColor();
            Console.Write("Week: ");

            string data = Console.ReadLine().Trim();

            if (data.ToLower() == "q")
            {
                break;
            }

            if (data == "11")
            {
                ExtraExerciseW11.Run();
                continue;
            }

            if (data == "13")
            {
                Console.Clear();
                ExtraExerciseW13.Run();
                continue;
            }

            ConsoleHelper.WriteError("You need to write a number from the list.", true);
        }
    }
}