using System;
using System.Collections.Generic;
using System.Linq;

namespace C___Demo_LINQ
{
    class Program
    {
        static void Main()
        {
            var persons = new List<Person>
            {
                new Person {Name = "Steinar", Age = 40},
                new Person {Name = "Tore", Age = 34},
                new Person {Name = "Bjarte", Age = 100}
            };

            var personsOverFortyFive = from person in persons
                                        where person.Age > 45
                                        select person;

            foreach (var person in personsOverFortyFive)
            {
                Console.WriteLine(person);
            }

            Console.Read();
        }
    }
}
