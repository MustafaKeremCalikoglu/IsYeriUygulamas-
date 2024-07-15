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
    public class AlisFaturaManager : IAlisFaturaService
    {   
        IAlisFaturaDal _alisFaturaService;
        public AlisFaturaManager(IAlisFaturaDal alisFaturaService)
        {
              _alisFaturaService= alisFaturaService;
        }
        public void AlisFaturaEkle(AlisFatura alisFatura)
        {
            _alisFaturaService.Add(alisFatura);
        }

        public AlisFatura AlisFaturaListele()
        {
            return _alisFaturaService.FaturaNoveTarih();
        }

        
    }
}
