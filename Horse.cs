public class Horse : Vehicle, INeedFuel
{
    public string FuelType { get; set; }
    public int FuelTotal { get; set; }
    public Horse(string name, string color, int passengers, string fuelType) : base(name, color, passengers, false)
    {
        FuelType = fuelType;
        FuelTotal = 10;
    }

    public void GiveFuel(int Amount)
    {
        FuelTotal += Amount;
        Console.WriteLine($"Horse has eaten {Amount} bundle(s) of hay. It feels like it can run for {FuelTotal} miles!");
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Fuel type: {FuelType}");
        Console.WriteLine($"Fuel total: {FuelTotal}");
    }
}