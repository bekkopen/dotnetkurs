using System;

namespace B___Demo_Delegates_og_Events
{
    class Program
    {
        static void Main()
        {
            var driver = new Driver
            {
                Name = "Lars",
                Age = 27,
                Car = new Car
                {
                    Model = "VW Polo",
                    CarMileage = 500000
                }
            };

            var pimpShow = new PimpMyRide();

            Console.WriteLine("Before: " + driver.Car);
            var pimpedCar = pimpShow.PimpIt(driver.Car, Wish);
            Console.WriteLine("Now: " + pimpedCar);
            Console.Read();
        }

        private static Car Wish(Car car)
        {
            car.Model = "Tesla";
            return car;
        }
    }
}
