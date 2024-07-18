using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

// Instantiate the CarLot
            CarLot carLot = new CarLot();

            // 1. Using property initializers
            Car car1 = new Car
            {
                Year = 2020,
                Make = "Toyota",
                Model = "Corolla",
                EngineNoise = "Vroom",
                HonkNoise = "Beep",
                IsDriveable = true
            };
            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);
            carLot.AddCar(car1);

            // 2. Using the constructor
            Car car2 = new Car();
            car2.Year = 2018;
            car2.Make = "Honda";
            car2.Model = "Civic";
            car2.EngineNoise = "Roar";
            car2.HonkNoise = "Honk";
            car2.IsDriveable = false;
            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);
            carLot.AddCar(car2);

            // 3. Using the setter methods
            Car car3 = new Car();
            car3.SetProperties(2022, "Ford", "Mustang", "Rumble", "Hooonk", true);
            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);
            carLot.AddCar(car3);

            // Print car details
            carLot.PrintCars();
        }
    }

    public static class CarExtensions
    {
        public static void SetProperties(this Car car, int year, string make, string model, string engineNoise,
            string honkNoise, bool isDriveable)
        {
            car.Year = year;
            car.Make = make;
            car.Model = model;
            car.EngineNoise = engineNoise;
            car.HonkNoise = honkNoise;
            car.IsDriveable = isDriveable;
        }
    }
}
            
            
