Car Car = new Car("Honda", "Blue", 4, "gas");
Horse Horse = new Horse("Stallion", "Black", 2, "hay");
Bike Bike = new Bike("Mountain Bike", "White", 1);
// Cannot create an instance of an abstract type or instance
// Vehicle Mecha = new Vehicle("Megazord", "Rainbow", 5, "The Morphing Matrix");

List<Vehicle> Vehicles = new List<Vehicle>();

Vehicles.Add(Car);
Vehicles.Add(Horse);
Vehicles.Add(Bike);

List<INeedFuel> INeedFuelList = new List<INeedFuel>();

// Console.WriteLine("=======================");
foreach (Vehicle transport in Vehicles)
{
    if (transport is INeedFuel)
    {
        INeedFuelList.Add((INeedFuel)transport);
    }
    // transport.ShowInfo();
    // Console.WriteLine("=======================");
}

foreach(var vehicle in INeedFuelList)
{
    vehicle.GiveFuel(10);
}
foreach(Vehicle vehicle in INeedFuelList)
{
    vehicle.ShowInfo();
}

Car.Travel(100);
Car.ShowInfo();

// Car.Miles = 350;
// We don't want variable public because it would allow users to modify class variable, which may not be intended. It would be better to have it be private, and if we want to be able to modify the variable, we would set up a public method that would allow us to modify the variable.