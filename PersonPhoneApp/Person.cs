using System;

namespace PersonPhoneApp
{  
    public class Person
    {
        public int Id { get; set; }

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
    }
}