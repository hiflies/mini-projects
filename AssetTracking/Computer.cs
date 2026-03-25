namespace Mini_Projects.AssetTracking;

public class Computer : Asset
{
    public override string Type => "Computer";

    public Computer(string brand, string model, int price, Office office, DateTime purchaseDate) : base(brand, model, price, office, purchaseDate)
    {
    }
}