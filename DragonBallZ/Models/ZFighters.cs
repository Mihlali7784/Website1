using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace DragonBallZ.Models
{
    public class ZFighters
    {
        [Key]
        public int ID { get; set; }
        [DisplayName("Name")]
        [Required]
        public string Name { get; set; }
        [Required]
        public string Race { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Abilities { get; set; }
        [Required]
        public string Weakness { get; set; }


    }
}
