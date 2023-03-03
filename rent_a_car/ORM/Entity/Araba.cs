using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rent_a_car.ORM.Entity
{
    internal class Araba:BaseEntity
    {
        [Required]
        public string Plaka { get; set; }
        [Required]
        public string Marka { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string AracTipi { get; set; }
        [Required]
        public string Vites { get; set; }
        [Required]
        public string YakitTipi { get; set; }
        [Required]
        public string Fiyat { get; set; }
        
        List<Musteri> musteris { get; set; }
    }
}
