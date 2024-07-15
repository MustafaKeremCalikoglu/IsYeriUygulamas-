using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business.FluentValidation
{
    public class UrunValidator:AbstractValidator<Urun>
    {
        public UrunValidator()
        {
            RuleFor(x => x.UrunAd).NotEmpty().WithMessage("Ürün adı Boş Geçilemez");
            RuleFor(x => x.UrunAd).Must(harf_kontrol).WithMessage("sadece harf girebilirsiniz");
        }
        private bool harf_kontrol(string arg)
        {
            Regex regex = new Regex(@"^[a-zA-ZiİçÇşŞğĞÜüÖö\s]*$");
            //Regex regex = new Regex("\\b\\w+\\b");
            //Regex regex = new Regex(@"^[a-zA-Z]*$");
            return regex.IsMatch(arg);
        }
        private bool rakam_kontrolu(decimal arg)
        {
            Regex regex = new Regex(@"^[0-9.]*$");
            return regex.IsMatch(arg.ToString());
        }
        
    }
}
