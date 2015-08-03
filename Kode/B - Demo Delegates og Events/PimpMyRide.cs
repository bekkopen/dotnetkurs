namespace B___Demo_Delegates_og_Events
{
    public delegate Car HowWouldYouLikeUsToPimpIt(Car car);

    public class PimpMyRide
    {
        public Car PimpIt(Car originalCar, HowWouldYouLikeUsToPimpIt wish)
        {
            var soYouWouldLikeItLikeThis = wish(originalCar);

            soYouWouldLikeItLikeThis.Model = string.Format("Kick ass {0} {1}izzle", 
                soYouWouldLikeItLikeThis.Model,
                soYouWouldLikeItLikeThis.Model[0]);

            soYouWouldLikeItLikeThis.CarMileage = 0;

            return soYouWouldLikeItLikeThis;
        }
    }
}
