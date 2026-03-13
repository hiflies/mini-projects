using Mini_Projects;

while (true)
{
    Console.WriteLine("Choose an app: ");
    Console.WriteLine("1. Product List");
    Console.WriteLine("2. Extra Exercise 1");
    Console.Write("App: ");

    string data = Console.ReadLine().Trim();

    if (data == "1")
    {
        ProductList.Run();


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
        Console.WriteLine("-------------------------------");
        Console.WriteLine("You need to write a number from the list.");
    }

}