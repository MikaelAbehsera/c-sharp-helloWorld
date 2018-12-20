using System;

//Write Vehicle class here

public class MainClass
{
  public static void Main()
  {
    //Create vehicles here
    Vehicle car = new Vehicle("car", 4, 2000, true);
    Vehicle oldcar = new Vehicle("car", 4, 1980, false);
    Vehicle bike = new Vehicle("bike", 2, 2017, true);

    // Test code
    Console.WriteLine(car.Type);
    Console.WriteLine(oldcar.Runs);
    Console.WriteLine(bike.NumTires);
  }
}

class Vehicle
{ 
  public string Type;
  public int NumTires;
  public int Year;
  public bool Runs;

  public Vehicle(string type, int numTires, int year, bool runs)
  {
    Type = type;
    NumTires = numTires;
    Year = year;
    Runs = runs;
  }
}