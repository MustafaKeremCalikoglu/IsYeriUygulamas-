using DataAccess.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAlisFaturaDal:EfEntityRepository<AlisFatura,IsYeriContext>,IAlisFaturaDal
    {
        public  AlisFatura FaturaNoveTarih()
        {
            using (IsYeriContext context=new IsYeriContext())
            {
                var result=context.AlisFaturas.Max(x => x.FaturaNo);
                AlisFatura alisFatura = context.AlisFaturas.Find(result);
                return alisFatura;
            }
            
        }
    }
}
