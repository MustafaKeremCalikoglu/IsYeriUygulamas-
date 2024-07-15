using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAlisTableService
    {
        void AlisTableEkle(AlisTable alisTable);
        void AlisTableSil(AlisTable alisTable);
        void AlisTableGuncelle(AlisTable alisTable);
        List<AlisTable> AlisTableListele();
    }
}
