using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFirmaService
    {
        void FirmaEkle(Firma firma);
        void FirmaSil(Firma firma);
        void FirmaGuncelle(Firma firma);
        List<Firma> FirmaListele();
        List<Firma> SartlıArama(string arg);
    }
}
