using System;
using System.ComponentModel.DataAnnotations;

namespace DKP.Data
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public float DKP { get; set; }
    }
}
