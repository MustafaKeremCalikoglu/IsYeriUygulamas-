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
    public class FirmaValidator:AbstractValidator<Firma>
    {
        public FirmaValidator()
        {
            RuleFor(x => x.FirmaAd).NotEmpty().WithMessage("firma Adı Boş Geçilemez");
            RuleFor(x => x.FirmaAd).Must(harf_kontrol).WithMessage("firma adı kısmına sadece harf girişi yapabilirsiniz");
            RuleFor(x => x.FirmaTelefon).NotEmpty().WithMessage("Telefon Boş Geçilemez");
            RuleFor(x => x.FirmaTelefon).Must(rakam_kontrol).WithMessage("Telefon kısmına sadece rakam girişi yapabilirsiniz");
            RuleFor(x => x.FirmaMail).NotEmpty().WithMessage("Mail Boş Geçilemez");
            RuleFor(x => x.FirmaMail).Must(email_kontrol).WithMessage("Geçerli Mail Giriniz");
        }

        private bool harf_kontrol(string arg)
        {
            Regex regex = new Regex(@"^[a-zA-ZiİçÇşŞğĞÜüÖö\s]*$");
            //Regex regex = new Regex(@"[a-zA-Z^şŞıİçÇöÖüÜĞğ\s]*$");
            //Regex regex = new Regex(@"^[a-zA-Z]*$");
            return regex.IsMatch(arg);
        }
        private bool rakam_kontrol(string arg)
        {
            Regex regex = new Regex(@"^[0-9]*$");
            return regex.IsMatch(arg);
        }
        private bool email_kontrol(string arg)
        {
            Regex regex = new Regex(@"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$");
            return regex.IsMatch(arg);
        }

    }


}
