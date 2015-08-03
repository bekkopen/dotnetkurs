using System;

namespace C___Demo_Events
{
    public class Car
    {
        public string Model { get; set; }
        public int CarMileage { get; set; }

        private int _washingFluidLevels;
        public int WashingFluidLevels
        {
            get
            {
                return _washingFluidLevels;
            }
            set
            {
                if(value <= 20) OnWashingFluidNeedsRefill();
                if (value >= 0) _washingFluidLevels = value;
                else throw new ArgumentException("Washing fluid levels cannot be less than 0");
            }
        }

        public event Action WashingFluidNeedsRefill;
        protected virtual void OnWashingFluidNeedsRefill()
        {
            Action handler = WashingFluidNeedsRefill;
            if (handler != null) handler();
        }

        public Car()
        {
            WashingFluidLevels = 100;
        }

        public void WashAndWipe()
        {
            if (WashingFluidLevels <= 0) Console.WriteLine("Sorry, can't wash");
            else WashingFluidLevels -= 20;
        }

        public override string ToString()
        {
            return string.Format("{0}, driven {1} km", Model, CarMileage);
        }
    }
}
