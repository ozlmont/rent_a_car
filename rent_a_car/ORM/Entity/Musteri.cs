using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rent_a_car.ORM.Entity
{
    internal class Musteri:BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string TC { get; set; }
        [Required]
        public string EhliyetNo { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Telefon { get; set; }
        [Required]
        public string Adres { get; set; }
        [Required]
        public string Password  { get; set; }
        [Required]
        public string Role { get; set; }

        List<Araba> arabas { get; set; }
    }
}
