﻿using DataAccess.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfKategoriDal:EfEntityRepository<Kategori,IsYeriContext>,IKategoriDal
    {

    }
}
