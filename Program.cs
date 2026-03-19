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

        ConsoleHelper.WriteSeparator();
        continue;
    }
    else if (data == "2")
    {
        ConsoleHelper.WriteProgress();
        ExtraExercise1.Run();


        ConsoleHelper.WriteSeparator();
        continue;
    }
    else
    {
        ConsoleHelper.WriteError("You need to write a number from the list.", true);

    }

}