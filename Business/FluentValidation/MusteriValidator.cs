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
    public class MusteriValidator:AbstractValidator<Musteri>
    {
        public MusteriValidator()
        {
            RuleFor(x => x.MusteriAd).NotEmpty().WithMessage("Ad Kısmı Boş Geçilemez");
            RuleFor(x => x.MusteriSoyad).NotEmpty().WithMessage("Soyad Kısmı boş geçilemez");
            RuleFor(x => x.MusteriUnvan).NotEmpty().WithMessage("Unvan kısmı Boş Geçilemez");
            RuleFor(x => x.MusteriTelefon).Must(rakam_kontrolu).WithMessage("Telefon numarası rakamlardan oluşmalıdır");
            RuleFor(x => x.MusteriTelefon).NotEmpty().WithMessage("Telefon Numarası boş geçilemez");
            RuleFor(x => x.MusteriTelefon).Length(11).WithMessage("Telefon Numarası 11 haneli başında 0 olarak yazınız");
            RuleFor(x => x.MusteriMail).NotEmpty().WithMessage("Email boş geçilemez");
            RuleFor(x => x.MusteriMail).Must(email_kontrolu).WithMessage("Email doğru girilmeli");
        }
        private bool harf_kontrol(string arg)
        {
            Regex regex = new Regex(@"^[a-zA-ZiİçÇşŞğĞÜüÖö\s]*$");
            //Regex regex = new Regex("\\b\\w+\\b");
            //Regex regex = new Regex(@"^[a-zA-Z]*$");
            return regex.IsMatch(arg);
        }
        private bool rakam_kontrolu(string arg)
        {
            Regex regex = new Regex(@"^[0-9]*$");
            return regex.IsMatch(arg);
        }
        private bool email_kontrolu(string arg)
        {
            Regex regex = new Regex(@"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$");
            return regex.IsMatch(arg);
        }

    }
}
