using Mini_Projects.Utils;

namespace Mini_Projects.Exercises.Part1;

public class W13E2P1
{
    public static void Run()
    {
        Console.Clear();
        Person ada = new Person("Ada Lovelace", "24 Maddox St. London W1S 2QN");
        Person esko = new Person("Esko Ukkonen", "Mannerheimintie 15 00100 Helsinki");

        Console.WriteLine(ada.Show());
        Console.WriteLine(esko.Show());
        
        ConsoleHelper.AskEnterToContinue();
    }
}