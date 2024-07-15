using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Kategori:IEntity
    {
        [Key]
        public int CategoryID { get; set; }
        //public string fullname { get
        //    {
        //        return CategoryAd + " oldu be";
        //    } }
        public string CategoryAd { get; set; }
    
    }
}
