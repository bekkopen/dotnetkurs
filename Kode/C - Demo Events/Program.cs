using System;

namespace C___Demo_Events
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

            driver.Car.WashingFluidNeedsRefill += CarOnWashingFluidNeedsRefill;

            string line;
            while ((line = Console.ReadLine()) != null)
            {
                if (line == "Wipe") driver.Car.WashAndWipe();
                else
                {
                    break;
                }
            }
        }

        private static void CarOnWashingFluidNeedsRefill()
        {
            Console.WriteLine("Jeg må visst fylle spylevæske...");
        }
    }
}
