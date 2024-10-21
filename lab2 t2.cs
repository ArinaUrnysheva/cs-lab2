using System;

public class Vehicle
{
    public double X { get; set; } //координаты
    public double Y { get; set; }
    public decimal Price { get; set; } //цена
    public double Speed { get; set; } //скорость
    public int Year { get; set; } //год выпуска

    public Vehicle(double x, double y, decimal price, double speed, int year) //конструктор
    {
        X = x;
        Y = y;
        Price = price;
        Speed = speed;
        Year = year;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Coordinates: ({X}, {Y})");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Speed: {Speed}");
        Console.WriteLine($"Year: {Year}");
    }
}

public class Plane : Vehicle
{
    public int NumOfPass { get; set; }
    public double Altitude { get; set; }
    public Plane(double x, double y, decimal price, double speed, int year, int numofpass, double altitude) : base(x, y, price, speed, year)
    {
        Altitude = altitude;
        NumOfPass = numofpass;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Altitude is: {Altitude}");
        Console.WriteLine($"Number of passengers is: {NumOfPass}");
    }
}


public class Car : Vehicle
{
    public int NumOfPass1 { get; set; }

    public Car(double x, double y, decimal price, double speed, int year, int numofpass1) : base(x, y, price, speed, year)
    {
        NumOfPass1 = numofpass1;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Number of passengers: {NumOfPass1}");
    }
}
public class Ship : Vehicle
{
    public int NumOfPass2 { get; set; }
    public string Port { get; set; }
    public Ship(double x, double y, decimal price, double speed, int year, int numofpass2, string port) : base(x, y, price, speed, year)
    {
        Port = port;
        NumOfPass2 = numofpass2;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Number of passengers: {NumOfPass2}");
        Console.WriteLine($"Name of port is: {Port}");  
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vehicle[] vehicles = new Vehicle[]
        {
            new Plane(10, 20, 500000m, 900, 2020, 10000, 180),
            new Car(5, 10, 20000m, 120, 2018, 5),
            new Ship(15, 25, 800000m, 30, 2021, 100, "Нью-Йорк")
        };

        foreach (var vehicle in vehicles)
        {
            vehicle.PrintInfo();
            Console.WriteLine(); // Разделяем вывод между средствами передвижения
        }
    }
}