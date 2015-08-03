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
                new Person {Name = "Steinar", Age = 39},
                new Person {Name = "Tore", Age = 33},
                new Person {Name = "Bjarte", Age = 100}
            };

            var personsUnderForty = from person in persons
                                    where person.Age < 40
                                    select person;

            foreach (var person in personsUnderForty)
            {
                Console.WriteLine(person);
            }
        }
    }
}
