using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class IsYeriContext:DbContext
    {

        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<Firma> Firmas { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Urun> Uruns { get; set; }
        public DbSet<AlisFatura> AlisFaturas { get; set; }



    }
}
