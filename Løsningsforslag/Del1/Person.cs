using System;

namespace Del1
{
    public enum GoodEvil
    {
        Unknown,
        Good,
        Evil
    }

    public class Person
    {
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 0) _age = value;
                else throw new ArgumentOutOfRangeException();
            }
        }

        public string Name { get; set; }
        public string HairColor { get; set; }
        public double Height { get; set; }
        public string Gender { get; set; }
        public GoodEvil Behavior { get; set; }

        public void Log(string text = "Blah blah blah...", params string[] texts)
        {
            LogWithNamePrefix(text);
            foreach (var t in texts)
            {
                LogWithNamePrefix(t);
            }
        }

        private void LogWithNamePrefix(string text)
        {
            Console.WriteLine("{0}: \"{1}\"", Name, text);
        }

        public override string ToString()
        {
            return string.Format("{0} ({1} år, {2}cm, {3} hår, {4}, {5})", Name, Age, Height, HairColor, Gender, Behavior);
        }
    }
}
