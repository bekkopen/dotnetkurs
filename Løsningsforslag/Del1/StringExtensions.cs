namespace Del1
{
    public static class StringExtensions
    {
        public static bool IsValidPhoneNumber(this string number)
        {
            return number != null && number.Length >= 8;
        }
    }
}
