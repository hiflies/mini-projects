using Mini_Projects;

while (true)
{
    Console.WriteLine("Choose an app: ");
    Console.BackgroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("1. Product List");
    Console.WriteLine("2. Extra Exercise 1");
    Console.WriteLine("");

    Console.ResetColor();
    Console.Write("App: ");

    string data = Console.ReadLine().Trim();

    if (data == "1")
    {
        ProductLists.Run();


        Console.WriteLine("-------------------------------");
        continue;
    }
    else if (data == "2")
    {
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Yapim asamasinda");
        Console.WriteLine("-------------------------------");
        ExtraExercise1.Run();


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