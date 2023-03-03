using rent_a_car.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rent_a_car.ORM.Context
{
    internal class ProjectContext :DbContext
    {
        public ProjectContext() 
        {
            Database.Connection.ConnectionString = "Server=.;Database=RentACar;uid=sa;password:1558";
        }
        
        public DbSet<Araba>Arabas { get; set; }

        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<Kiralama> Kiralama { get; set; }
    }
}
