using Mini_Projects.AssetTracking;
using Mini_Projects.Exercises;
using Mini_Projects.ProductList;
using Mini_Projects.ProductList.V2;
using Mini_Projects.Utils;

//======================================
// IAvailability icinde isAvailable functionu barindiracak
// Noticeboardda availiblity provider listesi olacak
// Noriceboard getAvailableList functioni ile filtreleyip donecek
//======================================


// var telefon = new Product("","",2);
// telefon.Color = "x";
// Console.WriteLine(telefon.Color);
// Console.WriteLine(telefon.Color);

// return;

while (true)
{
    Console.Clear();
    Console.WriteLine("Choose an app: ");
    Console.BackgroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("1. Product List");
    Console.WriteLine("2. Exercises");
    Console.WriteLine("3. Asset Tracking");
    Console.ResetColor();
    Console.Write("App: ");

    string data = Console.ReadLine().Trim();

    if (data == "1")
    {
        ProductLists.Run();
        continue;
    }

    if (data == "2")
    {
        Exercises.Run();
        continue;
    }

    if (data == "3")
    {
        AssetTracking.Run();
        continue;
    }

    ConsoleHelper.WriteError("You need to write a number from the list.", true);
}