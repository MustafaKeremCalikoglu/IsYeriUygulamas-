using DataAccess.Abstract;
using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUrunDal:EfEntityRepository<Urun,IsYeriContext>,IUrunDal
    {
        public  List<UrunKategori> GetAllSecili(Expression<Func<UrunKategori, bool>> filter = null)
        {
            using (var context = new IsYeriContext())
            {
                var result= from u in context.Uruns
                            join k in context.Kategoris on u.CategoryID equals k.CategoryID
                            select new UrunKategori
                            {
                                UrunID=u.UrunID,
                                UrunAd=u.UrunAd,
                                KategoriID=k.CategoryID,
                                KategoriAd=k.CategoryAd,
                                UrunIcerdigiAdet=u.UrunAdetIcerigi,
                                OrtAlisFiyat=u.OrtAlisFiyat,
                                BirimSatisFiyat=u.BirimSatisFiyat,
                                SatisFiyat=u.SatisFiyat,
                                UrunState=u.UrunState
                                
                            };

                return  filter == null ? result.ToList() : result.Where(filter).ToList();

            }
        }
    }
}
