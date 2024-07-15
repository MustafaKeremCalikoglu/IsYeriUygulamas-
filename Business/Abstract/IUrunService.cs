using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUrunService
    {
        void UrunEkle(Urun urun);
        void UrunSil(Urun urun);
        void UrunGuncelle(Urun urun);
        List<UrunKategori> UrunListele();
        List<UrunKategori> UrunAdaGoreAra(string arg);
        List<UrunKategori> UrunKategoriGoreAra(string v);
        List<UrunKategori> UrunKategoriveAdGoreAra(string ad,string kategori);



    }
}
