using Mini_Projects.Exercises.Part1;
using Mini_Projects.Exercises.Part2;
using Mini_Projects.Utils;

namespace Mini_Projects.Exercises.Exercise2;

public class W13E2
{
    public static void Run()
    {
        while (true)
        {
            Console.Clear();
            ConsoleHelper.WriteInfo("Choose a week or 'q' to quit: ");
            Console.WriteLine("Part 1");
            Console.WriteLine("Part 2");
            Console.WriteLine("");
            Console.ResetColor();
            Console.Write("Part: ");

            string data = Console.ReadLine().Trim();

            if (data.ToLower() == "q")
            {
                break;
            }

            if (data == "1")
            {
                W13E2P1.Run();
                continue;
            }

            if (data == "2")
            {
                W13E2P2.Run();
                continue;
            }

            ConsoleHelper.WriteError("You need to write a number from the list.", true);
            
        }
    }
}