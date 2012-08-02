using System;
using System.ComponentModel.DataAnnotations;

namespace PersonWeb.Models
{  
    public class Person
    {
        public int Id { get; set; }

        private int age;
        
        [Range(0,150)]
        public int Age
        {
            set
            {
                if (value >= 0) age = value;
                else throw new ArgumentOutOfRangeException();
            }
            get { return age; }
        }

        [Range(0, 250)]
        public int Height { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [RegularExpression("^[MK]{1}$", ErrorMessage = "Må være verdien M eller K.")]
        public string Gender { get; set; }

        public string HairColor { get; set; }
    }
}