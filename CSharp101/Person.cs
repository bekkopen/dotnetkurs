using System;

namespace CSharp101
{
    public enum GoodEvil
    {
        Unknown,
        Good,
        Evil        
    }

    public class Person
    {
        private int age;
        public int Age
        {
            set
            {
                if (value >= 0) age = value;
                else throw new ArgumentOutOfRangeException();
            }
            get { return age; }
        }

        public int Height { get; set; } 
        public string Name { get; set; }
        public string Gender { get; set; }
        public string HairColor { get; set; }
        public GoodEvil Behavior { get; set; }

        public void Log(string message = "Hei hei...")
        {
            Console.WriteLine("{0}: {1}", Name, message);
        }

        public void Log(params string[] messages)
        {
            foreach(var message in messages)
                Console.WriteLine("{0}: {1}", Name, message);
        }

        public override string ToString()
        {
            return string.Format("{0} ({1} år, {2}cm, {3} hår, {4}, {5})", Name, Age, Height, HairColor, Gender, Behavior);
        }
    }
}