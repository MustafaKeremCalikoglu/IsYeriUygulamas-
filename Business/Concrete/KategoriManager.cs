using Business.Abstract;
using DataAccess.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class KategoriManager : IKategoriService
    {   
        IKategoriDal _kategoriDal;
        public KategoriManager(IKategoriDal kategoriDal)
        {
            _kategoriDal = kategoriDal;
        }

        public void KategoriEkle(Kategori kategori)
        {
            _kategoriDal.Add(kategori);
        }

        public void KategoriGuncelle(Kategori kategori)
        {
            _kategoriDal.Update(kategori);
        }

        public List<Kategori> KategoriListele()
        {
            return _kategoriDal.GetAll();
        }

        public void KategoriSil(Kategori kategori)
        {
        }
    }
}
