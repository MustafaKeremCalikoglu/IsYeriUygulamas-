using Business.Abstract;
using DataAccess.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MusteriManger:IMusteriService
    {
        IMusteriDal _musteriDal;
        public MusteriManger(IMusteriDal musteriDal)
        {
            _musteriDal = musteriDal;
        }

        public void MusteriEkle(Musteri musteri)
        {
            _musteriDal.Add(musteri);
        }

        public void MusteriGuncelle(Musteri musteri)
        {
            _musteriDal.Update(musteri);
        }

        public List<Musteri> MusteriIsmeGoreGetir(string isim)
        {
            return _musteriDal.GetAll(x=>x.MusteriAd.Contains(isim) || x.MusteriSoyad.Contains(isim) || x.MusteriMail.Contains(isim) 
            || x.MusteriTelefon.Contains(isim)).ToList();
        }

        public List<Musteri> MusteriListele()
        {
            return _musteriDal.GetAll();
        }

        public void MusteriSil(Musteri musteri)
        {
            _musteriDal.Delete(musteri);   
        }
    }

}
