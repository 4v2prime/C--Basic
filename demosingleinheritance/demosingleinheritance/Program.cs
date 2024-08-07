using System;

// Base class
class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Vehicle(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public void Start()
    {
        Console.WriteLine($"Starting the {Year} {Make} {Model}");
    }
    public void Stop()
    {
        Console.WriteLine($"Stopping the {Year} {Make} {Model}");
    }
}
// Derived class (inherits from Vehicle)
class Car : Vehicle
{    public Car(string make, string model, int year) : base(make, model, year)
    {
    }
    public void Accelerate()
    {
        Console.WriteLine($"Accelerating the {Year} {Make} {Model}");
    }
    public void Brake()
    {
        Console.WriteLine($"Applying brakes to the {Year} {Make} {Model}");
    }
}

class Program
{
    static void Main()
    {
        // Creating a Car object
        Car myCar = new Car("Toyota", "Camry", 2023);

        // Calling methods from the base class
        myCar.Start();
        myCar.Stop();

        // Calling methods from the derived class
        myCar.Accelerate();
        myCar.Brake();

        Console.ReadLine();
    }
}