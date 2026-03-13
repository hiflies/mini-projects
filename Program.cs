using Mini_Projects;

while (true)
{
    Console.WriteLine("Choose an app: ");
    Console.WriteLine("1. Product List");
    Console.Write("App: ");

    string data = Console.ReadLine().Trim();

    if (data.Trim() == "1")
    {
        ProductList.Run();
        continue;
    }
    else if (data.Trim() == "2")
    {
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Yapim asamasinda");
        Console.WriteLine("-------------------------------");
    }
    else
    {
        Console.WriteLine("-------------------------------");
        Console.WriteLine("You need to write a number from the list.");
    }
}