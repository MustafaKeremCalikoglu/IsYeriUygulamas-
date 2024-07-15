using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AlisTable:IEntity
    {

        public int AlisID { get; set; }
        public int FaturaNo { get; set; }
        public string UrunID { get; set; }
        public Decimal AlisFiyat { get; set; }
        public Decimal AlisAdet { get; set; }
        public int FirmaID { get; set; }


    }
}
