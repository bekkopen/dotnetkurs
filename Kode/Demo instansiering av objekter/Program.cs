namespace Demo_instansiering_av_objekter
{
    class Program
    {
        static void Main()
        {
            Driver driver = new Driver();
            driver.Name = "Reodor Felgen";
            driver.Age = 42;
            driver.Car = new Car();
            driver.Car.Model = "Il Tempo Gigante";

            var driver2 = new Driver
            {
                Name = "Lars",
                Age = 28,
                Car = new Car
                {
                    Model = "VW Polo"
                }
            };
        }
    }
}
