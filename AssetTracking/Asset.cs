namespace Mini_Projects.AssetTracking;

public abstract class Asset
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public double Price { get; set; }
    public Office Office { get; set; }
    public DateTime PurchaseDate { get; set; }
    public abstract string Type { get; }

    public Asset(string brand, string model, double price, Office office, DateTime purchaseDate)
    {
        Brand = brand;
        Model = model;
        Price = price;
        Office = office;
        PurchaseDate = purchaseDate;
    }
}

// todo office e gore sirala
// diger siralamalar
