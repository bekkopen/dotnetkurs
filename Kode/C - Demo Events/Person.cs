using System;

namespace C___Demo_Events
{
    public class Person
    {
        public string Name { get; set; }
        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 0) _age = value;
                else throw new ArgumentException("Alder må være mer enn 0");
            }
        }
    }
}
