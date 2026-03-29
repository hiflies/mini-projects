namespace Mini_Projects.AssetTracking;

public class AssetTracking
{
    public static void Run()
    {
        var usa = new Office("USA", Currency.USD);
        var sweden = new Office("Sweden", Currency.SEK);
        var germany = new Office("Germany", Currency.EUR);
        // var switzerland = new Office("Switzerland", Currency.CHF);
        var tracker = new AssetTracker();

        tracker.AddAsset(new Smartphone("Motorola", "X3", 200, usa, DateTime.Now.AddMonths(-36 + 4)));
        tracker.AddAsset(new Smartphone("Motorola", "X3", 400, usa, DateTime.Now.AddMonths(-36 + 5)));
        // tracker.AddAsset(new Smartphone("Motorola", "X3", 400, switzerland, DateTime.Now.AddMonths(-36 + 5)));
        tracker.AddAsset(new Smartphone("Motorola", "X2", 400, usa, DateTime.Now.AddMonths(-36 + 10)));
        tracker.AddAsset(new Smartphone("Samsung", "Galaxy 10", 4500, sweden, DateTime.Now.AddMonths(-36 + 6)));
        tracker.AddAsset(new Smartphone("Samsung", "Galaxy 10", 4500, sweden, DateTime.Now.AddMonths(-36 + 7)));
        tracker.AddAsset(new Smartphone("Sony", "XPeria 7", 3000, sweden, DateTime.Now.AddMonths(-36 + 4)));
        tracker.AddAsset(new Smartphone("Sony", "XPeria 7", 3000, sweden, DateTime.Now.AddMonths(-36 + 5)));
        tracker.AddAsset(new Smartphone("Siemens", "Brick", 220, germany, DateTime.Now.AddMonths(-36 + 12)));
        tracker.AddAsset(new Computer("Dell", "Desktop 900", 100, usa, DateTime.Now.AddMonths(-38)));
        tracker.AddAsset(new Computer("Dell", "Desktop 900", 100, usa, DateTime.Now.AddMonths(-37)));
        tracker.AddAsset(new Computer("Lenovo", "X100", 300, usa, DateTime.Now.AddMonths(-36 + 1)));
        tracker.AddAsset(new Computer("Lenovo", "X200", 300, usa, DateTime.Now.AddMonths(-36 + 4)));
        tracker.AddAsset(new Computer("Lenovo", "X300", 500, usa, DateTime.Now.AddMonths(-36 + 9)));
        tracker.AddAsset(new Computer("Dell", "Optiplex 100", 1500, sweden, DateTime.Now.AddMonths(-36 + 7)));
        tracker.AddAsset(new Computer("Dell", "Optiplex 200", 1400, sweden, DateTime.Now.AddMonths(-36 + 8)));
        tracker.AddAsset(new Computer("Dell", "Optiplex 300", 1300, sweden, DateTime.Now.AddMonths(-36 + 9)));
        tracker.AddAsset(new Computer("Asus", "ROG 600", 1600, germany, DateTime.Now.AddMonths(-36 + 14)));
        tracker.AddAsset(new Computer("Asus", "ROG 500", 1200, germany, DateTime.Now.AddMonths(-36 + 4)));
        tracker.AddAsset(new Computer("Asus", "ROG 500", 1200, germany, DateTime.Now.AddMonths(-36 + 3)));
        tracker.AddAsset(new Computer("Asus", "ROG 500", 1300, germany, DateTime.Now.AddMonths(-36 + 2)));

        tracker.Display();
    }
}