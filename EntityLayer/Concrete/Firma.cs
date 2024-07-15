using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Firma:IEntity
    {
        public int FirmaID { get; set; }
        public string FirmaAd { get; set; }
        public string FirmaTelefon { get; set; }
        public string FirmaMail { get; set; }
        public bool FirmaState { get; set; }
    }
}
