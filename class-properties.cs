using System;

//Write Vehicle class here

public class MainClass
{
  public static void Main()
  {
    //Create vehicles here
    Vehicle car = new Vehicle();
    Vehicle oldcar = new Vehicle();
    Vehicle bike = new Vehicle();

    // Test code
    Console.WriteLine(car.Type);
    Console.WriteLine(oldcar.Runs);
    Console.WriteLine(bike.NumTires);
  }
}

class Vehicle
{
  public Vehicle(string Type, int NumTires, int Year, bool Runs)
  {
    Type = Type;
    NumTires = NumTires;
    Year = Year;
    Runs = Runs;
  }
}