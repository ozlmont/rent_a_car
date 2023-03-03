using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rent_a_car.ORM.Entity
{
    internal class Kiralama:BaseEntity
    {
        public int ArabaID { get; set; }      
        public virtual Araba Araba { get; set; }
        public int MusteriID { get; set; }
        public virtual Musteri Musteri { get; set; } 
        public DateTime AlisTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public DateTime KiralamaSuresi { get; set; }
        public double FaturaTutari { get; set; }
    }
}
