using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Urun:IEntity
    {
        [Key]
        public int UrunID { get; set; }
        public string UrunAd { get; set; }
        public int CategoryID { get; set; }
        public decimal UrunAdetIcerigi { get; set; }
        public decimal OrtAlisFiyat { get; set; }
        public decimal BirimSatisFiyat { get; set; }
        public decimal SatisFiyat { get; set; }
        public bool UrunState { get; set; }
    }
}
