using Business.Abstract;
using DataAccess.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FirmaManager:IFirmaService
    {
        IFirmaDal _firmaDal;
        public FirmaManager(IFirmaDal firmaDal)
        {
            _firmaDal = firmaDal;
        }

        public void FirmaEkle(Firma firma)
        {
            _firmaDal.Add(firma);
        }

        public void FirmaGuncelle(Firma firma)
        {
            _firmaDal.Update(firma);
        }

        public List<Firma> FirmaListele()
        {
            return _firmaDal.GetAll(x=>x.FirmaState==true);
        }

        public void FirmaSil(Firma firma)
        {
            _firmaDal.Delete(firma);
        }

        public List<Firma> SartlıArama(string arg)
        {   
            
            return _firmaDal.GetAll(x => x.FirmaAd.Contains(arg) && x.FirmaState == true);
        }
    }
}
