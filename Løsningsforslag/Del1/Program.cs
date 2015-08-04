using System;
using System.Linq;

namespace Del1
{
    class Program
    {
        static void Main(string[] args)
        {
            Oppgave1();
            Oppgave2til3();
            Oppgave4til5();
            Oppgave6();
            Oppgave7();
            Oppgave8();
            Oppgave9();
            Oppgave10();
        }

        static void Oppgave1()
        {
            Console.WriteLine("Oppgave 1");
            Console.WriteLine("Hello World");
            Console.WriteLine();
        }

        static void Oppgave2til3()
        {
            Console.WriteLine("Oppgave 2 til 3");

            var person = new Person
            {
                Name = "Lars"
            };

            Console.WriteLine("Starter loggen...");
            Console.WriteLine();

            person.Log("Hello");
            person.Log("Hei Bootcamp", "C# er rått");

            Console.WriteLine();
        }

        public static void Oppgave4til5()
        {
            Console.WriteLine("Oppgave 4 til 5");
            Console.WriteLine();

            var personer = LagPersoner();

            foreach (var person in personer)
                Console.WriteLine(person.ToString());

            Console.WriteLine();
        }

        public static void Oppgave6()
        {
            Console.WriteLine("Oppgave 6");

            var personer = LagPersoner();

            var mistenkte = from person in personer
                            where person.Age > 100 || person.HairColor.Equals("Svart")
                            select person;

            foreach (var person in mistenkte)
                Console.WriteLine(person.ToString());

            Console.WriteLine();
        }

        public static void Oppgave7()
        {
            Console.WriteLine("Oppgave 7");

            var personer = LagPersoner();

            var grupper = from person in personer
                          group person by person.Behavior
                              into g
                              select new { Oppførsel = g.Key, Personer = g };

            foreach (var item in grupper)
            {
                Console.WriteLine("Personer som er {0}", item.Oppførsel);
                foreach (var person in item.Personer)
                    Console.WriteLine("   {0}", person);
                Console.WriteLine();
            }
        }

        public static void Oppgave8()
        {
            Console.WriteLine("Oppgave 8");

            string number = null;
            Console.WriteLine("{0} is valid: {1}", number, number.IsValidPhoneNumber());

            number = "123";
            Console.WriteLine("{0} is valid: {1}", number, number.IsValidPhoneNumber());

            number = "97706660";
            Console.WriteLine("{0} is valid: {1}", number, number.IsValidPhoneNumber());

            Console.WriteLine();
        }

        public static void Oppgave9()
        {
            Console.WriteLine("Oppgave 9");

            var personer = LagPersoner();

            Predicate<Person> predicate = p => p.Age > 80;
            var over80 = Array.Find(personer, predicate);

            Console.WriteLine("{0} er over 80", over80.Name);

            Console.WriteLine();
        }

        public static void Oppgave10()
        {
            Console.WriteLine("Oppgave 10.1");
            var personer = LagPersoner();

            var suspects = personer.Where(p => p.Height > 180 & p.HairColor == "Brun");
            foreach (var suspect in suspects)
                Console.WriteLine(suspect.ToString());
            Console.WriteLine();

            Console.WriteLine("Oppgave 10.2");
            var names = personer.Select(p => p.Name);
            foreach (var name in names)
                Console.WriteLine(name);

            Console.WriteLine();
        }

        static Person[] LagPersoner()
        {
            var personer = new[] {
                new Person { Name="Patric Bateman", Age=27, HairColor="Brun", Height=184, Behavior=GoodEvil.Evil, Gender="M"},
                new Person { Name="Mystique", Age=127, HairColor="Rød", Height=177, Behavior=GoodEvil.Evil, Gender="K"},
                new Person { Name="Two Face", Age=58, HairColor="Brun", Height=183, Behavior=GoodEvil.Evil, Gender="M"},
                new Person { Name="Cruella De Vil", Age=65, HairColor="Svart og hvitt", Height=168, Behavior=GoodEvil.Evil, Gender="K"},
                new Person { Name="Orochimaru", Age=100, HairColor="Svart", Height=180, Behavior=GoodEvil.Evil, Gender="M"},
                new Person { Name="Harvey Dent", Age=56, HairColor="Brun", Height=183, Behavior=GoodEvil.Good, Gender="M"},
                new Person { Name="Kongen Harald", Age=78, HairColor="Ukjent", Height=150, Behavior=GoodEvil.Good, Gender="M"}
            };
            return personer;
        }
    }
}
