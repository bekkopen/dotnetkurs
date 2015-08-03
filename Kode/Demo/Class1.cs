using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace Demo
{
    public class Class1
    {
        static void Main(string[] args)
        {
            //Demo1();
            //Demo2();
            Demo3();
        }

        public static void Demo1()
        {
            Console.WriteLine("Hei Bootcamp!");
        }

        public static void Demo2()
        {
            Driver driver = new Driver();
            driver.Name = "Johan";
            driver.Age = 27;
            driver.Drive();
        }

        public static void Demo3()
        {
            var car = new Car{Model = "Polo"};
            car.SuggestRoute(IsCool);

            IsConsideredACoolCar method = delegate(Car car1) { return car1.IsRolling; };
            car.SuggestRoute(method);

            car.WasherFluidWarningLightWasLit += CarOnWasherFluidWarningLightWasLit;

            string line;
            while ((line = Console.ReadLine()) != null)
            {
                if (line == "Clean") car.CleanWindshield();
                else break;
            }
        }

        private static void CarOnWasherFluidWarningLightWasLit()
        {
            Console.WriteLine("You should buy some more washing fluid");
        }

        private static bool IsCool(Car car)
        {
            return car.Model == "Polo";
        }
    }
}
