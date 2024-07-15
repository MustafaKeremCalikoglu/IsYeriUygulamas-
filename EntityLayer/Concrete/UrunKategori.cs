using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class UrunKategori
    {
        public int UrunID { get; set; }
        public string UrunAd { get; set; }
        public int KategoriID { get; set; }
        
        public string KategoriAd { get; set; }

        public decimal UrunIcerdigiAdet { get; set; }
        public decimal OrtAlisFiyat { get; set; }
        public decimal BirimSatisFiyat { get; set; }
        public decimal SatisFiyat { get; set; }
        public bool UrunState { get; set; }

    }
}
