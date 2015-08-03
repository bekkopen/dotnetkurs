using System;
using System.CodeDom;

namespace Demo
{
    public class Driver
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Car Car { get; set; }

        public Driver()
        {
            Car = new Car();
        }

        public void Drive()
        {
            Car.Start();
            Console.WriteLine("{0} started driving", Name);
        }
    }

    public class Car
    {
        public string Model { get; set; }
        public string RegistrationNumber { get; set; }
        public bool IsRolling { get; private set; }
        private double _washerFluid;
        public double WasherFluid
        {
            get { return _washerFluid; }
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Washerfluid cannot be less than 0");

                _washerFluid = value;
            }
        }

        public event Action WasherFluidWarningLightWasLit;

        protected virtual void OnWasherFluidWarningLightWasLit()
        {
            Action handler = WasherFluidWarningLightWasLit;
            if (handler != null) handler();
        }

        public Car()
        {
            WasherFluid = 100;
        }

        public void Start()
        {
            IsRolling = true;
        }

        public void CleanWindshield()
        {
            if (WasherFluid > 20)
                WasherFluid -= 20;
            else 
                OnWasherFluidWarningLightWasLit();
        }

        public void SuggestRoute(IsConsideredACoolCar isConsideredACoolCar)
        {
            if (isConsideredACoolCar(this))
            {
                Console.WriteLine("{0} bør kjøre Karl Johans gate.", Model);
            }
            else
            {
                Console.WriteLine("{0} bør kjøre E6.", Model);
            }
        }
    }

    public delegate bool IsConsideredACoolCar(Car car);
}
