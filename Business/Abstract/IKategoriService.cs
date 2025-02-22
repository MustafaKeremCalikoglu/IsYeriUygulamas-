﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IKategoriService
    {
        void KategoriEkle(Kategori kategori);
        void KategoriSil(Kategori kategori);
        void KategoriGuncelle(Kategori kategori);
        List<Kategori> KategoriListele();
    }
}
