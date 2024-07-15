using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UrunManager : IUrunService
    {
        IUrunDal _urunDal;
        public UrunManager(IUrunDal urunDal)
        {
            _urunDal = urunDal;
        }
        public void UrunGuncelle(Urun urun)
        {
            _urunDal.Update(urun);
        }

        public void UrunEkle(Urun urun)
        {
            _urunDal.Add(urun);
        }

        public List<UrunKategori> UrunListele()
        {
            return _urunDal.GetAllSecili(x=>x.UrunState==true);
        }

        public void UrunSil(Urun urun)
        {
            _urunDal.Delete(urun);
        }

        public List<UrunKategori> UrunAdaGoreAra(string arg)
        {
            return _urunDal.GetAllSecili(x => x.UrunAd.Contains(arg) && x.UrunState == true);
        }

        

        public List<UrunKategori> UrunKategoriGoreAra(string v)
        {
            return _urunDal.GetAllSecili(x => x.KategoriAd.Contains(v) && x.UrunState == true);

        }

        public List<UrunKategori> UrunKategoriveAdGoreAra(string ad, string kategori)
        {
            return _urunDal.GetAllSecili(x => x.KategoriAd.Contains(kategori) && x.UrunState == true && x.UrunAd.Contains(ad));

        }
    }
}
