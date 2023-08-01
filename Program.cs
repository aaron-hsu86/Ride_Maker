Vehicle Honda = new Vehicle("Honda", "Blue", 4, true);
Vehicle Horse = new Vehicle("Stallion", "Black", 2, false);
Vehicle Subaru = new Vehicle("Subaru", "White");
Vehicle Mecha = new Vehicle("Voltron", "Rainbow");

List<Vehicle> Vehicles = new List<Vehicle>();

Vehicles.Add(Honda);
Vehicles.Add(Horse);
Vehicles.Add(Subaru);
Vehicles.Add(Mecha);

foreach (Vehicle vehicle in Vehicles)
{
    vehicle.ShowInfo();
}

Mecha.Travel(100);
Mecha.ShowInfo();

// Mecha.Miles = 350;
// We don't want variable public because it would allow users to modify class variable, which may not be intended. It would be better to have it be private, and if we want to be able to modify the variable, we would set up a public method that would allow us to modify the variable.
Mecha.ShowInfo();