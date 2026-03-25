namespace Mini_Projects.AssetTracking;

public class Smartphone: Asset
{
    public override string Type => "Smartphone";
    public Smartphone(string brand, string model, int price, Office office, DateTime purchaseDate) : base(brand, model, price, office, purchaseDate)
    {
    }
}