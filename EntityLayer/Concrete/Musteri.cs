using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Musteri:IEntity
    {
        public int MusteriID { get; set; }
        public string MusteriAd { get; set; }
        public string MusteriSoyad { get; set; }
        public string MusteriUnvan { get; set; }
        public string MusteriTelefon { get; set; }
        public string MusteriMail { get; set; }
        public string MusteriImage { get; set; }
        public DateTime MusteriKayıtTarihi { get; set; }

    }
}
