using Mini_Projects.Utils;

namespace Mini_Projects.AssetTracking;

public class AssetTracker
{
    private List<Asset> assets = new List<Asset>();

    public void AddAsset(Asset asset)
    {
        assets.Add(asset);
    }

    public void Display()
    {
        CurrencyConverter.FetchRates();
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkBlue;

        Console.Write("Office".PadRight(20));
        Console.Write("Asset".PadRight(20));
        Console.Write("Brand".PadRight(20));
        Console.Write("Model".PadRight(20));
        Console.Write("Price (USD)".PadRight(20));
        Console.Write("Price (Local)".PadRight(20));
        Console.WriteLine("Purchase Date".PadRight(15));

        Console.ResetColor();
        Console.BackgroundColor = ConsoleColor.DarkGray;

        

        Console.ForegroundColor = ConsoleColor.White;

        foreach (var asset in assets.OrderBy(o => o.Office.Name).ThenByDescending(o=>o.PurchaseDate))
        {
            DateTime expirationDate = asset.PurchaseDate.AddYears(3);
            DateTime today = DateTime.Now;
            TimeSpan remainingTime = expirationDate - today;
            double remainingMonths = remainingTime.TotalDays / 30;
            if (remainingMonths < 0)
            {
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else if (remainingMonths < 3)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }
            else if (remainingMonths < 6)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
            else
                Console.ForegroundColor = ConsoleColor.White;
            
            
            Console.Write(asset.Office.Name.PadRight(20));
            Console.Write(asset.Type.PadRight(20));
            Console.Write(asset.Brand.PadRight(20));
            Console.Write(asset.Model.PadRight(20));
            Console.Write(CurrencyConverter.Convert(asset.Price, asset.Office.Currency.ToString(), "USD").ToString("N2").PadRight(20));
            Console.Write(asset.Office.Currency + " " + asset.Price.ToString("N2").PadRight(20));
            Console.WriteLine(asset.PurchaseDate.ToString("yyyy-MM-d").PadRight(15));
        }

        Console.ResetColor();
        ConsoleHelper.AskEnterToContinue();
    }
}