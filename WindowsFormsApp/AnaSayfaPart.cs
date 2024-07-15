using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class AnaSayfaPart : Form
    {
        public AnaSayfaPart()
        {
            InitializeComponent();
        }
        MusteriManger _musteriservice=new MusteriManger(new EfMusteriDal());
        FirmaManager _firmaservice = new FirmaManager(new EfFirmaDal());
        UrunManager _urunManager = new UrunManager(new EfUrunDal());

        private void AnaSayfaPart_Load(object sender, EventArgs e)
        {
            int kayitli_musteri =_musteriservice.MusteriListele().Count();
            int kayitli_firma = _firmaservice.FirmaListele().Count();
            int kayitli_urun=_urunManager.UrunListele().Count();

            lbl_KayitliMusteri.Text = kayitli_musteri.ToString();
            lbl_KayıtlıFirmaSayisi.Text = kayitli_firma.ToString();
            lbl_KayıtlıUrunSayısı.Text=kayitli_urun.ToString();
        }
    }
}
