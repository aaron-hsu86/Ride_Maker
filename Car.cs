public class Car : Vehicle, INeedFuel
{
    public string FuelType { get; set; }
    public int FuelTotal { get; set; }
    public Car(string name, string color, int passengers, string fuelType) : base(name, color, passengers, true)
    {
        FuelType = fuelType;
        FuelTotal = 10;
    }

    public void GiveFuel(int Amount)
    {
        FuelTotal += Amount;
        Console.WriteLine($"Added {Amount} of fuel to the car. Car now has {FuelTotal} gallons of fuel");
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Fuel type: {FuelType}");
        Console.WriteLine($"Fuel total: {FuelTotal}");
    }
}