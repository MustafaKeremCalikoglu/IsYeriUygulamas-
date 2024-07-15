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
    public class AlisTableManager:IAlisTableService
    {
        IAlisTableDal _alisTableDal;
        public AlisTableManager(IAlisTableDal alisTableDal)
        {
            _alisTableDal = alisTableDal;
        }

        public void AlisTableEkle(AlisTable alisTable)
        {
            _alisTableDal.Add(alisTable);
        }

        public void AlisTableGuncelle(AlisTable alisTable)
        {
            _alisTableDal.Update(alisTable);
        }

        public List<AlisTable> AlisTableListele()
        {
            return _alisTableDal.GetAll();
        }

        public void AlisTableSil(AlisTable alisTable)
        {
            _alisTableDal.Delete(alisTable);
        }
    }
}
