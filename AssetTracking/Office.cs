namespace Mini_Projects.AssetTracking;

public class Office
{
    public string Name { get; set; }
    public Currency Currency { get; set; }

    public Office(string name, Currency currency)
    {
        Name = name;
        Currency = currency;
    }
}