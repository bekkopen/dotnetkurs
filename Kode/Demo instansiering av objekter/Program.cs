namespace Demo_instansiering_av_objekter
{
    class Program
    {
        static void Main()
        {
            Driver driver = new Driver();
            driver.Name = "Johan";
            driver.Age = 28;
            driver.Car = new Car();
            driver.Car.Model = "Skoda Fabia";

            var driver2 = new Driver
            {
                Name = "Lars",
                Age = 27,
                Car = new Car
                {
                    Model = "VW Polo"
                }
            };
        }
    }
}
