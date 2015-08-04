using System;
using System.ComponentModel.DataAnnotations;

namespace Del2.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(0, 150)]
        public int Age { get; set; }

        public string HairColor { get; set; }

        [Range(0, 250)]
        public double Height { get; set; }

        [Required]
        [RegularExpression("^[MK]{1}$")]
        public string Gender { get; set; }

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
            return string.Format("{0} ({1} år, {2}cm, {3} hår, {4}, {5})", Name, Age, Height, HairColor, Gender);
        }
    }
}
