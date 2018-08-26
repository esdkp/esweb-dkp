using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DKP.Data
{
    public class Character
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
