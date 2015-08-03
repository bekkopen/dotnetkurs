namespace B___Demo_Delegates_og_Events
{
    public class Car
    {
        public string Model { get; set; }
        public int CarMileage { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, driven {1} km", Model, CarMileage);
        }
    }
}
