using System;
class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car
        {
            Model = "Camry",
            Year = 2022,
            Brand = "Toyota",
            Mileage = 203,
            FuelType = "Diesel"
        };

        Console.WriteLine($"My car is a {myCar.Year} {myCar.Brand} {myCar.Model} ({myCar.FuelType}) with {myCar.Mileage} mileage.");
        myCar.Start();
        myCar.go();
        myCar.Stop();
    }
}