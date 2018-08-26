using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DKP.Data
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } // Potentially name of main character

        public List<Character> Characters { get; set; }
    }
}
