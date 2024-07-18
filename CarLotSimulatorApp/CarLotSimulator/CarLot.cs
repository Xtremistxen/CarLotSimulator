using System;
using System.Collections.Generic;

namespace CarLotSimulator;

public class CarLot
{
    public List<Car> Cars { get; set; } = new List<Car>();

    public void AddCar(Car car)
    {
        Cars.Add(car);
    }

    public void PrintCars()
    {
        foreach (var car in Cars)
        {
            Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");
        }
    }
}
    
