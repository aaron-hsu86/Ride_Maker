class Vehicle
{
    string Name;
    int Passengers;
    string Color;
    bool Engine;
    /*public*/ int Miles;

    public Vehicle( string name, string color, int passengers = 3, bool engine = true )
    {
        Name = name; Color = color; Passengers = passengers; Engine = engine; Miles = 0;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Vehicle name: {Name}");
        Console.WriteLine($"Number of passengers: {Passengers}");
        Console.WriteLine($"Vehicle color: {Color}");
        if (Engine)
        {
            Console.WriteLine("Vehicle has an engine.");
        }
        else
        {
            Console.WriteLine("Vehicle does not have an engine.");
        }
        Console.WriteLine($"Miles traveled: {Miles}");
    }

    public void Travel(int distance)
    {
        Miles += distance;
        Console.WriteLine($"Total miles {Name} traveled: {Miles}");
    }
}