using System;
using System.ComponentModel.DataAnnotations;

namespace DKP.Data
{
    public class Expansion
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}
