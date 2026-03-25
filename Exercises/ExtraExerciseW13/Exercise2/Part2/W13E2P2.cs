using Mini_Projects.Utils;

namespace Mini_Projects.Exercises.Part2;

public class W13E2P2
{
    public static void Run()
    {
        Console.Clear();
        Student ollie = new Student("Ollie", "6381 Hollywood Blvd. Los Angeles 90028");
        Console.WriteLine(ollie.Show());
        Console.WriteLine("Study credits " + ollie.Credits());
        ollie.Study();
        Console.WriteLine("Study credits " + ollie.Credits());
        ConsoleHelper.AskEnterToContinue();
    }
}