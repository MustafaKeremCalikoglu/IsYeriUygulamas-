using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Business.Abstract
{
    public interface IMusteriService
    {
        void MusteriEkle(Musteri musteri);
        void MusteriSil(Musteri musteri);
        void MusteriGuncelle(Musteri musteri);
        List<Musteri> MusteriListele();
        List<Musteri> MusteriIsmeGoreGetir(string isim);


    }
}
